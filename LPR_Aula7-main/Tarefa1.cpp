#include <iostream>
#include <vector>

using namespace std;

int main() {
    int numeros[10];
    vector<int> pares;
    vector<int> impares;

    cout << "Digite 10 numeros inteiros:" << endl;
    for (int i = 0; i < 10; i++) {
        cin >> numeros[i];
    }

    // Separação em pares e ímpares
    for (int i = 0; i < 10; i++) {
        if (numeros[i] % 2 == 0)
            pares.push_back(numeros[i]);
        else
            impares.push_back(numeros[i]);
    }

    cout << "PAR: ";
    for (int i = 0; i < pares.size(); i++) {
        cout << pares[i] << " ";
    }
    cout << endl;

    cout << "ÍMPAR: ";
    for (int i = 0; i < impares.size(); i++) {
        cout << impares[i] << " ";
    }
    cout << endl;

    return 0;
}
