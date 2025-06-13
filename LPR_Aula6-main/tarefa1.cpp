//Exercício 1) Construa uma função em C++ que retorne o reverso de um número inteiro.
//Professor, os exercícios em cpp eu estou fazendo no online gdb porque o meu vscode não está compilando os códigos em cpp
#include <iostream>
using namespace std;

int reverso(int n) {
    int r = 0;
    while (n != 0) {
        r = r * 10 + n % 10;
        n /= 10;
    }
    return r;
}

int main() {
    int x;
    cout << "Digite um numero para ver seu reverso: ";
    cin >> x;
    cout << "Reverso: " << reverso(x) << endl;
    return 0;
}

