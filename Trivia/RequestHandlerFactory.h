#pragma once

#include "IDatabase.h"
#include "RoomManager.h"
#include "LoginManager.h"
#include "StatisticsManager.h"
#include "MenuRequestHandler.h"
#include "LoginRequestHandler.h"

class MenuRequestHandler;
class LoginRequestHandler;

class RequestHandlerFactory
{
private:
	IDatabase* m_database;
	RoomManager m_roomManager;
	LoginManager m_loginManager;
	StatisticsManager m_statisticsManager;

public:
	RequestHandlerFactory(IDatabase* dataBase);

	RoomManager& getRoomManager();
	LoginManager& getLoginManager();
	StatisticsManager& getStatisticsManager(); 

	LoginRequestHandler* createLoginRequestHandler();
	MenuRequestHandler* createMenuRequestHandler(LoggedUser user);
};

