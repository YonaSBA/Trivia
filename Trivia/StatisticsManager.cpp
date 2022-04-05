#include "StatisticsManager.h"

StatisticsManager::StatisticsManager(IDatabase* dataBase) :
    m_database(dataBase) {}

vector<Player> StatisticsManager::getHighScore()
{
    vector<Player> highScores;
    vector<string> names = m_database->getUsersNames();

    for (int i = 0; i < names.size(); i++)
    {
        highScores.push_back(Player{ m_database->getPlayerBestScore(names[i]), names[i] });
    }

    bubbleSort(highScores);

    return vector<Player>(highScores.begin(), highScores.begin() + 5);
}

Statistics StatisticsManager::getUserStatistics(string username)
{
    int corrects = m_database->getNumOfCorrectAnswers(username);

    return Statistics{ m_database->getPlayerBestScore(username),
                       m_database->getNumOfPlayerGames(username), corrects,
                       m_database->getPlayerAverageAnswerTime(username),
                       m_database->getNumOfTotalAnswers(username) - corrects };
}

void StatisticsManager::bubbleSort(vector<Player>& vec)
{
    for (int i = 0; i < vec.size(); i++)
    {
        for (int j = 0; j < vec.size() - 1; j++)
        {
            if (vec[j].best < vec[j + 1].best)
            {
                swap(vec[j], vec[j + 1]);
            }
        }
    }
}
