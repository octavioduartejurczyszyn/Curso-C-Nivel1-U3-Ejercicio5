using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores 
            //a 100.
            int a, b, c, d, con = 0;

            Console.WriteLine("Escriba un número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el último:");
            d = int.Parse(Console.ReadLine());
            
            if( a > 100){
                Console.Write(a + ", ");
                con++; 
            }
            if(b > 100){
                Console.Write(b + ", ");
                con++;
            }
            if(c > 100){
                Console.Write(c + ", ");
                con++;
            }
            if(d > 100)
                Console.Write(d + ", ");
                con++;
            if(con != 0)
               Console.Write("son mayores a 100");

            // aca lo que hacemos con el contador es para al final mostrar un cartel adicional,
            // tambien podria haber puesto un else que diga no hujbo mayores a 100
        
        }   

    }
}
