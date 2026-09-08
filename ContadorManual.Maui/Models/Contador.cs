using System;
using System.Collections.Generic;
using System.Text;

namespace ContadorManual.Maui.Models
{
    public class Contador
    {
        // Variable de instancia
        private int _conteo;

        // Propiedad publica
        public int Conteo => _conteo;

        // Constructor
        public Contador() 
        {
            _conteo = 0;
        }

        public void Contar()
        {
            _conteo++;
        }

        public void Reiniciar()
        {
            _conteo = 0;
        }
    }
}
