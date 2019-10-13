using System;

namespace Prueba {
    
    public class Registro {
        /* clase para separar los tres componentes de cada entrada en el listín 
        * nombre|ciudad|telefono, en tres strings separadas.
        */
        private string Nombre, Ciudad, Numero;

        public Registro(string entrada) {
            string[] split = entrada.Split('|');
            Nombre = split[0];
            Ciudad = split[1];
            Numero = split[2];
        }

        override
        public string ToString() {
            return Nombre + "|" + Ciudad + "|" + Numero;
        }

        public string GetNombre() {
            return Nombre;
        }
        public string GetCiudad() {
            return Ciudad;
        }
        public string GetNumero() {
            return Numero;
        }
    }
}