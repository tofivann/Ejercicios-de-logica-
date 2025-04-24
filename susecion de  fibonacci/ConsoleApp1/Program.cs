/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */

int n = 50;
//USANDO RECURSIVIDAD
/*
int fibonacci (int n) {

    if (n == 0) {
        return n;
    }
    if (n == 1) {  return n;}

    else 
        return fibonacci (n-1) + fibonacci(n-2);
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(i +" : "+ fibonacci(i));

}

*/
//sin recursividad
long a = 0;
long b = 0;
long c = 1;

for (int i=0; i<n; i++)
{
    Console.WriteLine(a);
    b = a;
    c = a + c;
    a = c;
    c = b;
}

