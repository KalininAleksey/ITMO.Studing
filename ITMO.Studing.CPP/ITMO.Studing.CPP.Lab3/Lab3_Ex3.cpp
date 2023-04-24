#include <iostream>

using namespace std;

long double firBinSearch(double a, int n)
{
	double L = 0;
	double R = a;
	while (R - L > 1e-10)
	{
		double M = (L + R) / 2;
		if (pow(M, n) < a)
		{
			L = M;
		}
		else
		{
			R = M;
		}
	}
	return R;
}

int main3()
{
	int power;
	double number;
	cout << "Enter the number to calclate the root" << endl;
	cin >> number;
	cout << "Enter the root power" << endl;
	cin >> power;
	cout << "The root calculate result is "<< firBinSearch(number,power) << endl;
	return 0;
}