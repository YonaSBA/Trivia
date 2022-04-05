#include "MenuRequestHandler.h"

MenuRequestHandler::MenuRequestHandler(RequestHandlerFactory& handlerFactory, LoggedUser user) :
	m_handlerFactory(handlerFactory), m_roomManager(handlerFactory.getRoomManager()),
	m_statisticsManager(handlerFactory.getStatisticsManager()), m_user(user) {}

bool MenuRequestHandler::isRequestRelevant(RequestInfo info)
{
	return info.id == SIGN_OUT   || info.id == GET_ROOMS   ||
		   info.id == JOIN_ROOM  || info.id == HIGH_SCORES ||
		   info.id == STATISTICS || info.id == GET_PLAYERS ||
		   info.id == CREATE_ROOM;
}

RequestResult MenuRequestHandler::handleRequest(RequestInfo info)
{
	RequestResult res;

	if (isRequestRelevant(info))
	{
		switch (info.id)
		{
			case SIGN_OUT:
				return logout(info);
				break;
			case GET_ROOMS:
				return getRooms(info);
				break;
			case JOIN_ROOM:
				return joinRoom(info);
				break;
			case CREATE_ROOM:
				return createRoom(info);
				break;
			case HIGH_SCORES:
				return getHighScore(info);
				break;
			case STATISTICS:
				return getStatsistics(info);
				break;
			case GET_PLAYERS:
				return getPlayersInRoom(info);
				break;
		}
	}
	else
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ "Wrong request." });
		res.newHandler = nullptr;
	}

	return res;
}

RequestResult MenuRequestHandler::logout(RequestInfo info)
{
	RequestResult res;

	try
	{
		m_handlerFactory.getLoginManager().logout(m_user.getUsername());
		res.response = JsonResponsePacketSerializer::serializeResponse(LogoutResponse{ SIGN_OUT });
		res.newHandler = m_handlerFactory.createLoginRequestHandler();
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
		res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);
	}

	return res;
}

RequestResult MenuRequestHandler::getRooms(RequestInfo info)
{
	RequestResult res;

	try
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(GetRoomsResponse{ GET_ROOMS, m_roomManager.getRooms()});
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
	}

	res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);

	return res;
}

RequestResult MenuRequestHandler::joinRoom(RequestInfo info)
{
	RequestResult res;
	JoinRoomRequest req = JsonRequestPacketDeserializer::deserializeJoinRoomRequest(info.buffer);

	try
	{
		m_roomManager.joinRoom(m_user, req.roomId);
		res.response = JsonResponsePacketSerializer::serializeResponse(JoinRoomResponse{ JOIN_ROOM });
		res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);; // RoomMemberRequestHandler
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
		res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);
	}

	return res;
}

RequestResult MenuRequestHandler::createRoom(RequestInfo info)
{
	RequestResult res;
	CreateRoomRequest req = JsonRequestPacketDeserializer::deserializeCreateRoomRequest(info.buffer);

	try
	{
		m_roomManager.createRoom(m_user, RoomData{ req.roomName, ++RoomData::counter, true, req.maxUsers, req.answerTimeout, req.questionCount });//try make a new room
		res.response = JsonResponsePacketSerializer::serializeResponse(CreateRoomResponse{ CREATE_ROOM });
		res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);; // RoomAdminRequestHandler
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
		res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);
	}

	return res;
}

RequestResult MenuRequestHandler::getHighScore(RequestInfo info)
{
	RequestResult res;

	try
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(GetHighScoreResponse{ HIGH_SCORES, m_statisticsManager.getHighScore()});
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
	}

	res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);

	return res;
}

RequestResult MenuRequestHandler::getStatsistics(RequestInfo info)
{
	RequestResult res;

	try
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(GetStatisticsResponse{ STATISTICS, m_statisticsManager.getUserStatistics(m_user.getUsername()) });
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
	}

	res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);

	return res;
}

RequestResult MenuRequestHandler::getPlayersInRoom(RequestInfo info)
{
	RequestResult res;
	GetPlayersInRoomRequest req = JsonRequestPacketDeserializer::deserializeGetPlayersRequest(info.buffer);

	try
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(GetPlayersInRoomResponse { GET_PLAYERS, m_roomManager.getPlayersInRoom(req.roomId)});
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
	}

	res.newHandler = m_handlerFactory.createMenuRequestHandler(m_user);

	return res;
}
