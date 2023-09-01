using FundamentosCSHARP.Models;
using System;

namespace FundamentosCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte numero = 123;
            //sbyte n = -25;
            //int num = -152;
            //uint nume = +152;

            ////Console.WriteLine(num);
            ////Bebida bebida = new Bebida("Coca Cola", "No te abandona" , 1220);
            ////bebida.Beberse(500);

            //Cerveza cerveza = new Cerveza();
            //cerveza.Beberse(500);

            //Console.WriteLine(cerveza.Cantidad);

            //Console.WriteLine("****************************************");
            
            //var bebidaAlcoholica = new Vino(100);
            //MostrarRecomendaciones(bebidaAlcoholica);






            CervezaBD cervezaBD = new CervezaBD();

            // INSERTAMOS NUEVA CERVEZA

            //Cerveza cerveza1 = new Cerveza(15, "Pale Ale");
            //cerveza1.Marca = "Minerva";
            //cerveza1.Alcohol = 6;
            //cervezaBD.Add(cerveza1);

            //Cerveza cerveza = new Cerveza(5, "Pale Ale");
            //cerveza.Marca = "Minerva";
            //cerveza.Alcohol = 5;
            //cervezaBD.Edit(cerveza, 4);


            cervezaBD.Delet(4);

            //var cervezas = cervezaBD.Get();

            //foreach ( var cerveza in cervezas)
            //{
            //    Console.WriteLine(cerveza.Nombre);
            //}





        }

        //static void MostrarRecomendaciones(IBebidaAlcoholica bebida)
        //{
        //    bebida.MaxRecomendado();
        //}
    }
}
