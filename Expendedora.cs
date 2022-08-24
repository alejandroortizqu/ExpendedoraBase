﻿using System;
using System.Threading;



namespace ExpendedoraBase
{
    class Expendedora
    {
        string marca;
        byte temperatura;
        string codigo;
        float precio;

        public Expendedora()
        {
            Saludar();
            marca = " AMS";
            Console.WriteLine("Marca"+marca);
            ControlarTiempoDisplay();
            temperatura = 14;
            Console.WriteLine("La temperatura es: " + temperatura+"°C");
            ControlarTiempoDisplay();
            codigo = MostrarCodigoDeProductos();
            ControlarTiempoDisplay();
            MostrarPrecio(codigo);



        }
        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
            
        }


        void Saludar()
        {
            Console.WriteLine("Bienvenido");

        }

        string MostrarCodigoDeProductos()
        {
            Console.WriteLine("A1: Kinder Delice \tB2:Takis \tC3:Donitas");
            Console.WriteLine("Ingresa el codigo del producto que quieres");
            string codigo = Console.ReadLine(); //"codigo" es una variable local
            return codigo;
        }


        void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("El precio es: {0}", precio);
                    break;

                case "B2":
                    Console.WriteLine("El precio es: {0}", precio);
                    break;

                case "C3":
                    Console.WriteLine("El precio es: {0}", precio);
                    break;

                default:
                    Console.WriteLine("Producto no reconocido");
                    break;


            }
        }


    }
}
