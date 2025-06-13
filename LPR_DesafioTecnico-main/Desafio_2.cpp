//professor, eu testei o código no online gdb e deu certo mas aq ta dando errado
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    int a, b, c;
    cout << "Digite três alturas entre 150cm à 220cm: ";
    cin >> a >> b >> c;
    int v[] = {a, b, c};
    sort(v, v + 3);
    cout << "A altura do Gatti é: " << v[1] << endl;
    return 0;
}