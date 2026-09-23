using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContadorManual.Maui.Models
{
    public class Contador : INotifyPropertyChanged
    {
        // Variables de instancia
        private int _conteo;
        private int _incremento;

        // Variable que representara un metodo a una notificacion
        public event PropertyChangedEventHandler? PropertyChanged; // Delegado que guarda un metodo

        // Propiedades publicas
        public int Conteo
        {
            // Propiedad de lectura
            get => _conteo;
            // Propiedad de escritura
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }

        public int Incremento
        {
            get => _incremento;

            set
            {
                if (_incremento != value)
                {
                    _incremento = value;
                }
            }
        }

        // Constructor
        public Contador(int valorIncial = 0, int incremento = 1) 
        {
            Conteo = valorIncial;
            Incremento = incremento;
        }

        public void Contar()
        {
            Conteo = Conteo + Incremento;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }

        // Aqui vamos a invocar el metodo de PropertyChanged
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(
                    this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

// Todo esto nos permite separa la interfaz de usuario del manejo de los objetos