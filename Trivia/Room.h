#pragma once

#include "Helper.h"
#include "LoggedUser.h"

struct RoomData
{
	string name;
	unsigned int id;
	unsigned int isActive;
	unsigned int maxPlayers;
	static unsigned int counter;
	unsigned int timePerQuestion;
	unsigned int numOfQuestionsInGame;

	operator json() const
	{
		json data;

		data["id"] = id;
		data["name"] = name;
		data["isActive"] = isActive;
		data["maxPlayers"] = maxPlayers;
		data["answerTime"] = timePerQuestion;
		data["questionsNum"] = numOfQuestionsInGame;

		return data;
	}
};

class Room
{
private:
	RoomData m_metaData;
	vector<LoggedUser> m_users;

public:
	Room(); // Irrelevant
	Room(RoomData data, LoggedUser maker);

	RoomData getData();
	vector<string> getAllUsers();

	void addUser(LoggedUser user);
	void removeUser(LoggedUser user);
};

