#pragma once

#include "IRequestHandler.h"
#include "RequestHandlerFactory.h"

class RequestHandlerFactory;

class LoginRequestHandler : public IRequestHandler
{
public:
	LoginRequestHandler(RequestHandlerFactory& handlerFactory);

	bool isRequestRelevant(RequestInfo info);
	RequestResult handleRequest(RequestInfo info);

private:
	LoginManager& m_loginManager;
	RequestHandlerFactory& m_handlerFactory;

private:
	RequestResult login(RequestInfo info);
	RequestResult signup(RequestInfo info);
};