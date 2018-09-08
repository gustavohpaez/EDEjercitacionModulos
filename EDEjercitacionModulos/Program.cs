using System;

namespace EjercitacionEstructuradeDatos
{
    class Program
    {
        // PROGRAMA
        static void Main()
        {
            int modulo;
            Console.WriteLine("Ingrese el numero de modulos : ");
            modulo = Convert.ToInt32(Console.ReadLine());

            switch (modulo)
            {
                case 1: modulo1(); break;
                case 2: modulo2(); break;
                case 3: modulo3(); break;
                case 4: modulo4(); break;
                case 5: modulo5(); break;
            }
            int modulo1()
            {
                Console.WriteLine("Hola Mundo");

                return 0;
            }
            int modulo2()
            {
                int ejercicio2;
                Console.WriteLine("Elija el numero del ejercicio: ");
                ejercicio2 = Convert.ToInt32(Console.ReadLine());

                // SELECCION 1 (modulo 2)
                switch (ejercicio2)
                {
                    case 2: e2(); break;
                    case 3: e3(); break;
                    case 4: e4(); break;
                    case 5: e5(); break;
                    case 6: e6(); break;
                    case 7: e7(); break;
                    case 8: e8(); break;
                    case 9: e9(); break;
                    case 10: e10(); break;
                    case 11: e11(); break;
                    case 12: e12(); break;
                    case 13: e13(); break;
                    case 14: e14(); break;
                    case 15: e15(); break;
                    case 16: e16(); break;
                }
                int e2()
                {
                    int resultado = 200 + 56;
                    Console.WriteLine("Crea un programa que diga el resultado de sumar 200 y 56.");
                    Console.WriteLine("El resultado es: {0}", resultado);
                    return 0;
                }
                int e3()
                {
                    int n1 = 13, n2 = 12, resultado = n1 * n2;
                    Console.WriteLine("Crear un programa que calcule el producto de los numeros 12 y 13.");
                    Console.WriteLine("El producto es {0}.", resultado);
                    return 0;
                }
                int e4()
                {
                    int n1 = 321, n2 = 213, resultado = n1 - n2;
                    Console.WriteLine("Crear un programa que calcule la resta entre 321 y 213:");
                    Console.WriteLine("El resultado es {0}.", resultado);
                    return 0;
                }
                int e5()
                {
                    int n1 = 20, n2 = 5, resultado = (n1 + n2) % 6;
                    Console.WriteLine("Calcular el resultado de (20+5)%6:");
                    Console.WriteLine("El resultado es {0}.", resultado);
                    return 0;
                }
                int e6()
                {
                    int n1 = 12, n2 = 102, resultado = n1 * n2;
                    Console.WriteLine("Crea un programa que calcule el producto de los números 12 y 102, usando variables.");
                    Console.WriteLine("El resultado es {0}.", resultado);
                    return 0;
                }
                int e7()
                {
                    int n1 = 200, n2 = 1111, resultado = n1 + n2;
                    Console.WriteLine(" Crea un programa que calcule la suma de 200 y 1111, usando variables.");
                    Console.WriteLine("El resultado es {0}.", resultado);
                    return 0;
                }
                int e8()
                {
                    int numero1 = 10, numero2 = 25, resultado = numero1 * numero2;
                    Console.WriteLine("Crea un programa que calcule el producto de los números 10 y 25, usando variables llamadas numero1 y numero2");
                    Console.WriteLine("El resultado es {0}.", resultado);
                    return 0;
                }
                int e9()
                {
                    int n1 = 20, n2 = 5, resultado = n1 * n2;
                    Console.WriteLine("Crea un programa que calcule el producto de dos números introducidos por el usuario.");
                    Console.WriteLine("Ingrese el primer numero: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el primer numero: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El resultado es {0}.", resultado);
                    return 0;
                }
                int e10()
                {
                    int n1;
                    Console.WriteLine("Crea un programa que pida al usuario un número entero y diga si es par. ");
                    Console.WriteLine("Ingrese un numero entero: ");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    if (n1 % 2 == 0)
                        Console.WriteLine("El numero es par.");
                    else
                        Console.WriteLine("El numero no es par.");
                    return 0;
                }
                int e11()
                {
                    int n1, n2, mayor;
                    Console.WriteLine("Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos. ");
                    Console.WriteLine("Ingrese un numero entero: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese un numero entero: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    mayor = n1 > n2 ? n1 : n2;

                    Console.WriteLine("El mayor es: {0}", mayor);
                    return 0;

                }
                int e12()//Verificar 
                {
                    int n1, n2, r;
                    Console.WriteLine(" Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero, escribirá Error: No se puede dividir entre cero");
                    Console.WriteLine("Ingrese un numero entero: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese un numero entero: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    r = (n1 / n2);

                    if (n2 != 0)
                        Console.WriteLine("El resultado es: {0}", r);
                    if (n2 == 0)
                        Console.WriteLine("Error: No se puede dividir entre cero");
                    return 0;
                }
                int e13()
                {
                    int n1;
                    Console.WriteLine("Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, usando switch por ejemplo, si introduce 1, el programa escribirá uno");
                    Console.WriteLine("Ingrese y numero del 1 al 5: ");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    switch (n1)
                    {
                        case 1: Console.WriteLine("Uno"); break;
                        case 2: Console.WriteLine("Dos"); break;
                        case 3: Console.WriteLine("Tres"); break;
                        case 4: Console.WriteLine("Cuatro"); break;
                        case 5: Console.WriteLine("Cinco"); break;

                    }
                    return 0;
                }
                int e14()
                {
                    int n = 1;
                    Console.WriteLine("Crea un programa que escriba en pantalla los números del 1 al 10, usando while");

                    while (n < 11)
                    {
                        Console.WriteLine(n);
                        n = n + 1;
                    }
                    return 0;
                }
                int e15()
                {
                    int n = 1;
                    Console.WriteLine("Crea un programa que escriba en pantalla los números del 1 al 10, usando do..while");

                    do
                    {
                        Console.WriteLine(n);
                        n = n + 1;
                    }
                    while (n < 11);

                    return 0;
                }
                int e16()
                {
                    int contador;
                    Console.WriteLine(" Crea un programa que muestre los números del 10 al 20, ambos incluidos, usando for");

                    for (contador = 10; contador <= 20; contador++)
                        Console.WriteLine(contador);
                    return 0;
                }

                return 0;
            }
            int modulo3()
            {
                int ejercicio3;
                Console.WriteLine("Elija el numero del ejercicio: ");
                ejercicio3 = Convert.ToInt32(Console.ReadLine());

                // SELECCION 2 (modulo 3)
                switch (ejercicio3)
                {
                    case 1: ee1(); break;
                    case 2: ee2(); break;
                    case 3: ee3(); break;
                    case 4: ee4(); break;
                    case 5: ee5(); break;
                    case 6: ee6(); break;
                    case 7: ee7(); break;
                    case 8: ee8(); break;
                    case 9: ee9(); break;
                    case 10: ee10(); break;
                }
                int ee1()
                {
                    int clave1;
                    int identificador = 1111;
                    int clave2;
                    int contraseña = 2222;

                    Console.WriteLine("Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos), y no le permita seguir hasta que introduzca como identificador 1234 y como contraseña 1111. ");

                    do
                    {
                        Console.Write("Introdusca su numero Identificador:");
                        clave1 = Convert.ToInt32(Console.ReadLine());

                        if (clave1 != identificador)
                            Console.Write("No valida");
                        else
                            Console.Write("Identificador aceptado");
                    }
                    while (clave1 != identificador);

                    do
                    {
                        Console.Write("Introdusca su contraseña:");
                        clave2 = Convert.ToInt32(Console.ReadLine());

                        if (clave2 != contraseña)
                            Console.Write("No valida");
                        else
                            Console.Write("Contraseña aceptada");

                    }
                    while (clave2 != contraseña);

                    return 0;

                }
                int ee2()//verificar
                {
                    Console.WriteLine("Crea un programa calcule cuantas cifras tiene un número entero positivo(pista: se puede hacer dividiendo varias veces entre 10).");
                    Console.WriteLine("Ingrese un numero entero positivo");
                    //numero = Convert.ToInt32(Console.ReadLine());

                    //foreach (int num letra in numero)
                    {
                        //Console.WriteLine(num);
                    }

                    return 0;
                }//verificar
                int ee3()
                {
                    int numero = 1;
                    int numero2 = 0;
                    Console.Write(" Crea un programa que muestre la tabla de multiplicar del 9");

                    while (numero2 < 11)
                    {
                        Console.WriteLine("9x{0}={1}", numero2, numero);
                        numero2 = numero2 + 1;
                        numero = numero2 * 9;

                    }
                    return 0;

                }
                int ee4()
                {
                    int numero = 1;
                    Console.Write("Crea un programa que contenga un bucle sin fin que muestre los números enteros positivos a partir del uno. ");

                    while (numero > 0)
                    {
                        Console.WriteLine(numero);
                        numero = numero + 1;
                    }
                    return 0;

                }
                int ee5()
                {
                    int n1 = 1;
                    string palabra;
                    Console.WriteLine("Crea un programa que contenga un bucle sin fin que escriba Hola en pantalla, sin avanzar de línea.");
                    palabra = "HOLA";

                    while (1 == 1)
                    {
                        Console.Write("{0}", palabra);
                        n1 = n1 - 1;
                    }

                }
                int ee6()
                {
                    int a, b, c, b2, a2;
                    Console.WriteLine("¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5; a=a*2; Crea un programa que lo resuelva. ");
                    a = 5;
                    b = ++a;
                    c = a++;
                    b2 = b * 5;
                    a2 = a * 2;

                    Console.WriteLine("Los resultados de las operaciones son a = 5, (b = ++a)= {0},(c = a++)= {1},(b = b * 5)= {2},(a = a * 2)={3}", b, c, b2, a2);

                    return 0;
                }//verificar los resultados
                int ee7()
                {
                    int a, b, b2, c, c2, c3, a2;
                    Console.WriteLine("¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre. ");
                    a = 5;
                    b = a + 2;
                    b2 = b -= 3;
                    c = -3;
                    c2 = c *= 2;
                    c3 = ++c;
                    a2 = a *= b;

                    Console.WriteLine("Los resultados de las operaciones son a = 5, (b=a+2)= {0},(b-=3)= {1},(c=-3)= {2},(c*=2)={3},(++c)={4},(a*=b)={5}", b, b2, c, c2, c3, a2);

                    return 0;
                }//Verificar los resultados 
                int ee8()
                {
                    int n = 1;
                    char letra;
                    bool esvocal;

                    Console.WriteLine("Introduce una letra");
                    letra = Convert.ToChar(Console.ReadLine());

                    esvocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u');

                    if (esvocal)
                    {
                        Console.WriteLine("Es vocal");
                    }
                    else
                    {
                        Console.WriteLine("No es una vocal");
                    }

                    return 0;
                }
                int ee9()
                {
                    string usuario = "gustavo";

                    int datocontraseña1, datocontraseña2;
                    string datousuario;
                    int i = 1;

                    Console.WriteLine("Ingrese su usuario: ");
                    datousuario = Console.ReadLine();

                    if (usuario == datousuario)
                    {
                        Console.WriteLine("Ingrese su contraseña: ");
                        datocontraseña1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese su contraseña nuevamente: ");
                        datocontraseña2 = Convert.ToInt32(Console.ReadLine());

                        while (datocontraseña1 != datocontraseña2)
                        {
                            Console.WriteLine("Las contraseñas no son iguales");
                            Console.WriteLine("Ingrese su contraseña: ");
                            datocontraseña1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese su contraseña nuevamente: ");
                            datocontraseña2 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("AUTORIZADO");
                    }
                    else
                    {
                        Console.WriteLine("El usuario no existe. ");
                    }

                    return 0;
                }
                int ee10()
                {
                    int n = 1;
                    string nombre;
                    string nombreautorizado = "Martin";
                    Console.WriteLine("Quien sos?");
                    nombre = Console.ReadLine();

                    if (nombre == nombreautorizado)
                    {
                        Console.WriteLine("HOLA!");
                    }
                    else
                    {
                        Console.WriteLine("NO TE CONOZCO");
                    }

                    return 0;
                }

                return ejercicio3;

            }
            int modulo4()
            {
                int ejercicio4;
                Console.WriteLine("Elija el numero del ejercicio: ");
                ejercicio4 = Convert.ToInt32(Console.ReadLine());

                // SELECCION 4 (modulo 4)
                switch (ejercicio4)
                {
                    case 1: ee1(); break;
                    case 2: ee2(); break;
                    case 3: ee3(); break;
                    case 4: ee4(); break;
                    case 5: ee5(); break;
                    case 6: ee6(); break;
                    case 7: ee7(); break;
                    case 8: ee8(); break;
                    case 9: ee9(); break;
                    case 10: ee10(); break;
                }
                int ee1()
                {
                    int n = 1;
                    int[] numeros = { 200, 150, 100, -50, 300 };
                    int suma;

                    suma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4];


                    return n;
                }
                int ee2()
                {
                    return 0;
                }
                int ee3()
                {
                    return 0;
                }
                int ee4()
                {
                    return 0;
                }
                int ee5()
                {
                    return 0;
                }
                int ee6()
                {
                    return 0;
                }
                int ee7()
                {
                    return 0;
                }
                int ee8()
                {
                    return 0;
                }
                int ee9()
                {
                    return 0;
                }
                int ee10()
                {
                    return 0;
                }

                return ejercicio4;
            }
            int modulo5()
            {
                int ejercicio5;
                Console.WriteLine("Elija el numero del ejercicio: ");
                ejercicio5 = Convert.ToInt32(Console.ReadLine());

                // SELECCION 5 (modulo 5)
                switch (ejercicio5)
                {
                    case 1: ee1(); break;
                    case 2: ee2(); break;
                    case 3: ee3(); break;
                    case 4: ee4(); break;
                    case 5: ee5(); break;
                    case 6: ee6(); break;
                    case 7: ee7(); break;
                }
                int ee1()
                {
                    Signo();
                    return 0;
                }
                int ee2()
                {

                    Menor();
                    return 0;
                }
                int ee3()
                {
                    return 0;
                }
                int ee4()
                {
                    return 0;
                }
                int ee5()
                {
                    return 0;
                }
                int ee6()
                {
                    return 0;
                }
                int ee7()
                {
                    return 0;
                }

                return ejercicio5;
            }
        }
        // FUNCIONES MODULO 5
        static void Signo()
        {
            int n;
            Console.WriteLine("Ingrese un numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
                Console.WriteLine("-1");
            if (n > 0)
                Console.WriteLine("+1");
            else
                Console.WriteLine("0");
        } // Funcion Ejercicio 1

        static void Menor()
        {
            int n1, n2;
            Console.WriteLine("Ingrese un numeros: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2)
            {
                Console.WriteLine("El menor es: {0}", n1);
            }
            else
            {
                Console.WriteLine("El menor es: {0}", n2);
            }

        } // Funcion Ejercicio 2

        static void EsPrimo()
        {

        } // Funcion Ejercicio 3
    }
}
