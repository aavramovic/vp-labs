#include <iostream>
#include <cmath>
using namespace std;


//TODO: konstruiraj ja abstraknata klasa Shape
Shape{
	int strana;
public:

};
//TODO: konstruiraj ja klasata Kvadrat

//TODO: konstruiraj ja klasata Krug

//TODO: konstruiraj ja klasata Triagolnik


//TODO: definiraj go metodot void checkNumTypes(Shape** niza, int n)

int main() {


	int n;
	cin >> n;

	//TODO: inicijaliziraj niza od pokazuvachi kon klasata Shape



	//TODO: alociraj memorija so golemina n za prethodno navedenata niza


	int classType;
	int side;

	//TODO: konstruiraj for ciklus so chija pomosh ke ja popolnish nizata
	for (int i = 0; i < n; ++i) {

		cin >> classType;
		cin >> side;

	}


	for (int i = 0; i < n; ++i) {

		niza[i]->pecati();
	}

	checkNumTypes(niza, n);


	return 0;
}