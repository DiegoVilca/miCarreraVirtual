using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //Necesaria para ArrayList

namespace claseTres
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Auto> listaAuto = new List<Auto>(); //generic
            ArrayList arrayListAuto = new ArrayList();//no generic
            Stack<Auto> pilaAuto = new Stack<Auto>();// si recibe el tipo es generica sino es no generica stack
            Queue<Auto> colaDeAutos = new Queue<Auto>();// si recibe el tipo es generica sino es no generica queue

            pilaAuto.Push(new Auto()); //agrega un objeto a la cima de la pila
            pilaAuto.Pop();//devuelve y borra el objeto de arriba de la pila
            //pilaAuto.Peek();//retorna el ultimo elemento pero no lo saca de la pila

            colaDeAutos.Enqueue(new Auto()); //agrega un objeto al final de la cola
            colaDeAutos.Dequeue(); //retira un objeto al principio de la cola
            //colaDeAutos.Peek(); //devuelve el objeto al principio de la cola pero no lo retira


            arrayListAuto.Add("hola"); //se genera una lista no generica, que puede agregar cualquier tipo de dato
            arrayListAuto.Add(new Auto());
            arrayListAuto.Add(5);


            listaAuto.Add(new Auto());// genera una lista generica de tipo auto
            //listaDeAuto.Add("hola");  no anda porque es una lista de auto

            
            
       /*   eFabricante fabricante;

            fabricante = eFabricante.Honda;
            Console.WriteLine(fabricante);

            fabricante = (eFabricante) 0;
            Console.WriteLine(fabricante);
            Console.ReadLine();
       */

            Rueda otraRueda = new Rueda("Firestone");
            // uso la sobrecarga de la clase Rueda.

            Rueda ruedaTres = new Rueda(4);


            //Carrera miCarrera= new Carrera();
            //miCarrera = miCarrera + new Auto();
            //miCarrera = miCarrera + new Auto();
            //miCarrera = miCarrera + new Auto();
            //miCarrera = miCarrera + new Auto();
            //miCarrera.correrCarrera((Tiempo)15);
            //miCarrera.mostrarCarrera();
            //miCarrera.volverACero();
            //miCarrera.correrCarrera((Kilometro)20);
            //miCarrera.mostrarCarrera();



         //   miCarrera.correrCarrera( (Tiempo) 15);
            
          //  miCarrera = new Carrera();
          //  miCarrera.correrCarrera( (Kilometro) 12);

           // miCarrera.mostrarCarrera();
          //  Console.ReadKey();

            /*
            Rueda nuevaRueda;
            nuevaRueda = new Rueda();

            Auto miAuto = new Auto();

            Auto miAuto1 = new Auto();

            Auto miAuto2 = new Auto();

            Auto miAuto3 = new Auto();
        */
        
        }
    }
}
