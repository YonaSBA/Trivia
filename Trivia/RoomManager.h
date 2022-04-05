#pragma once

#include "Room.h"

class RoomManager
{
private:
	map<int, Room> m_rooms;

public:
	void deleteRoom(int ID);
	void joinRoom(LoggedUser user, int ID);
	void createRoom(LoggedUser maker, RoomData data);

	vector<RoomData> getRooms();
	unsigned int getRoomState(int ID);
	vector<string> getPlayersInRoom(int ID);
};

