#include <iostream>
#include <ctime>
using namespace std;
//Практическое занятие 2. Контрольное задание 4. Вариант мишени 2.
int main() {
	srand(time(NULL));
	int iter,i,counter,x_c,y_c;
	float x_p,y_p,x,y,r;
	string shooter_type;
	i = 0;
	iter = 40;
	counter = 0;
	x_c= (rand() % 10)-5;
	cout << x_c << endl;
	y_c = (rand() % 10)-5;
	cout << y_c << endl;
	while (counter < iter) {
		i++;
		x_p = ((rand() % 10) * 0.1) - 0.5;
		cout << x_p << endl;
		y_p = ((rand() % 10) * 0.1) - 0.5;
		cout << x_p << endl;		
		cout << "Enter the coordinates: " << endl;
		cin >> x;
		cin >> y;
		r = (x + x_p - x_c) * (x + x_p - x_c) + (y + y_p - y_c) * (y + y_p - y_c);
		if (r <= 1) {
			counter += 10;
		}
		else if (r <= 4) {
			counter += 5;
		}
		else if (r <= 9) {
			counter += 1;
		}
		cout << "Shot-" << i << " .Distance from center = " << r << ". Your current sum of  points in shooting = " << "" << counter << endl;
	}
	if (i <= 5) {
		shooter_type = "sniper";
	}
	else if (i <= 10) {
		shooter_type = "shooter";
	}
	else {
		shooter_type = "beginner";
	}
	cout << "You are "<<shooter_type<< endl;
	return 0;
}