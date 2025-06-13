#include <iostream>
#include <cmath>

int main() {

double horasPorDia, horasPorSemana, dias, semanas, meses;
std::cout << "Digite o numero de horas de treinamento por dia: ";
std::cin >> horasPorDia;

horasPorSemana = horasPorDia * 5;
dias = std::ceil(1000 / horasPorDia);
semanas = std::ceil(dias / 5);
meses = semanas / 4.5;

std::cout << "Total de horas por semana: " << horasPorSemana << std::endl;
std::cout << "Dias necessarios: " << dias << std::endl;
std::cout << "Semanas necessarias: " << semanas << std::endl;
std::cout << "Meses necessarios: " << meses << std::endl;

return 0;

}