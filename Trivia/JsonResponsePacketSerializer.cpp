#include "JsonResponsePacketSerializer.h"

vector<byte> JsonResponsePacketSerializer::serializeResponse(codes code, json data)
{
    string dump = data.json::dump();                // Convert json to string.
    string size = to_string(dump.size());           // Get string of json size.
    vector<byte> buffer(5 - size.size(), '\0');     // Constructs a blank vector according to the size of the message.

    buffer[0] = code;
    buffer.insert(buffer.end(), size.begin(), size.end());
    buffer.insert(buffer.end(), dump.begin(), dump.end());

    return buffer;
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(ErrorResponse res)
{
    json data;

    data["message"] = res.message;

    return serializeResponse(ERR, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(LoginResponse res)
{
    json data;

    data["status"] = res.status;

    return serializeResponse(SIGN_IN, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(SignupResponse res)
{
    json data;

    data["status"] = res.status;

    return serializeResponse(SIGN_UP, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(LogoutResponse res)
{
    json data;

    data["status"] = res.status;

    return serializeResponse(SIGN_OUT, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(GetRoomsResponse res)
{
    json data;

    data["status"] = res.status;

    for (int i = 0; i < res.rooms.size(); i++)
    {
        data["rooms"] += json(res.rooms[i]);
    }

    return serializeResponse(GET_ROOMS, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(JoinRoomResponse res)
{
    json data;

    data["status"] = res.status;

    return serializeResponse(JOIN_ROOM, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(CreateRoomResponse res)
{
    json data;

    data["status"] = res.status;

    return serializeResponse(CREATE_ROOM, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(GetHighScoreResponse res)
{
    json data;

    data["status"] = res.status;

    for (int i = 0; i < res.highScores.size(); i++)
    {
        data["high_score"] += json(res.highScores[i]);
    }

    return serializeResponse(HIGH_SCORES, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(GetStatisticsResponse res)
{
    json data;

    data["status"] = res.status;
    data["statistic"] = json(res.statistics);

    return serializeResponse(STATISTICS, data);
}

vector<byte> JsonResponsePacketSerializer::serializeResponse(GetPlayersInRoomResponse res)
{
    json data;

    data["status"] = res.status;
    data["players"] = res.players;

    return serializeResponse(GET_PLAYERS, data);
}