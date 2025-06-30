#include <iostream>
#include <map>
#include <vector>
#include <numeric>
#include <algorithm>

using namespace std;

int main() {
    int x;
    cin >> x;

    map<string, int> cidades;

    for (int i = 0; i < x; i++) {
        string nome;
        int populacao;
        cin >> nome >> populacao;
        cidades[nome] = populacao;
    }

    vector<int> populacoes;
    for (auto& p : cidades)
        populacoes.push_back(p.second);

    double media = accumulate(populacoes.begin(), populacoes.end(), 0.0) / populacoes.size();

    for (auto& p : cidades)
        if (p.second > media)
            cout << p.first << endl;

    auto mais_populosa = max_element(cidades.begin(), cidades.end(),
        [](auto& a, auto& b) { return a.second < b.second; });
    auto menos_populosa = min_element(cidades.begin(), cidades.end(),
        [](auto& a, auto& b) { return a.second < b.second; });

    cout << "Mais populosa: " << mais_populosa->first << endl;
    cout << "Menos populosa: " << menos_populosa->first << endl;

    int y;
    cin >> y;

    vector<string> para_remover;
    for (auto& p : cidades)
        if (p.second == y)
            para_remover.push_back(p.first);

    for (string nome : para_remover)
        cidades.erase(nome);

    for (auto& p : cidades)
        cout << p.first << ": " << p.second << endl;

    return 0;
}
