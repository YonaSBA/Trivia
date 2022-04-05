#include "LoginManager.h"

LoginManager::LoginManager(IDatabase* dataBase) :
	m_database(dataBase), m_loggedUsers() {}

void LoginManager::logout(string name)
{
	vector<LoggedUser>::iterator it = find(m_loggedUsers.begin(), m_loggedUsers.end(), LoggedUser(name)); // Search if user exist.

	if (it != m_loggedUsers.end())
	{
		m_loggedUsers.erase(it);
	}
	else
	{
		throw exception("User doesn't login.");
	}
}

void LoginManager::login(string name, string password)
{
	LoggedUser user(name);

	if (m_database->doesUserExist(name))
	{
		if (m_loggedUsers.empty() || find(m_loggedUsers.begin(), m_loggedUsers.end(), user) == m_loggedUsers.end())	 // If empty, thats the first login, else, check if exist.
		{
			if (m_database->doesPasswordMatch(name, password))
			{
				m_loggedUsers.push_back(user);
			}
			else
			{
				throw exception("Password doesn't match.");
			}
		}
		else
		{
			throw exception("User already in.");
		}
	}
	else
	{
		throw exception("User doesn't exist.");
	}
}

void LoginManager::signup(string name, string password, string email)
{
	if (Helper::isValid(name))
	{
		if (!m_database->doesUserExist(name))
		{
			m_database->addNewUser(name, password, email);
		}
		else
		{
			throw exception("Username already exist.");
		}
	}
	else
	{
		throw exception("Username Invalid.");
	}
}
