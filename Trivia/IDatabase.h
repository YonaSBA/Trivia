#pragma once

#include "Helper.h"

struct Question
{
	int correct;
	string first;
	string second;
	string third;
	string fourth;
	string question;
};

class IDatabase
{
public:

	virtual bool doesUserExist(string name) = 0;
	virtual bool doesPasswordMatch(string name, string password) = 0;
	virtual void addNewUser(string name, string password, string email) = 0;

	virtual int getNumOfPlayerGames(string name) = 0;
	virtual float getPlayerBestScore(string name) = 0;
	virtual int getNumOfTotalAnswers(string name) = 0;
	virtual int getNumOfCorrectAnswers(string name) = 0;
	virtual float getPlayerAverageAnswerTime(string name) = 0;

	virtual vector<string> getUsersNames() = 0;
	virtual list<Question> getQuestions(int question) = 0;
};