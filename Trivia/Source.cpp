#include "Server.h"
#include "WSAInitializer.h"

int main()
{
	Server server;
	WSAInitializer wsaInit;		// Necessary for socket.
	
	try
	{
		server.run();
	}
	catch (const exception &err)
	{
		cerr << "ERROR: " << err.what() << "." << endl;
	}

	return 0;
}