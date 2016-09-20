using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Rueda
    {
        public string marca;
        public float tamanio;
        

        //constructor por defecto
        public Rueda()
        {
            this.marca = "Sin marca";
        }

        
        public Rueda(string marca)
        {
            this.marca = marca;
        }


        public Rueda(int tamanio) :this()  // invoca al constructor por defecto
        {
            this.tamanio = tamanio;
        }



        // llama al constructor int tamanio quien a su vez llamar al 
        // constructor por defecto el cual se ejecuta primero, luego
        //int tamanio y por ultimo string marca, int tamanio
        public Rueda(string marca, int tamanio) :this(tamanio)
        {
            
            this.marca = marca;
        }


         
        public Rueda(int tamanio, string marca)
            : this(marca, tamanio)
        {
            //Reutiliza constructor anterior ya que solo se cambio el orden de los parametros
        }




        public void mostrarRueda()
        {
            Console.WriteLine("El tamaño es: "+ this.tamanio);
        }
    }
}
