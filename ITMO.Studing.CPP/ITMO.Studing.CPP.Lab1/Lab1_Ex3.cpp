#include <iostream>
#include <windows.h>
#include <cmath>
using namespace std;
int main3() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	double a,b,c,p,S;
	string name;
	cout << "������� ����� ������ ������������:\n";
	cin >> a;
	cin >> b;
	cin >> c;
	p = (a+b+c)/2;
	S = sqrt(p*(p-a)*(p-b)*(p-c));
	cout.precision(3);
	cout << "�������    "<< "  ��������" << endl;
	cout << a << ends << b << ends << c << ends<< "        " << S<< endl;
	return 0;
}
