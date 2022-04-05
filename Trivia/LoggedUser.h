#pragma once

#include "Helper.h"

class LoggedUser
{
public:
	LoggedUser(string name);

	string getUsername();
	friend bool operator==(const LoggedUser& first, const LoggedUser& second);

private:
	string m_username;
};