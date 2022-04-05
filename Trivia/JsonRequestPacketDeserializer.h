#pragma once

#include "IRequestHandler.h"

struct LoginRequest
{
	string username;
	string password;
};

struct SignupRequest
{
	string username;
	string password;
	string email;
};

struct JoinRoomRequest
{
	unsigned int roomId;
};

struct GetPlayersInRoomRequest
{
	unsigned int roomId;
};

struct CreateRoomRequest
{
	string roomName;
	unsigned int maxUsers;
	unsigned int questionCount;
	unsigned int answerTimeout;
};

class JsonRequestPacketDeserializer
{
public:
	// All of the functions are pulling out the information from the users messages depending of the messages type:
	static LoginRequest deserializeLoginRequest(vector<byte> buffer);
	static SignupRequest deserializeSignupRequest(vector<byte> buffer);
	static JoinRoomRequest deserializeJoinRoomRequest(vector<byte> buffer);
	static CreateRoomRequest deserializeCreateRoomRequest(vector<byte> buffer);
	static GetPlayersInRoomRequest deserializeGetPlayersRequest(vector<byte> buffer);
};

