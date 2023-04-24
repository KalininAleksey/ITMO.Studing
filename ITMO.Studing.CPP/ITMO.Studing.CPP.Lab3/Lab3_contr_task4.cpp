#include <iostream>

using namespace std;

int summ(int n)
{
	int s=0;
	if (n == 1)
		return 5;
	else
		return 5*n+summ(n-1);

}

int main()
{
	int n;
	cout << "Lets calculate the row summ, that is equal to S=5+10+15+...+5*n. Enter parameter n (n>0). " << endl;
	cin >> n;
	if (n > 0) { 
		cout << "The result is " << summ(n) << endl;
	}
	else {
		cout << "You entered incorrect parameter n." << endl;
	}


	return 0;
}