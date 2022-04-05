#pragma once

#include "IRequestHandler.h"
#include "RequestHandlerFactory.h"

class RequestHandlerFactory;

class MenuRequestHandler : public IRequestHandler
{
private:
	LoggedUser m_user;
	RoomManager& m_roomManager;
	StatisticsManager& m_statisticsManager;
	RequestHandlerFactory& m_handlerFactory;

private:
	RequestResult logout(RequestInfo info);
	RequestResult getRooms(RequestInfo info);
	RequestResult joinRoom(RequestInfo info);
	RequestResult createRoom(RequestInfo info);
	RequestResult getHighScore(RequestInfo info);
	RequestResult getStatsistics(RequestInfo info);
	RequestResult getPlayersInRoom(RequestInfo info);

public:
	MenuRequestHandler(RequestHandlerFactory& handlerFactory, LoggedUser user);

	bool isRequestRelevant(RequestInfo info);
	RequestResult handleRequest(RequestInfo info);
};

