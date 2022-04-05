#include "Communicator.h"

Communicator::Communicator(RequestHandlerFactory& handlerFactory) :
	m_handlerFactory(handlerFactory), m_clients(), m_serverSocket() {}

void Communicator::startHandleRequests()
{
	m_serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	if (m_serverSocket == INVALID_SOCKET)
		throw exception(__FUNCTION__ " - socket");

	bindAndListen();
}

void Communicator::bindAndListen()
{
	thread user;
	struct sockaddr_in sa = { 0 };

	sa.sin_port = htons(PORT);
	sa.sin_family = AF_INET;
	sa.sin_addr.s_addr = INADDR_ANY;

	if (bind(m_serverSocket, (struct sockaddr*)&sa, sizeof(sa)) == SOCKET_ERROR)
		throw exception(__FUNCTION__ " - bind");

	if (listen(m_serverSocket, SOMAXCONN) == SOCKET_ERROR)
		throw exception(__FUNCTION__ " - listen");

	while (true)													// Opening conversations.
	{
		SOCKET conversationSocket = ::accept(m_serverSocket, NULL, NULL);

		if (conversationSocket == INVALID_SOCKET)
			throw exception(__FUNCTION__ " - accept");

		m_clients.insert(pair<SOCKET, IRequestHandler*>(conversationSocket, m_handlerFactory.createLoginRequestHandler()));

		user = thread(&Communicator::handleNewClient, this, conversationSocket);
		user.detach();
	}
}

void Communicator::handleNewClient(SOCKET conversationSocket)
{
	char buffer[1024] = { 0 };

	while (true)
	{
		if (recv(conversationSocket, buffer, 1023, 0) == INVALID_SOCKET)
		{
			throw exception(__FUNCTION__ " - recv");
		}	  
		else if (buffer[0])		// Check if the buffer is full.
		{
			RequestResult res = m_clients[conversationSocket]->handleRequest(buffer);

			if (send(conversationSocket, string(res).c_str(), (int)res.response.size(), 0) == INVALID_SOCKET)
			{
				throw exception(__FUNCTION__ " - send");
			}

			m_clients[conversationSocket] = res.newHandler;
		}

		memset(buffer, 0, sizeof(buffer));
	}
}