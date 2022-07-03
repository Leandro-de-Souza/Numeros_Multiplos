#include <iostream>

using namespace std;

int main()
{

       int numero1, numero2;

       cout << "Digite dois numeros inteiros: " << endl;
       cin >> numero1;
       cin >> numero2;

       if (numero1 % numero2 == 0 || numero2 % numero1 == 0) {
            cout << "Sao multiplos" << endl;
       }
       else { cout << "Nao sao multiplos";
       }


    return 0;
}
