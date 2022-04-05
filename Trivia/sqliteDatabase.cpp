#include "sqliteDatabase.h"

sqliteDatabase::sqliteDatabase()
{
	m_arg.push_back("Hello");			// Push for the first clear.
	int isNotExist = _access(DB, 0);

	if (sqlite3_open(DB, &m_db) != SQLITE_OK)
	{
		m_db = nullptr;
		throw exception(__FUNCTION__ " - DB");
	}

	if (isNotExist)
	{
		// Create tables.
		sql("CREATE TABLE USERS(NAME TEXT PRIMARY KEY NOT NULL, PASSWORD TEXT NOT NULL, EMAIL TEXT NOT NULL);");
		sql("CREATE TABLE QUESTIONS(QUESTION TEXT PRIMARY KEY NOT NULL, ANS1 TEXT NOT NULL, ANS2 TEXT NOT NULL, ANS3 TEXT NOT NULL, ANS4 TEXT NOT NULL, CORRECT INTEGER NOT NULL);");
		sql("CREATE TABLE STATISTICS(NAME TEXT PRIMARY KEY NOT NULL, CORRECTS INTEGER NOT NULL, TOTAL_ANSWERS INTEGER NOT NULL, GAMES INTEGER NOT NULL, AVERAGE_TIME FLOAT NOT NULL, SCORE INTEGET NOT NULL);");
		
		// Insert questions.
		sql("INSERT INTO QUESTIONS VALUES ('What is a baby goat called?', 'A kid', 'Baby', 'Goaty', 'Thinygoat', 1);");
		sql("INSERT INTO QUESTIONS VALUES ('How many teeth does an aardvark have?', 'None', 'Three', 'Twenty', 'Fifteen', 1);");
		sql("INSERT INTO QUESTIONS VALUES ('Coprastastaphobia is the fear of what?', 'Hospital', 'Constipation', 'Fear', 'Clown', 2);");
		sql("INSERT INTO QUESTIONS VALUES ('What color are aircraft black boxes?', 'Black', 'White', 'Dark yellow', 'Bright orange', 4);");
		sql("INSERT INTO QUESTIONS VALUES ('What is the most common color of toilet paper in France?', 'White', 'Pink', 'Red', 'Yellow', 2);");
		sql("INSERT INTO QUESTIONS VALUES ('What was the first fruit that was eaten on the moon?', 'Banana', 'Grapes', 'Watermelon', 'Peach', 4);");
		sql("INSERT INTO QUESTIONS VALUES ('In what month does Russia celebrate the October Revolution?', 'October', 'September', 'November', 'December', 3);");
		sql("INSERT INTO QUESTIONS VALUES ('Who sang about being an “eggman” and a “walrus”?', 'Pink Floyd', 'Travis Scott', 'Michael Jackson', 'The Beatles', 4);");
		sql("INSERT INTO QUESTIONS VALUES ('In what European city can you be jailed for not killing furry caterpillars?', 'Paris', 'Brussels', 'Rome', 'London', 2);");
		sql("INSERT INTO QUESTIONS VALUES ('According to Russian law, a homeless person must be where after 10 pm?', 'At street', 'At a big carton', 'At home', 'At a playground', 3);");
	}
}

sqliteDatabase::~sqliteDatabase()
{
	sqlite3_close(m_db);
	m_db = nullptr;
}

bool sqliteDatabase::doesUserExist(string name)
{
	sql(format("SELECT NAME FROM USERS WHERE NAME == '{}';", name));
	return m_arg.size(); // If the number of strings is greater than 0 there is a username.
}

bool sqliteDatabase::doesPasswordMatch(string name, string password)
{
	sql(format("SELECT NAME FROM USERS WHERE PASSWORD == '{}';", password));

	// Check if the entered name matches the names with the entered password:
	for (int i = 0; i < m_arg.size(); i++)
	{
		if (m_arg[i] == name)
		{
			return true;
		}
	}
	return false;
}

void sqliteDatabase::addNewUser(string name, string password, string email)
{
	sql(format("INSERT INTO USERS VALUES ('{}', '{}', '{}');", name, password, email));
	sql(format("INSERT INTO STATISTICS VALUES ('{}', 0, 0, 0, 0, 0);", name));
}

int sqliteDatabase::getNumOfPlayerGames(string name)
{
	sql(format("SELECT GAMES FROM STATISTICS WHERE NAME == '{}';", name));
	return stoi(m_arg[0]);
}

float sqliteDatabase::getPlayerBestScore(string name)
{
	sql(format("SELECT SCORE FROM STATISTICS WHERE NAME == '{}';", name));
	return stof(m_arg[0]);
}

int sqliteDatabase::getNumOfTotalAnswers(string name)
{
	sql(format("SELECT TOTAL_ANSWERS FROM STATISTICS WHERE NAME == '{}';", name));
	return stoi(m_arg[0]);
}

int sqliteDatabase::getNumOfCorrectAnswers(string name)
{
	sql(format("SELECT CORRECTS FROM STATISTICS WHERE NAME == '{}';", name));
	return stoi(m_arg[0]);
}

float sqliteDatabase::getPlayerAverageAnswerTime(string name)
{
	sql(format("SELECT AVERAGE_TIME FROM STATISTICS WHERE NAME == '{}';", name));
	return stof(m_arg[0]);
}

vector<string> sqliteDatabase::getUsersNames()
{
	sql("SELECT NAME FROM USERS;");
	return m_arg;
}

list<Question> sqliteDatabase::getQuestions(int question)
{
	list<Question> questions;
	sql(format("SELECT * FROM QUESTIONS LIMIT {};", to_string(question)));
	
	for (int i = 0; i < m_arg.size();)
	{
		questions.push_back(Question { stoi(m_arg[i++]), m_arg[i++], m_arg[i++], m_arg[i++], m_arg[i++], m_arg[i++] });
	}

	return questions;
}

void sqliteDatabase::sql(string query)
{
	if (query.substr(0, 6) == "SELECT")
	{
		m_arg.clear();		// Reset arguments.

		if (sqlite3_exec(m_db, query.c_str(), callback, &m_arg, nullptr) != SQLITE_OK)
		{
			throw exception("ERROR: SQL(DB) FAILED");		// Just for debugging.
		}
	}
	else
	{
		if (sqlite3_exec(m_db, query.c_str(), nullptr, nullptr, nullptr) != SQLITE_OK)
		{
			throw exception("ERROR: SQL(DB) FAILED");		// Just for debugging.
		}
	}
}

string sqliteDatabase::format(string main, ...)
{
	int index = 0;
	va_list words;
	va_start(words, main);

	while ((index = main.find("{}")) != string::npos)
	{
		main.replace(index, 2, va_arg(words, string));
	}

	va_end(words);
	return main;
}

int sqliteDatabase::callback(void* data, int argc, char** argv, char** azColName)
{
	vector<string>* arg = reinterpret_cast<vector<string>*>(data);

	for (int i = 0; i < argc; i++)
	{
		arg->push_back(string(argv[i]));
	}
	
	return 0;
}