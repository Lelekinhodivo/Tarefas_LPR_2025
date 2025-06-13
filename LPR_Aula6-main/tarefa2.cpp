//Construa um algoritmo em C++ que agrupe em funções os exercícios 1, 3 e 4 da tarefa de estruturas de repetições. Cada exercício
//deve estar contido em uma função separada. Defina os parâmetros de modo eficiente e generalista. Construa um menu
//na função main. Reuse os códigos das suas respostas da tarefa no GitHub ou a resposta do professor postada no AVA.

#include <iostream>
#include <locale>
using namespace std;

void mediaNumerosPares(int quantidade) {
    int soma = 0;
    int contador = 0;

    while (quantidade > 0) {
        int numero;
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }

        quantidade--;
    }

    if (contador > 0) {
        double media = static_cast<double>(soma) / contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
}

void somaImparesMultiplosDe3() {
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;
}

void somaDigitosQuadrado(int numero) {
    int quadrado = numero * numero;
    int somaDigitos = 0;

    while (quadrado > 0) {
        somaDigitos += quadrado % 10;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado de " << numero << " é: " << somaDigitos << endl;
}

int main() {
    setlocale(LC_ALL, "pt_BR.utf8"); //para colocar acento
    int opcao;

    do {
        cout << "\nMENU:\n";
        cout << "1 - Média dos números pares\n";
        cout << "2 - Soma dos ímpares múltiplos de 3 (50 a 500)\n";
        cout << "3 - Soma dos dígitos do quadrado de um número\n";
        cout << "0 - Sair\n";
        cout << "Escolha uma opção: ";
        cin >> opcao;

        switch (opcao) {
            case 1: {
                int qtd;
                cout << "Digite a quantidade de números: ";
                cin >> qtd;
                mediaNumerosPares(qtd);
                break;
            }
            case 2:
                somaImparesMultiplosDe3();
                break;
            case 3: {
                int num;
                cout << "Digite um número: ";
                cin >> num;
                somaDigitosQuadrado(num);
                break;
            }
            case 0:
                cout << "Encerrando o programa..." << endl;
                break;
            default:
                cout << "Opção inválida!" << endl;
        }

    } while (opcao != 0);

    return 0;
}
