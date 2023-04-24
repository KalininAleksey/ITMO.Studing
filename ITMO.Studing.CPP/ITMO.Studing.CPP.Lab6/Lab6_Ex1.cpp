#include <iostream>
#include <fstream>
using namespace std;
int main1() {
	double sum = 0;
	int const n = 100;
	double nums[n];
	for (int i = 0; i < n; i++)
	{
		nums[i] = (rand() % 100);
		//cout << nums[i]<<endl;
	}
	ofstream ou("test", ios::out | ios::binary);
	if (!ou) {
		cout << "Файл открыть невозможно\n";
		return 1;
	}
	ou.write((char*) nums, sizeof(nums));
	ou.close();
	ifstream inp("test", ios::in | ios::binary);
	if (!inp) {
		cout << "Файл открыть невозможно";
		return 1;
	}
	inp.read((char*)&nums, sizeof(nums));
	int k = sizeof(nums) / sizeof(double);
	for (int i = 0; i < k; i++)
	{
		sum = sum + nums[i];
		cout << nums[i] << ' ';
	}
	cout << "\nsum = " << sum << endl;
	inp.close();
	return 0;
}