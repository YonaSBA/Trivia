#pragma once

#include "IDatabase.h"

#define SIZE 200
#define DB "triviaDB.sqlite"

class sqliteDatabase : public IDatabase
{
private:
	sqlite3* m_db;
	vector<string> m_arg;

public:
	sqliteDatabase();
	~sqliteDatabase();

	bool doesUserExist(string name) override;
	bool doesPasswordMatch(string name, string password) override;
	void addNewUser(string name, string password, string email) override;

	int getNumOfPlayerGames(string name) override;
	float getPlayerBestScore(string name) override;
	int getNumOfTotalAnswers(string name) override;
	int getNumOfCorrectAnswers(string name) override;
	float getPlayerAverageAnswerTime(string name) override;

	vector<string> getUsersNames() override;
	list<Question> getQuestions(int question) override;

private:
	void sql(string query);
	string format(string main, ...);
	static int callback(void* data, int argc, char** argv, char** azColName);
};