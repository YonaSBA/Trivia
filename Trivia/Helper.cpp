#include "Helper.h"

bool Helper::isValid(string name)
{
	for (int i = 0; i < name.size(); i++)
	{
		if (!isalpha(name[i]) && !isdigit(name[i]))
		{
			return false;
		}
	}

	return true;
}