#pragma once
#pragma comment (lib, "ws2_32.lib")

#include "Helper.h"
#include "LoginRequestHandler.h"

#define PORT 1234

class Communicator
{
public:
	Communicator(RequestHandlerFactory& handlerFactory);

	void startHandleRequests();

private:
	void bindAndListen();
	void handleNewClient(SOCKET convesationSocket);

private:
	SOCKET m_serverSocket;
	map<SOCKET, IRequestHandler*> m_clients;
	RequestHandlerFactory& m_handlerFactory;
};

