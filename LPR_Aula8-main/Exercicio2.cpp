#include <iostream>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main() {
    Livro livros[3];
    float precoTotal = 0;
    int paginasTotais = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Livro " << i + 1 << ":" << endl;
        cout << "Titulo (sem espaços): ";
        cin >> livros[i].Titulo;
        cout << "Autor (sem espaços): ";
        cin >> livros[i].Autor;
        cout << "Ano de Publicacao: ";
        cin >> livros[i].AnoPublicacao;
        cout << "Numero de Paginas: ";
        cin >> livros[i].NumeroPaginas;
        cout << "Preco: ";
        cin >> livros[i].Preco;

        precoTotal += livros[i].Preco;
        paginasTotais += livros[i].NumeroPaginas;
    }

    float mediaPaginas = paginasTotais / 3.0;

    cout << "Preco total: R$ " << precoTotal << endl;
    cout << "Media de paginas: " << mediaPaginas << endl;

    return 0;
}
