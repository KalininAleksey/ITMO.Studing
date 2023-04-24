#include <iostream>

using namespace std;

void decToBin(int n)
{
	if (n/2!=0)
		decToBin(n/2);
	cout << n % 2;

}

int main()
{
	int n;
	cout << "Lets convert number from decimal to binary. Enter parameter the number:" << endl;
	cin >> n;
	if (n >= 0) {
		cout << "The result is " << endl;
		decToBin(n);
	}
	else {
		cout << "You entered incorrect number." << endl;
	}
	return 0;
}