#include "LoginRequestHandler.h"

LoginRequestHandler::LoginRequestHandler(RequestHandlerFactory& handlerFactory) :
	m_handlerFactory(handlerFactory), m_loginManager(handlerFactory.getLoginManager()) {}

bool LoginRequestHandler::isRequestRelevant(RequestInfo info)
{
	return info.id == SIGN_IN || info.id == SIGN_UP;
}

RequestResult LoginRequestHandler::handleRequest(RequestInfo info)
{
	RequestResult res;

	if (isRequestRelevant(info))
	{
		if (info.id == SIGN_IN)
		{
			return login(info);
		}
		else
		{
			return signup(info);
		}
	}
	else
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ "Wrong request." });
		res.newHandler = nullptr;
	}

	return res;
}

RequestResult LoginRequestHandler::login(RequestInfo info)
{
	RequestResult res;
	LoginRequest req = JsonRequestPacketDeserializer::deserializeLoginRequest(info.buffer);

	try
	{
		m_loginManager.login(req.username, req.password);
		res.response = JsonResponsePacketSerializer::serializeResponse(LoginResponse{ SIGN_IN });
		res.newHandler = m_handlerFactory.createMenuRequestHandler(LoggedUser(req.username));
	}
	catch(const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
		res.newHandler = m_handlerFactory.createLoginRequestHandler();
	}

	return res;
}

RequestResult LoginRequestHandler::signup(RequestInfo info)
{
	RequestResult res;
	SignupRequest req = JsonRequestPacketDeserializer::deserializeSignupRequest(info.buffer);

	try
	{
		m_loginManager.signup(req.username, req.password, req.email);
		res.response = JsonResponsePacketSerializer::serializeResponse(SignupResponse{ SIGN_UP });
	}
	catch (const exception& err)
	{
		res.response = JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ string(err.what()) });
	}

	res.newHandler = m_handlerFactory.createLoginRequestHandler();

	return res;
}
