#include <iostream>
#include <math.h>
using namespace std;
int main2()
{
	//Task 2
	double x, x1, x2, y;
	cout << "x1 = "; cin >> x1;
	cout << "x2 = "; cin >> x2;
	cout << "\tx\tsin(x)\n";
	x = x1;
	while (x <= x2)
	{
		y = sin(x);
		cout << "\t" << x << "\t" << y << endl;
		x = x + 0.01;
	}
	//Task 3
	int a, b, temp;
	cout << "a = "; cin >> a;
	cout << "b = "; cin >> b;
	do
	{
		if (a > b)
			a -= b; // ���������� ��������� a = a - b
		else
			b -= a;
	} while (a != b);
	cout << "��� = " << a << endl;
	return 0;
}