#include <iostream>
#include <windows.h>
using namespace std;
int main() {
	SetConsoleOutputCP(1251);
	//SetConsoleCP(1251);
	double x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;
	cout << "������� ���������� ������ ������������� ��� ������� ��� �������.\n"<< "������� ���������� X � Y 1-�� �������:\n";
	cin >> x1;
	cin >> y1;
	cout << "������� ���������� X � Y 2 - �� ������� : \n";
	cin >> x2;
	cin >> y2;
	cout << "������� ���������� X � Y 3 - �� ������� : \n";
	cin >> x3;
	cin >> y3;
	cout << "������� ���������� X � Y 4 - �� ������� : \n";
	cin >> x4;
	cin >> y4;
	cout << "������� ���������� X � Y 5 - �� ������� : \n";
	cin >> x5;
	cin >> y5;
	double S = abs(x1 * y2 + x2 * y3 + x3 * y4 + x4 * y5 + x5 * y1 - x2 * y1 - x3 * y2 - x4 * y3 - x5 * y4 - x1 * y5)/2;
	cout << "������� ������������� ����� " << S << endl;
	return 0;
}
