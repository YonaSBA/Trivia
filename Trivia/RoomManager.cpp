#include "RoomManager.h"

void RoomManager::deleteRoom(int ID)
{
	m_rooms.erase(ID);
}

void RoomManager::joinRoom(LoggedUser user, int ID)
{
	if (m_rooms[ID].getData().maxPlayers >= m_rooms[ID].getAllUsers().size())
	{
		m_rooms[ID].addUser(user);
	}
	else
	{
		throw exception("The room is full.");
	}
}

void RoomManager::createRoom(LoggedUser maker, RoomData data)
{
	if (Helper::isValid(data.name))
	{
		for (int i = 1; i <= m_rooms.size(); i++)
		{
			if (m_rooms[i].getData().name == data.name)
			{
				throw exception("Room name already taken.");
			}
		}
	}
	else
	{
		throw exception("Room name invalid.");
	}

	m_rooms.insert(pair<int, Room>(data.id, Room(data, maker)));
}

vector<RoomData> RoomManager::getRooms()
{
	vector<RoomData> rooms;

	if (m_rooms.size())
	{
		for (int i = 1; i <= m_rooms.size(); i++)
		{
			rooms.push_back(m_rooms[i].getData());
		}
	}
	else
	{
		throw exception("EMPTY");
	}

	return rooms;
}

vector<string> RoomManager::getPlayersInRoom(int ID)
{
	return m_rooms[ID].getAllUsers();
}

unsigned int RoomManager::getRoomState(int ID)
{
	return m_rooms[ID].getData().isActive;
}
