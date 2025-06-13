#include <iostream>
using namespace std;

int main() {
    int numero, quadrado, soma = 0;
    
    std::cout << "Digite um numero: ";
    std::cin >> numero;
    
    quadrado = numero * numero;
    
    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }
    
    std::cout << "Soma dos digitos do quadrado: " << soma << std::endl;
    
    return 0;
}
