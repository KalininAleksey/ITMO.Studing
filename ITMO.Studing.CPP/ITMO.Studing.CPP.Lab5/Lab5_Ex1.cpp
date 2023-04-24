#include <iostream>
using namespace std;
int main1() {
	const int n = 10;
	int mas[n];
	for (int i = 0; i < n; i++)
	{
		cout << "mas[" << i << "]=";
		cin >> mas[i];
	}
	int s = 0;
	for (int i = 0; i < n; i++)
	{
		s += mas[i];
	}
	cout << "s= " << s << endl;
	float avg = s / n;
	cout.precision(5);
	cout << "avarage value= " << avg << endl;
	return 0;
}