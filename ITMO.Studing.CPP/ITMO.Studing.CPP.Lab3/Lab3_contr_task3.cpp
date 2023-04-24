#include <iostream>

using namespace std;

long double triangleSquare(double a)
{
	if (a < 0) {
		return -1;
	}
	else {
		return sqrt(3) * a * a/ 4;
	}
}
long double triangleSquare(double a, double b)
{
	if ((a < 0) || (b < 0)) {
		return -1;
} 
	else {

		return sqrt(4 * a * a - b * b) * b / 4;
	}
}

int main()
{
	int triangleType;
	double a,b,square;
	cout << "Enter the the triangle type(1-equilateral triangle/2-isosceles triangle) " << endl;
	cin >> triangleType;
	if (triangleType == 1) {
		cout << "Enter the the triangle side size" << endl;
		cin >> a;
		square = triangleSquare(a);
	}
	else if(triangleType == 2) {
		cout << "Enter the the triangle side size that is one of the equal triangle sides" << endl;
		cin >> a;
		cout << "Enter the the unique triangle side size" << endl;
		cin >> b;
		square = triangleSquare(a,b);
	}
	else {
		cout << "You entered incorrect triangle type" << endl;
		return 0;
	}
	if (square == -1) {
		cout << "You entered incorrect triangle side size(s)" << endl;
	}
	else {
		cout << "The triangle square value is " << square << endl;
	}
	return 0;
}