#include "Room.h"

unsigned int RoomData::counter = 0;

Room::Room() :
    m_metaData(), m_users() {}      

Room::Room(RoomData data, LoggedUser maker) :
    m_metaData(data) 
{
    m_users.push_back(maker);
}

RoomData Room::getData()
{
    return m_metaData;
}

vector<string> Room::getAllUsers()
{
    vector<string> names;

    for (int i = 0; i < m_users.size(); i++)
    {
        names.push_back(m_users[i].getUsername());
    }

    return names;       // vector of users names.
}

void Room::addUser(LoggedUser user)
{
    m_users.push_back(user);
}

void Room::removeUser(LoggedUser user)
{
    m_users.erase(find(m_users.begin(), m_users.end(), user));
}
