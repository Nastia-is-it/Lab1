#include <iostream> 
#include <ctime>
#include <cstdlib>
#include <string>
using namespace std;
//int main()
//{
//	setlocale(LC_ALL, "ru");
//	srand(static_cast<unsigned int>(time(0)));
//	int sn, num;
//	sn = rand() % 100 + 1;
//	cout << "Угадай число " << endl;
//	do {
//		cin >> num;
//		if (num > sn)
//		{
//			cout << "Больше загаданного";
//		}
//		else if (num < sn)
//		{
//			cout << "Меньше загаданного";
//		}
//		else
//		{
//			cout << "Угадал";
//		}
//	} while (num != sn);
//	return 0;
//}


int main()
{
	cout << 50 % 90;
	/*setlocale(LC_ALL, "ru");
	srand(static_cast<unsigned int>(time(0)));
	enum fields { word, hint, num_fields };
	const int num_words = 5;
	const string words[num_words][num_fields] =
	{
		{"Сверхъестественное", "Братья и загадки"},
		{"Оченьстранныедела", "Огромная паукообразная тень"},
		{"Готем", "Тёмный супергерой"},
		{"Уэйн", "Подростки, сваливают, любовь"},
		{"Энн", "Сильная рыжая девушка"}
	};
	int ch = (rand() % num_words);
	string tw = words[ch][word];
	string th = words[ch][hint];
	string cur = tw;
	char temp;
	for (int i = 0; i < cur.size(); i++) {
		int i1 = (rand() % cur.size());
		int i2 = (rand() % cur.size());
		temp = cur[i1];
		cur[i1] = cur[i2];
		cur[i2] = temp;
	}
	string q;
	cout << "Угадай слово" << endl;
	for (int i = 0; i < cur.size(); i++)
	{
		cout << cur[i];
	}
	cout << endl;
	
	do
	{
		if (q == "hint")
		{
			cout << th << endl;
		}
		cout << "Ваш ответ: ";
		cin >> q;
	}
	while ((q != "quit") && (q != tw));

	if (q == tw)
	{
		cout << "Вы угадали слово!";
	}*/
}