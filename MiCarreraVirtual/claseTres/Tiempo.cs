using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Tiempo
    {
        private int _cantidad;

        //private Tiempo()
        //{ }

        private Tiempo(int cantidad)
        {
            this._cantidad = cantidad;
        }


        //Sobrecarga Operadores

        //El "Tiempo" en la firma es el valor de retorno de los metodos
        public static Tiempo operator +(Tiempo tiempoUno, int valor)
        {
            
            tiempoUno._cantidad += valor;
            return tiempoUno;
        }

        public static Tiempo operator +(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            

            tiempoUno._cantidad = tiempoUno._cantidad + tiempoDos._cantidad;
            return tiempoUno;
        }


        public static Tiempo operator -(Tiempo tiempoUno, int valor)
        {
            
            tiempoUno._cantidad -= valor;
            return tiempoUno;
        }

        public static Tiempo operator -(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            
            tiempoUno._cantidad -= tiempoDos._cantidad;
            return tiempoUno;
        }




        public static bool operator ==(Tiempo tiempoUno, int valor)
        {
            if (tiempoUno._cantidad == valor)
                return true;
            return false;
        }

        public static bool operator !=(Tiempo tiempoUno, int valor)
        {
            return !(tiempoUno == valor);
        }




        public static bool operator ==(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            if (tiempoUno._cantidad == tiempoDos._cantidad)
                return true;
            return false;
        }


        public static bool operator !=(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            return !(tiempoUno == tiempoDos);
        }



        // Forma implicita:
        // Tiempo cantidad = 100;
        // Forma explicita:
        // Tiempo cantidad = (Tiempo) 100;
        // si defino la forma implicita funciona para los dos tipos de casteo
        

        public static implicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);
            
            
        }

        //No puedo definir las dos formas 
        //de casteo simultaneamente, debo elegir una (Chequear!!)

        /*
        
        public static explicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);

        }
         
        */

        public static explicit operator int(Tiempo tiempo)
        {
            return tiempo._cantidad;
        }



        public static bool operator >(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            return (int)tiempoUno > (int)tiempoDos;
        }

        public static bool operator <(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            return !(tiempoUno > tiempoDos);
        }



        public static bool operator >(Tiempo tiempoUno, int valor)
        {
            return (int)tiempoUno > valor;
        }

        public static bool operator <(Tiempo tiempoUno, int valor)
        {
            return !(tiempoUno > valor);
        }
    }
}
