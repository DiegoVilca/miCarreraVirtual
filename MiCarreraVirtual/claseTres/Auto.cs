using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Auto
    {
        private eFabricante _fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        private string _nombrePiloto;
        public static int contadorDeObjetos;

        //private int kmRecorridos;
        //private int tiempoDemorado;

        private Kilometro _kmRecorridos;
        private Tiempo _tiempoDemorado;
        private static Random _numeroRandom;



        #region Propiedades

        public string NombrePiloto
        {
            set
            {
                this._nombrePiloto = value;
            }
            get
            {
                return _nombrePiloto;
            }

        }

        public string DatosEnString
        {
            get
            {
                return DevolverStringParaListado();
            }

        }

        #endregion Propiedades



        #region Constructores

        public Auto()
        {

            int num = _numeroRandom.Next(0, 2);
            this._fabricante = (eFabricante)num;
            this._kmRecorridos = 0;
            this._tiempoDemorado = 0;
            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TI = new Rueda();
            this.TD = new Rueda();
            Auto.contadorDeObjetos++;
        }

        public Auto(string nombrePiloto, eFabricante fabricante) : this()
        {
            this._nombrePiloto = nombrePiloto;
            this._fabricante = fabricante;
        }


        //Los constructores estaticos se ejecutan una vez 
        //(cuando se crea el primer objeto)
        //No se los puede sobrecargar
        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            _numeroRandom = new Random();
            
        }

        #endregion Constructores



        #region Metodos

        public string Devolverstring()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Fabricante: " + this._fabricante);
            sb.AppendLine("Kilometros: " + this._kmRecorridos);
            sb.AppendLine("Tiempo: " + this._tiempoDemorado);

            return sb.ToString();
        }


        //Es utilizada por la propiedad DatosEnString
        private string DevolverStringParaListado() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Piloto: " + this._nombrePiloto);
            sb.AppendLine(" - Fabricante: " + this._fabricante);

            return sb.ToString();
        }



        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            if (this._tiempoDemorado == 0)
            {
                //sb.AppendLine("El fab es: " + this.fabricante.ToString());
                sb.AppendFormat("El fab es: {0}", this._fabricante);
                sb.AppendFormat(" Y este auto recorrio: {0}", (int)this._kmRecorridos);
                //Console.WriteLine("El fab es: {0}", this.fabricante);                
                //Console.WriteLine("Y este auto recorrio: {0}", (int)this.kmRecorridos);
                //falta otro mostrar autoo ve como hacerlo 
                return sb.ToString();
            }
            else
            {
                sb.AppendLine("El fab es: " + this._fabricante.ToString());
                sb.AppendLine("Y este auto tardo: " + (int)this._kmRecorridos);
                return sb.ToString();
            }
        }



        public int DevolverKilometros()
        {
            return (int)this._kmRecorridos;
        }

        public int DevolverTiempo()
        {
            return (int)this._tiempoDemorado;
        }

        public void VolverACero()
        {
            this._kmRecorridos = 0;
            this._tiempoDemorado = 0;
        }

        /*
         * DEPRECATED POR SOBRECARGA DE METODOS
         * 
        //public void agregarKm(int km)
        //{
        //    this.kmRecorridos = km;
        //}

        //public void agregarTiempo(int tiempo)
        //{
        //    this.tiempoDemorado = tiempo;
        //}
        */


        public static bool CompararAuto(Auto uno, Auto dos)
        {
            if (uno._fabricante == dos._fabricante)
                return true;
            return false;
        }


        public void Agregar(Tiempo tiempo)
        {
            this._tiempoDemorado = this._tiempoDemorado + tiempo;
        }

        public void Agregar(Kilometro km)
        {
            this._kmRecorridos = this._kmRecorridos + km;
        }

        #endregion Metodos



        #region Ordenamiento

        public static int ordenarPorFabricanteAsc(Auto unAuto, Auto otroAuto)
        {
            return string.Compare(unAuto._fabricante.ToString(), otroAuto._fabricante.ToString());
        }
        public static int ordenarPorFabricanteDesc(Auto unAuto, Auto otroAuto)
        {
            return string.Compare(otroAuto._fabricante.ToString(), unAuto._fabricante.ToString());
        }

        public static int ordenarPorPilotoAsc(Auto unAuto, Auto otroAuto)
        {
            return string.Compare(unAuto._nombrePiloto, otroAuto._nombrePiloto);
        }
        public static int ordenarPorPilotoDesc(Auto unAuto, Auto otroAuto)
        {
            return string.Compare(otroAuto._nombrePiloto, unAuto._nombrePiloto);
        }


        //public static int ordenarPorPilotoDesc(Auto auto1, Auto auto2)
        //{
        //    return auto1.NombrePiloto.CompareTo(auto2.NombrePiloto);

        //}
        //public static int ordenarPorPilotoAsc(Auto auto1, Auto auto2)
        //{
        //    return auto2.NombrePiloto.CompareTo(auto1.NombrePiloto);

        //}
        //public static int ordenarPorFabricanteDesc(Auto auto1, Auto auto2)
        //{
        //    return auto1._fabricante.CompareTo(auto2._fabricante);

        //}
        //public static int ordenarPorFabricanteAsc(Auto auto1, Auto auto2)
        //{
        //    return auto2._fabricante.CompareTo(auto1._fabricante);

        //}

        #endregion Ordenamiento

    }
}
