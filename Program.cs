// Escriba un programa que pida números al usuario y los sume hasta que el usuario ingrese 0.

int num;
int suma = 0;
do
{

    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());

    suma = num + suma;

} while (num != 0);

Console.WriteLine("El resultado es = " + suma);
