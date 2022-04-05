#pragma once

#include <map>
#include <list>
#include <io.h>
#include <ctime>
#include <vector>
#include <chrono>
#include <thread>
#include <iomanip>
#include <cstdarg>
#include <iostream>
#include "Json.hpp"
#include "sqlite3.h"
#include <algorithm>
#include <exception>
#include <WinSock2.h>
#include <Windows.h>

using std::map;
using std::pair;
using std::cout;
using std::cerr;
using std::endl;
using std::list;
using std::prev;
using std::swap;
using std::ctime;
using std::thread;
using std::vector;
using std::string;
using std::replace;
using std::isdigit;
using std::isalpha;
using std::to_string;
using nlohmann::json;
using std::exception;
using std::out_of_range;
using std::chrono::system_clock;

enum codes
{
	ERR = '0',

	SIGN_IN,
	SIGN_UP,
	SIGN_OUT,

	CREATE_ROOM,
	JOIN_ROOM,

	STATISTICS,
	HIGH_SCORES,

	GET_ROOMS,
	GET_PLAYERS
};

class Helper
{
public:

	static bool isValid(string name);
};