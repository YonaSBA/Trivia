#include "LoggedUser.h"

LoggedUser::LoggedUser(string name) :
    m_username(name) {}

string LoggedUser::getUsername()
{
    return m_username;
}

bool operator==(const LoggedUser& first, const LoggedUser& second)
{
    return first.m_username == second.m_username;
}
