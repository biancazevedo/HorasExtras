﻿Console.WriteLine("--- Horas Extras ---\n");

Console.WriteLine($"salario-hora {12:C}, {400} horas, sendo {0,4} horas-extra, salário = {Salario(12, 400, 0):C}");
Console.WriteLine($"salario-hora {12:C}, {400} horas, sendo {20} horas-extra, salário = {Salario(12, 400, 20):C}");
Console.WriteLine($"salario-hora {24:C}, {400} horas, sendo {0,4} horas-extra, salário = {Salario(24, 400, 0):C}");
Console.WriteLine($"salario-hora {24:C}, {400} horas, sendo {20} horas-extra, salário = {Salario(24, 400, 20):C}");

double Salario(double salarioHora, double horasTotais, double horasExtras)
{
    return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);
}
