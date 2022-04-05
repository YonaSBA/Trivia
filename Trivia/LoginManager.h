#pragma once

#include "LoggedUser.h"
#include "sqliteDatabase.h" 

class LoginManager
{
public:
	LoginManager(IDatabase* dataBase);

	void logout(string name);
	void login(string name, string password);
	void signup(string name, string password, string email);

private:
	IDatabase* m_database;
	vector<LoggedUser> m_loggedUsers;
};