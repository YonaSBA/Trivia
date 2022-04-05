#pragma once
#include "sqliteDatabase.h"

struct Statistics
{
	float best;
	int games;
	int corrects;
	float average;
	int wrongs;

	operator json() const
	{
		json data;

		data["best"] = best;
		data["games"] = games;
		data["wrongs"] = wrongs;
		data["average"] = average;
		data["corrects"] = corrects;

		return data;
	}
};

struct Player
{
	float best;
	string name;

	operator json() const
	{
		json data;

		data["name"] = name;
		data["best"] = best;

		return data;
	}
};

class StatisticsManager
{
private:
	IDatabase* m_database;

public:
	StatisticsManager(IDatabase* dataBase);

	vector<Player> getHighScore();
	Statistics getUserStatistics(string username);

private:
	void bubbleSort(vector<Player>& vec);
};