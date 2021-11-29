using System;
using System.Collections.Generic;

namespace DesignPatterns_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificador Apple = new Notificador("iPhone 13", 34000, "No disponible");
            Observador cliente1 = new Observador("Fernando", Apple);
            Observador cliente2 = new Observador("Antonio", Apple);
            Observador cliente3 = new Observador("Maria", Apple);
            Console.WriteLine($"iPhone 13 - Estado: {Apple.obtenerDisponibilidad()}\n");
            Apple.definirDisponibilidad("Disponible");
        }
    }

    public interface IObservador
    {
        void update(string disponibilidad);
    }

    public interface INotificador
    {
        void AgregarObservador(IObservador observador);
        void EliminarObservador(IObservador observador);
        void NotificarObservadores();
    }


    public class Observador : IObservador
    {
        public string NombreUsuario { get; set; }

        public Observador(string nombreUsuario, INotificador notificador)
        {
            NombreUsuario = nombreUsuario;
            notificador.AgregarObservador(this);
        }

        public void update(string disponibilidad)
        {
            Console.WriteLine($"Hola {NombreUsuario}, el producto se encuentra {disponibilidad}");
        }
    }


    public class Notificador : INotificador
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string NombreProducto { get; set; }
        private int PrecioProducto { get; set; }
        private string Disponibilidad { get; set; }

        public Notificador(string nombreProducto, int precioProducto, string disponibilidad)
        {
            NombreProducto = nombreProducto;
            PrecioProducto = precioProducto;
            Disponibilidad = disponibilidad;
        }

        public string obtenerDisponibilidad()
        {
            return Disponibilidad;
        }

        public void definirDisponibilidad(string disponibilidad)
        {
            Console.WriteLine("Se cambia el estado del producto.");
            this.Disponibilidad = disponibilidad;         
            NotificarObservadores();
        }

        public void AgregarObservador(IObservador observador)
        {
            Console.WriteLine("Cliente agregado: " + ((Observador)observador).NombreUsuario);
            observadores.Add(observador);
        }

        public void EliminarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores()
        {  
            foreach(IObservador observer in observadores)
            {
                observer.update(Disponibilidad);
            }
        }        
    }

}