#include <iostream>
#include <vector>
#include <algorithm>
#include <ctime>
#include <map>

using namespace std;

int main() {
    srand(time(0));
    vector<int> numeros;

    for (int i = 0; i < 100; i++)
        numeros.push_back(rand() % 100);

    sort(numeros.begin(), numeros.end());

    for (int n : numeros)
        cout << n << " ";
    cout << endl;

    vector<int> impares;
    for (int n : numeros)
        if (n % 2 != 0)
            impares.push_back(n);

    for (int n : impares)
        cout << n << " ";
    cout << endl;

    map<int, int> contagem;
    for (int n : numeros)
        contagem[n]++;

    for (auto p : contagem)
        if (p.second > 1)
            cout << p.first << " ";
    cout << endl;

    return 0;
}
