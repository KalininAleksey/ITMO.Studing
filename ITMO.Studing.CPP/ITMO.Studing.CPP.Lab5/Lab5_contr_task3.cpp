#include <iostream>
#include<windows.h>
using namespace std;
int array_find_transp(int, int, int Arr1[]);
int main()
{
	SetConsoleOutputCP(1251);
	int a[] = { 7,6,5,4,3,2,1,3 };
	int el,id;
	int kc = sizeof(a) / sizeof(a[0]);
	cout << "�������� ������:\n";
	for (int i = 0; i < kc; i++) 
		cout << a[i] << " ";
	cout << endl;
	cout << "������� ������� ��� ������ � �������\n";
	cin >> el;
	id = array_find_transp(el, kc, a);
	cout << "������ �������� �������� �������:"<<id<<"\n";
	cout << "������ ����� ������ ��������� ������������:\n";
	for (int i = 0; i < kc; i++) //����� ����������.
		cout << a[i] << " ";
	cout << endl;
	return 0;
}
int array_find_transp(int elem, int N,int Arr[]) {
	int id = -1;
	int buf;
	for (int i = 0; i < N; i++)
	{
		if (Arr[i] == elem) {
			id = i;
			if (i != 0) {
				buf = Arr[i - 1];
				Arr[i - 1] = Arr[i];
				Arr[i] = buf;
			}
		}
	}
	return id;
}