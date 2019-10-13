using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prueba {
    public partial class Form1 : Form {
        //contiene las strings (lineas) del fichero sin modificar
        string[] LineasEnBruto;
        //contiene las strings en formato "nombre|ciudad|numero" en minusculas (para busqueda no-key-sensitive)
        string[] Lineas;
        //contiene las strings (en minusculas) separadas en tres partes
        Registro[] LineasSeparadas;

        //inicializar la interfaz
        public Form1() {
            InitializeComponent();
        }

        //handler para abrir y procesar el fichero con los registros
        private void BtnAbrir_Click(object sender, EventArgs e) {
            //mostrar el popup para seleccionar el fichero y seguir cuando el usuario acepte (OK)
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                LblFichero.Text = "Fichero cargado";
                //cargar todos los registros ("nombre|ciudad|numero") del fichero en memoria para agilizar las consultas
                LineasEnBruto = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                //Preparar las arrays que se usan en las busquedas
                Lineas = (String[])LineasEnBruto.Clone();
                LineasSeparadas = new Registro[Lineas.Length];
                for (int i = 0; i < Lineas.Length; i++) {
                    //pasar las letras a minusculas para hacer las busquedas no-case-sensitive
                    Lineas[i] = Lineas[i].ToLower();
                    //generar y guardar el registro (separar los componentes de la string)
                    LineasSeparadas[i] = new Registro(Lineas[i]);
                }
            }
        }

        /*handler del botón para llamar a listar(texto). Se encarga de realizar la llamada
         * e imprimir los resultados por pantalla
         */
        private void BtnListar_Click(object sender, EventArgs e) {
            //pasar el texto a minusculas (para hacer la busqueda no-case-sensitive), llamar a la función y guardar los resultados.
            List<string> resultados = Listar(TBTexto.Text.ToLower());
            
            if (resultados == null) {
                TBResultados.Text = "Error. No se ha seleccionado fichero con los datos";
                return;
            }

            //limpiar el area de texto de posibles resultados anteriores
            TBResultados.Clear();
            //iterar sobre el listado de resultados para imprimirlos por pantalla
            List<String>.Enumerator iterador = resultados.GetEnumerator();
            while (iterador.MoveNext()) {
                TBResultados.AppendText(iterador.Current + Environment.NewLine);
            }

        }

        /*handler del botón para llamar a buscar(texto,ciudad). Se encarga de realizar la llamada
         * e imprimir los resultados por pantalla
         */
        private void BtnBuscar_Click(object sender, EventArgs e) {
            //pasar el texto a minusculas (para hacer la busqueda no-case-sensitive), llamar a la función y guardar los resultados.
            List<string> resultados = Buscar(TBTexto.Text.ToLower(), TBCiudad.Text.ToLower());

            if (resultados == null) {
                TBResultados.Text = "Error. No se ha seleccionado fichero con los datos";
                return;
            }

            //limpiar el area de texto de posibles resultados anteriores
            TBResultados.Clear();
            //iterar sobre el listado de resultados para imprimirlos por pantalla
            List<String>.Enumerator iterador = resultados.GetEnumerator();
            while (iterador.MoveNext()) {
                TBResultados.AppendText(iterador.Current + Environment.NewLine);
            }
        }



        /*Listar(texto). Dada una string de texto, recorre linealmente las strings del fichero buscando 
         * coincidencias (string.contains) y devuelve una lista de strings con los resultados. En este 
         * caso se utiliza la array Lineas, que contiene las strings sin trocear, ya que utilizando la 
         * de Registros es necesario hacer dos comprobaciones, nombre.contains y ciudad.contains, con lo 
         * que tarda más (en una batería de pruebas de 100 consultas, tarda alrededor de 2 segundos mas, 
         * pasando de 3,5 segundos a 5,6)
         */
        private List<string> Listar(string texto) {
            //comprobar si se ha abierto un fichero y abortar si no es el caso.
            if (Lineas == null) {
                TBResultados.Text = "Error. No se ha seleccionado fichero con los datos";
                return null;
            }

            List<string> resultados = new List<string>();
            //recorrer el fichero de arriba a abajo comprobando contra el nombre o ciudad 
            for (int i = 0; i < Lineas.Length; i++) {
                //si se encuentra una coincidencia, añadirla a la lista con los resultados a devolver
                if (Lineas[i].Contains(texto)) {
                    resultados.Add(LineasEnBruto[i]);
                }
            }
            //devolver los resultados (si no hay coincidencias la lista estará vacía)
            return resultados;
        }


        /*buscar(texto,ciudad). Dada una string de texto y una string con la ciudad, recorre linealmente
         * el fichero, buscando coincidencias de ambos parametros en sus respectivos componentes del 
         * registro, y devuelve una lista de strings con los resultados. En este caso se usa la array 
         * LineasSeparadas para poder comparar cada parámetro únicamente con su componente correspondiente 
         * (p.e. si se introduce ciudad="ba" que no dé positivo al encontrar el nombre "barry"), y porque 
         * en una batería de pruebas de 100 consultas se tarda medio segundo menos que si se usasen las 
         * string sin trocear.
         */
        private List<string> Buscar(string texto, string ciudad) {
            //comprobar si se ha abierto un fichero y abortar si no es el caso.
            if (LineasSeparadas == null) {
                TBResultados.Text = "Error. No se ha seleccionado fichero con los datos";
                return null;
            }
            List<string> resultados = new List<string>();
            //recorrer el fichero de arriba a abajo comprobando contra el nombre y ciudad 
            for (int i = 0; i < LineasSeparadas.Length; i++) {
                //si se encuentra una coincidencia, añadirla a la lista con los resultados a devolver
                if (LineasSeparadas[i].GetCiudad().Contains(ciudad) &&
                    LineasSeparadas[i].GetNombre().Contains(texto)) {
                    resultados.Add(LineasEnBruto[i]);
                }
            }
            //devolver los resultados (si no hay coincidencias la lista estará vacía)
            return resultados;
        }
    }
}
