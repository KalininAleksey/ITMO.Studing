#include <iostream>
#include <fstream>
#include <nlohmann/json.hpp>
using namespace std;
using json = nlohmann::json;
int main() {
	//const int N = 10;
	//int a[N] = { 1, 25, 6, 32, 43, 5, 96, 23, 4, 55 };
	int min = 0;
	int buf = 0;
	/*json j;
	j = a;
	ofstream joutput("mas.json");
	joutput << setw(4) << j << endl;*/
	ifstream jinput("mas.json");
	json j;
	jinput >> j;
	int N = j.size();
	int *a = new int[N];
	int i = 0;
	for (auto &element : j) {
		a[i]=element;
		i++;
	}
	jinput.close();
	for (int i = 0; i < N; i++)
	{
		min = i;
		for (int j = i + 1; j < N; j++)
			min = (a[j] < a[min]) ? j : min;
		if (i != min)
		{
			buf = a[i];
			a[i] = a[min];
			a[min] = buf;
		}
	}
	json jout;
	for (int i = 0; i < N; i++) {
		cout << a[i] << '\t';
		jout[i] = a[i];
	}
	ofstream joutput("mas_sort.json");
	joutput << std::setw(4) << jout << endl;
	delete[] a;
	return 0;
}