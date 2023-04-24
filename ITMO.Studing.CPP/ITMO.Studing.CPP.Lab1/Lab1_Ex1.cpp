#include <iostream> 
#include <string> 
using namespace std;
int main1(){
	string name;
	cout << "What is name? ";
	getline(cin, name);
	cout << "Hello, " << name << "!\n";
	return 0;
}