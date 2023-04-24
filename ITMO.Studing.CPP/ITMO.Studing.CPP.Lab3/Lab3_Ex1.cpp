#include <iostream>
#include <string>
using namespace std;
string privet1(string name)
{
	string str = name + ", " + "hello!\n";
	return str;
}
int main1()
{
	string name;
	cout << "What is your name?" << endl;
	cin >> name;
	string nameOut = privet1(name);
	cout << nameOut << endl;
	return 0;
}