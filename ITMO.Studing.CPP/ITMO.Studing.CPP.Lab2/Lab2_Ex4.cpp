#include <iostream>
using namespace std;
int main4() {
	int s, k, m;
	s = 0;
	cout << "Input range boarders:\n" << endl;
	cin >> k;
	cin >> m;
	for (int i = 1; i <= 100; i++)
	{
		if ((i > k) && (i < m)) continue;
		s += i;
	}
	cout <<"summ = " << s << endl;
	return 0;
}