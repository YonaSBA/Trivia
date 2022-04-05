#pragma once

#include "Helper.h"
#include "JsonResponsePacketSerializer.h"
#include "JsonRequestPacketDeserializer.h"

class IRequestHandler;

struct RequestInfo
{
	codes id;
	time_t receivalTime;
	vector<byte> buffer;

	RequestInfo(const char message[])
	{
		int i = 0;
		
		do {
			buffer.push_back(message[i++]);								// Massage content.
		} while (message[i - 1] != '}');

		id = (codes)buffer[0];											// Massage code.
		receivalTime = system_clock::to_time_t(system_clock::now());	// Massage time.
	}
};

struct RequestResult
{
	vector<byte> response;
	IRequestHandler* newHandler;

	operator string() const
	{
		string str;

		for (int i = 0; i < response.size(); i++)
		{
			str += response[i];
		}

		return str;
	}
};

class IRequestHandler
{
public:
	virtual bool isRequestRelevant(RequestInfo info) = 0;
	virtual RequestResult handleRequest(RequestInfo info) = 0;
};