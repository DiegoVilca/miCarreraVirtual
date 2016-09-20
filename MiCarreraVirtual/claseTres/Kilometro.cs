using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Kilometro
    {
        private int _cantidad;


        private Kilometro(int cantidad)
        {
            this._cantidad = cantidad;
        }


        public static Kilometro operator +(Kilometro kilometroUno, int valor)
        {
            kilometroUno._cantidad += valor;
            return kilometroUno;
        }

        public static Kilometro operator +(Kilometro kilometroUno, Kilometro kilometroDos)
        {
            
            kilometroUno._cantidad = kilometroUno._cantidad + kilometroDos._cantidad;
            return kilometroUno;
        }


        public static Kilometro operator -(Kilometro kilometroUno, int valor)
        {
           
            kilometroUno._cantidad -= valor;
            return kilometroUno;
        }

        public static Kilometro operator -(Kilometro kilometroUno, Kilometro kilometroDos)
        {
            
            kilometroUno._cantidad -= kilometroDos._cantidad;
            return kilometroUno;
        }

        public static bool operator ==(Kilometro kilometroUno, int valor)
        {
            
            if (kilometroUno._cantidad == valor)
                return true;
            return false;
        }

        public static bool operator !=(Kilometro kilometroUno, int valor)
        {

            return !(kilometroUno == valor);
        }

        public static bool operator ==(Kilometro kilometroUno, Kilometro kilometroDos)
        {
            
            if (kilometroUno._cantidad == kilometroDos._cantidad)
                return true;
            return false;
        }


        public static bool operator !=(Kilometro kilometroUno, Kilometro kilometroDos)
        {
            return !(kilometroUno == kilometroDos);
        }




        public static implicit operator Kilometro(int numero)
        {
            return new Kilometro(numero);
        }

        public static explicit operator int(Kilometro kilometroUno)
        {
            return kilometroUno._cantidad;
        }


        public static bool operator >(Kilometro kilometroUno, Kilometro kilometroDos)
        {
            return (int)kilometroUno > (int)kilometroDos;
        }

        public static bool operator <(Kilometro kilometroUno, Kilometro kilometroDos)
        {
            return !(kilometroUno > kilometroDos);
        }



        public static bool operator >(Kilometro kilometroUno, int valor)
        {
            return (int)kilometroUno > valor;
        }

        public static bool operator <(Kilometro kilometroUno, int valor)
        {
            return !(kilometroUno > valor);
        }
    }
}
