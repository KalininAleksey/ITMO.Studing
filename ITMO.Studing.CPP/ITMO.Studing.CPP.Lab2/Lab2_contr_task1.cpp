#include <iostream>
using namespace std;
int main() {
	int n, k, m, counter;
		k = 1;
		m = 1;
		counter = 1;
		cout << "Input the number to check on super-prime number:\n" << endl;
		cin >> n;
		for (int i = 2; i < n; i++) {
			if (n % i == 0) { 
				break;
			}
			k = i;
		}
		if (k == (n - 1)) {
			for (int i = 2; i < n; i++) {
				for (int j = 2; j < i; j++) {
					if (i % j == 0) {
						break;
					}
					m = j;
				}
				if (m == (i - 1)) counter++;
			}
			m = 1;
			for (int i = 2; i < counter; i++) {
				if (counter % i == 0) {
					break;
				}
				m = i;
			}
			if (m == (counter - 1)) {
				cout << " Number is super-prime number!"<< "\n" << endl;
			}
			else {
				cout << " Number is not super-prime number, but it is prime number\n" << endl;
			}
		}
		else {
			cout << " Number is not super-prime number\n" << endl;
		}
	return 0;
}