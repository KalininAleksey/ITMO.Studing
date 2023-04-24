/*#include <iostream>
#include <windows.h>
using namespace std;
struct Distance
{
	int feet;
	double inches;
	void ShowDist()
	{
		cout << feet << "\'-" << inches << "\"\n";
	}
};
Distance InputDist()
{
	Distance d;
	cout << "\n¬ведите число футов: ";
	cin >> d.feet;
	cout << "¬ведите число дюймов: ";
	cin >> d.inches;
	return d;
}
Distance AddDist(const Distance& d1, const Distance& d2)
{
	Distance d;
	d.feet = d1.feet + d2.feet;
	d.inches = d1.inches + d2.inches;
	if (d.inches >= 12.0)
	{
		d.inches -= 12.0;
		d.feet++;
	}
	return d;
}
void ShowDist(Distance d)
{
	cout << d.feet << "\'-" << d.inches << "\"\n";
}
int main3() {
	SetConsoleOutputCP(1251);
	int n;
	cout << "¬ведите размер массива рассто€ний ";
	cin >> n;
	Distance* masDist = new Distance[n];
	for (int i = 0; i < n; i++)
	{
		masDist[i] = InputDist();
	}
	Distance sumDist;
	for (int i = 0; i < n; i++)
	{
		ShowDist(masDist[i]);
		if (i == 0) 
			sumDist = masDist[0];
		else
			sumDist = AddDist(sumDist, masDist[i]);

	}
	sumDist.ShowDist();
	delete[] masDist;
	return 0;
}*/