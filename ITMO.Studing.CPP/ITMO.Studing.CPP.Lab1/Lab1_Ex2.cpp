#include <iostream>
#include <windows.h>
using namespace std;
int main2() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	double a, b;
	string name;
	cout << "������� a � b:\n";
	cin >> a;
	cin >> name;
	cin >> b;
	double x = a / b;
	cout.precision(3);
	cout << "\nx=" << x << endl;
	cout << sizeof(a / b) << ends << sizeof(x) << endl;
	cout << "������, " << name <<"!"<< endl;
	return 0;
}
