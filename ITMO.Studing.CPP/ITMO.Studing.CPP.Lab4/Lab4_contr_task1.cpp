#include <iostream>
using namespace std;

int Myroot(double, double, double, double&, double&);

int Myroot(double a, double b, double c, double& x1, double& x2) {
	double d;
	d = b * b - 4 * a * c;
	if (d > 0) {
		x1 = (-b + sqrt(d)) / (2 * a);
		x2 = (-b - sqrt(d)) / (2 * a);
		return 1;
	}
	else if (d == 0) {
		x1 = -b / (2 * a);
		x2 = x1;
		return 0;
	}
	else return -1;
}

int main() {
	double a, b, c, x1, x2;
	cout << "Input the quadratic equation coefficients a,b,c for equation like a*x*x+b*x+c=0.\n";
	cout << "Please, enter a ";
	cin >> a;
	cout << "Please, enter b ";
	cin >> b;
	cout << "Please, enter c ";
	cin >> c;
	int result = Myroot(a, b, c, x1, x2);
	if (result>=0) cout << "x1= "<<x1<< ", x2= " << x2<<endl;
	else cout << "There are no roots for entered quadratic equation coefficients "<< endl;
	return result;
}