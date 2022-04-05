#include "JsonRequestPacketDeserializer.h"

LoginRequest JsonRequestPacketDeserializer::deserializeLoginRequest(vector<byte> buffer)
{
	LoginRequest req;
	json j = json::parse(vector<byte>(buffer.begin() + 5, buffer.end()));	// Convert the part in the buffer bounded by "{}" to Json.

	req.username = j["username"];
	req.password = j["password"];

	return req;
}

SignupRequest JsonRequestPacketDeserializer::deserializeSignupRequest(vector<byte> buffer)
{
	SignupRequest req;
	json j = json::parse(vector<byte>(buffer.begin() + 5, buffer.end()));

	req.username = j["username"];
	req.password = j["password"];
	req.email = j["email"];

	return req;
}

JoinRoomRequest JsonRequestPacketDeserializer::deserializeJoinRoomRequest(vector<byte> buffer)
{
	JoinRoomRequest req;
	json j = json::parse(vector<byte>(buffer.begin() + 5, buffer.end()));

	req.roomId = j["ID"].get<unsigned int>();

	return req;
}

CreateRoomRequest JsonRequestPacketDeserializer::deserializeCreateRoomRequest(vector<byte> buffer)
{
	CreateRoomRequest req;
	json j = json::parse(vector<byte>(buffer.begin() + 5, buffer.end()));

	req.roomName = j["name"];
	req.maxUsers = j["maxPlayers"].get<unsigned int>();
	req.answerTimeout = j["answerTime"].get<unsigned int>();
	req.questionCount = j["questionNum"].get<unsigned int>();

	return req;
}

GetPlayersInRoomRequest JsonRequestPacketDeserializer::deserializeGetPlayersRequest(vector<byte> buffer)
{
	GetPlayersInRoomRequest req;
	json j = json::parse(vector<byte>(buffer.begin() + 5, buffer.end()));

	req.roomId = j["ID"].get<unsigned int>();

	return req;
}