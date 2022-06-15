//Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

//BilletesDe10
//BilletesDe20
//BilletesDe50
//BilletesDe100
//BilletesDe200
//BilletesDe500
//BilletesDe1000

//Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

//Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
//Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)

using Ejercicio6;
Billetera billetera1 = new Billetera(5,3,2,6,1,5,1);
Billetera billetera2 = new Billetera(6,3,5,1,2,7,6);
Billetera billetera3 = new Billetera();

void Total(Billetera billetera)
{
    decimal total = 0;
    total = billetera.BilletesDe10 * 10 + billetera.BilletesDe20 * 20 + billetera.BilletesDe50 * 50 + billetera.BilletesDe100 * 100 + billetera.BilletesDe200 * 200 + billetera.BilletesDe500 * 500 + billetera.BilletesDe1000 * 1000;
    Console.WriteLine("El total de la billetera es: " + total);
}

void Combinar(Billetera billetera1, Billetera billetera2)
{
    billetera3.BilletesDe10 += billetera1.BilletesDe10;
    billetera3.BilletesDe10 += billetera2.BilletesDe10;
    billetera3.BilletesDe20 += billetera1.BilletesDe20;
    billetera3.BilletesDe20 += billetera2.BilletesDe20;
    billetera3.BilletesDe50 += billetera1.BilletesDe50;
    billetera3.BilletesDe50 += billetera2.BilletesDe50;
    billetera3.BilletesDe100 += billetera1.BilletesDe100;
    billetera3.BilletesDe100 += billetera2.BilletesDe100;
    billetera3.BilletesDe200 += billetera1.BilletesDe200;
    billetera3.BilletesDe200 += billetera2.BilletesDe200;
    billetera3.BilletesDe500 += billetera1.BilletesDe500;
    billetera3.BilletesDe500 += billetera2.BilletesDe500;
    billetera3.BilletesDe1000 += billetera1.BilletesDe1000;
    billetera3.BilletesDe1000 += billetera2.BilletesDe1000;

    billetera1.BilletesDe10 = 0;
    billetera1.BilletesDe20 = 0;
    billetera1.BilletesDe50 = 0;
    billetera1.BilletesDe100 = 0;
    billetera1.BilletesDe200 = 0;
    billetera1.BilletesDe500 = 0;
    billetera1.BilletesDe1000 = 0;

    billetera2.BilletesDe10 = 0;
    billetera2.BilletesDe20 = 0;
    billetera2.BilletesDe50 = 0;
    billetera2.BilletesDe100 = 0;
    billetera2.BilletesDe200 = 0;
    billetera2.BilletesDe500 = 0;
    billetera2.BilletesDe1000 = 0;
}

Total(billetera1);
Total(billetera2);

Combinar(billetera1, billetera2);
Total(billetera3);

Total(billetera1);
Total(billetera2);
