using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{

    public delegate bool DelegateComparacion(Jug jugador);

    public class ListaDoble
    {
        
        public class ColeccionJugadores
        {
            private static ColeccionJugadores instance;

            public static ColeccionJugadores Instance
            {
                get
                {
                    if (instance == null)
                        instance = new ColeccionJugadores();
                    return instance;
                }
            }

        
            

            LinkedList<Jug> lista = new LinkedList<Jug>(); //lista doble enlace 

            //La colección contendrá la lista de artículos de la solicitud
            //private LinkedList<T> ljugadores;

            public ColeccionJugadores()
            {
                nuevaLista();
            }

            // Un método para iniciar una nueva lista cuando lo necesites.
            public void nuevaLista()
            {
                //Creamos una lista vacía
                lista = new LinkedList<Jug>();
            }

            //Se agrega un nuevo artículo a la lista
            public void AgregarJugador(Jug nuevoJugador)
            {
                // Ljugadores.Add(nuevoJugador);
                 lista.AddLast(nuevoJugador);
            }
        }

        
    }

    //clase del tipo de la lista
    public class Jug
    {
        public string Club { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Salario { get; set; }
        public string Posicion { get; set; }
    }


}
