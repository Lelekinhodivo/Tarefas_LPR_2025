#include <iostream>
#include <vector>

using namespace std;

int main() {
    int n, numeroProcurado, valor;
    vector<int> vetor;
    int ocorrencias = 0;

    cout << "Quantos numeros voce deseja digitar? ";
    cin >> n;

    cout << "Digite os " << n << " numeros:" << endl;
    for (int i = 0; i < n; i++) {
        cin >> valor;
        vetor.push_back(valor);
    }

    cout << "Digite o numero que deseja pesquisar: ";
    cin >> numeroProcurado;

    // Pesquisa no vetor
    cout << "O numero " << numeroProcurado << " aparece nas posicoes: ";
    for (int i = 0; i < vetor.size(); i++) {
        if (vetor[i] == numeroProcurado) {
            cout << i << " ";
            ocorrencias++;
        }
    }

    if (ocorrencias > 0) {
        cout << "\nTotal de ocorrencias: " << ocorrencias << endl;
    } else {
        cout << "\nNumero nao encontrado no vetor." << endl;
    }

    return 0;
}
