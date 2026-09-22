using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContadorManual.Maui.Models
{
    public class Contador : INotifyPropertyChanged
    {
        // Variable de instancia
        private int _conteo;

        // Variable que representara un metodo a una notificacion
        public event PropertyChangedEventHandler? PropertyChanged;

        // Propiedad publica
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

        // Constructor
        public Contador() 
        {
            Conteo = 0;
        }

        public void Contar()
        {
            Conteo++;   // Conteo = Contero + 1;
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
