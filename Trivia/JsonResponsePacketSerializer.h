#pragma once

#include "Room.h"
#include "StatisticsManager.h"

typedef unsigned char byte;

struct LoginResponse
{
	unsigned int status;
};

struct SignupResponse
{
	unsigned int status;
};

struct LogoutResponse
{
	unsigned int status;
};

struct JoinRoomResponse
{
	unsigned int status;
};

struct CreateRoomResponse
{
	unsigned int status;
};

struct GetRoomsResponse
{
	unsigned int status;
	vector<RoomData> rooms;
};

struct GetHighScoreResponse
{
	unsigned int status;
	vector<Player> highScores;
};

struct GetStatisticsResponse
{
	unsigned int status;
	Statistics statistics;
};

struct GetPlayersInRoomResponse
{
	unsigned int status;
	vector<string> players;
};

struct ErrorResponse
{
	string message;
};

class JsonResponsePacketSerializer
{
public:
	// All of the functions are enter the information to message structure as the appropriate action.
	static vector<byte> serializeResponse(ErrorResponse res);
	static vector<byte> serializeResponse(LoginResponse res);
	static vector<byte> serializeResponse(SignupResponse res);
	static vector<byte> serializeResponse(LogoutResponse res);
	static vector<byte> serializeResponse(GetRoomsResponse res);
	static vector<byte> serializeResponse(JoinRoomResponse res);
	static vector<byte> serializeResponse(codes code, json data);
	static vector<byte> serializeResponse(CreateRoomResponse res);
	static vector<byte> serializeResponse(GetHighScoreResponse res);
	static vector<byte> serializeResponse(GetStatisticsResponse res);
	static vector<byte> serializeResponse(GetPlayersInRoomResponse res);
};