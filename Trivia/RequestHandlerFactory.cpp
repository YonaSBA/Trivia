#include "RequestHandlerFactory.h"

RequestHandlerFactory::RequestHandlerFactory(IDatabase* dataBase) :
	m_database(dataBase), m_loginManager(LoginManager(m_database)), m_statisticsManager(StatisticsManager(m_database)) {}

MenuRequestHandler* RequestHandlerFactory::createMenuRequestHandler(LoggedUser user)
{
	return new MenuRequestHandler(*this, user);
}

LoginRequestHandler* RequestHandlerFactory::createLoginRequestHandler()
{
	return new LoginRequestHandler(*this);
}

RoomManager& RequestHandlerFactory::getRoomManager()
{
	return m_roomManager;
}

LoginManager& RequestHandlerFactory::getLoginManager()
{
	return m_loginManager;
}

StatisticsManager& RequestHandlerFactory::getStatisticsManager()
{
	return m_statisticsManager;
}
