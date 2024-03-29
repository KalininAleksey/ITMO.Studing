#include <iostream> 
#include <string>
#include <windows.h>
using namespace std;
class Triangle
{
public:
	class LengthError {
	public:
		LengthError() : message("���� �� ������ ������������ ������ ����� ���� ������.") { }
		void printMessage() const {
			cout << message << endl;
		}
	private:
		string message;
	};
	Triangle(int ai, int bi, int ci) {
		a = ai;
		b = bi;
		c = ci;
		if ((a > b + c) || (b > a + c) || (c > a + b)) throw LengthError();
	}
	float Square() {
		float p;
		p = (a + b + c) / 2;
		return sqrt(p * (p - a) * (p - b) * (p - c));
	}
private:
	float a, b, c;
};
int main() {
	SetConsoleOutputCP(1251);
	float a, b, c, S;
	string name;
	cout << "������� ����� ������ ������������:\n";
	cin >> a;
	cin >> b;
	cin >> c;
	try {
		Triangle T(a, b, c);
		S = T.Square();
		cout.precision(2);
		cout << "������� �� �������� �������� ���������� " << S << endl;
	}
	catch (Triangle::LengthError& error) {
		cout << "������: "; error.printMessage();
		return 1;
	}
	return 0;
}