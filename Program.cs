using System;

namespace P2_InverseHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un arreglo con los caracteres que conforman la frase "Hello
            //World!". Invertir el orden de los caracteres, e imprimir el arreglo
            //resultante.
            //Se debe imprimir lo siguiente:
            //!dlroW olleH

            string[] caracteres = new string[12] {"H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!"};

            for(int i = 11; i >= 0; i--)
            {
                Console.Write(caracteres[i]);
            }

        }
    }
}