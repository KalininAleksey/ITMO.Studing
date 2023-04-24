#include <iostream>
using namespace std;
int addNumders(int n) //Task1
{
	if (n == 1) return 1; // выход из рекурсии
	else return (n + addNumders(n - 1));
}
int gcd(int m, int n) //Task2
{
	if (n == 0) return m;
	return gcd(n, m % n);
}
int main4() {
	int a,b,num;
	cout << "Input number to calculate summ:\n";
	cin >> num;
	cout << "summ = " << addNumders(num) << endl;
	cout << "Let's calculate the greatest common divisor(GCD):\n";
	cout << "a = "; 
	cin >> a;
	cout << "b = "; 
	cin >> b;
	cout << "GCD = " << gcd(a,b) << endl;
	return 0;
}