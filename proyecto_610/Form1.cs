using proyecto_610.Data;
using proyecto_610.Referencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_610
{
    public partial class Home : Form
    {
        DataReference dato = new DataReference();
        Datamarcos data = new Datamarcos();
        DataTable TB1;
        int NumColsReferencias; // Número de columnas para referencias
        int totalFallosOptimo = 0;

        public Home()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            TB1 = new DataTable();
            TB1.Columns.Add("Marcos");

            // Agregar la fila inicial con el texto "Referencias"
            DataRow referenciaRow = TB1.NewRow();
            referenciaRow["Marcos"] = "Referencias";
            TB1.Rows.Add(referenciaRow);

            // Agregar una fila vacía antes de los marcos
            TB1.Rows.Add(TB1.NewRow());

            Tabla1.DataSource = TB1;
        }

        private void SetNumColsReferencias()
        {
            NumColsReferencias = int.Parse(TxtNumColsReferencias.Text);

            // Limpiar las columnas de referencias actuales
            for (int i = TB1.Columns.Count - 1; i > 0; i--)
            {
                TB1.Columns.RemoveAt(i);
            }

            // Agregar nuevas columnas de referencias según el valor del TextBox
            for (int i = 1; i <= NumColsReferencias; i++)
            {
                TB1.Columns.Add($"Referencia {i}");
            }

            // Actualizar DataGridView
            Tabla1.DataSource = TB1;
            Tabla1.Refresh();
        }

        // Guardar referencias
        private void GuardarReferences()
        {
            Referenciasmodel modelo = new Referenciasmodel()
            {
                reference = int.Parse(TxtReferencia.Text),
            };
            dato.GuardarReferencias(modelo);
        }

        // Columnas de las referencias
        private void ShowtablaReferencias()
        {
            // Obtener las referencias
            List<Referenciasmodel> referencias = dato.ConsultaReferencias();
            int numFilas = (int)Math.Ceiling((double)referencias.Count / NumColsReferencias);

            // Asegurarse de que haya suficientes filas
            while (TB1.Rows.Count < numFilas + 2) // +2 para las filas de "Referencias" y la fila vacía
            {
                TB1.Rows.Add(TB1.NewRow());
            }

            // Agregar las referencias en las filas existentes
            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < NumColsReferencias; j++)
                {
                    int index = i * NumColsReferencias + j;
                    if (index < referencias.Count)
                    {
                        TB1.Rows[i][$"Referencia {j + 1}"] = referencias[index].reference; // +2 para ajustar las filas adicionales
                    }
                }
            }

            // Actualizar DataGridView
            Tabla1.DataSource = TB1;
            Tabla1.Refresh();
        }

        // Columnas de los marcos
        private void ShowtablaMarco(int cantidadMarcos)
        {
            // Asegurarse de que haya suficientes filas
            while (TB1.Rows.Count < cantidadMarcos + 1) // +2 para las filas de "Referencias" y la fila vacía
            {
                TB1.Rows.Add(TB1.NewRow());
            }

            // Asignar valores a las filas empezando desde la fila 1
            for (int i = 0; i < cantidadMarcos; i++)
            {
                TB1.Rows[i + 1]["Marcos"] = i + 1; // Agregar 1 al número de marco para comenzar desde 1
            }

            // Actualizar DataGridView
            Tabla1.DataSource = TB1;
            Tabla1.Refresh();
        }

        // Guardar los marcos
        private void GuardarMarcos(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                marcosmodel modelo = new marcosmodel()
                {
                    marco = i, // Asignar el número de marco empezando desde 0
                };
                data.Guardarmarcos(modelo);
            }
            ShowtablaMarco(cantidad);
        }

        private void Tabla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Darle función a los radio buttons de los algoritmos
        private void Algoritmos()
        {
            if (R2OP.Checked == true)
            {
                AlgoritmoSegundaOportunidad();
                MessageBox.Show("Eligió el algoritmo de Segunda Oportunidad");
            }
            if (RFIFO.Checked == true)
            {
                AlgoritmoFIFO();
                MessageBox.Show("Eligió el algoritmo de FIFO");
            }
            if (RNRU.Checked == true)
            {
                AlgoritmoNRU();
                MessageBox.Show("Eligió el algoritmo de NRU");
            }
            if (ROPTIMO.Checked == true)
            {
                AlgoritmoOptimo();
                MessageBox.Show("Eligió el algoritmo de OPTIMO");
            }
            if (RRJ.Checked == true)
            {
                AlgoritmoReloj();
                MessageBox.Show("Eligió el algoritmo de Reloj");
            }
        }

        // Botón de referencias
        private void BFerences_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarReferences();
                TxtReferencia.Text = "";
                ShowtablaReferencias();
            }
            catch (Exception B)
            {
                MessageBox.Show("Debe ingresar un numero entero");
            }
        }

        // Botón de marcos
        private void BMarcos_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadMarcos = int.Parse(TxtMarco.Text);
                GuardarMarcos(cantidadMarcos);
                TxtMarco.Text = "";
            }
            catch (Exception V)
            {
                MessageBox.Show("Debe ingresar un numero entero");
            }
        }

        // Botón de configurar número de columnas de referencias
        private void BSetNumColsReferencias_Click(object sender, EventArgs e)
        {
            try
            {
                SetNumColsReferencias();
                BSetNumColsReferencias.Enabled = false;
                TxtNumColsReferencias.Text = "inhabilitado";
            }
            catch (Exception B)
            {
                MessageBox.Show("Debe ingresar un numero entero");
            }
        }

        // Botón de ejecutar los algoritmos
        private void button1_Click(object sender, EventArgs e)
        {
            Algoritmos();
        }

        private void ActualizarMarcos(int[] marcos, int referenciaIndex)
        {
            for (int i = 1; i <= marcos.Length; i++)
            {
                TB1.Rows[i][$"Referencia {referenciaIndex + 1}"] = marcos[i - 1] == -1 ? string.Empty : marcos[i - 1].ToString();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < TB1.Rows.Count; i++) // Empezamos desde 1 para omitir la fila de "Referencias"
            {
                for (int j = 1; j < TB1.Columns.Count; j++) // Empezamos desde 1 para omitir la columna "Marcos"
                {
                    TB1.Rows[i][j] = DBNull.Value; // Borra el contenido de las celdas de referencia
                }
            }

            // Eliminar la fila de fallos si existe
            EliminarFilaFallos();

            // Actualiza la visualización del DataGridView
            Tabla1.Refresh();
        }

        private void EliminarFilaFallos()
        {
            foreach (DataRow row in TB1.Rows)
            {
                if (row["Marcos"].ToString() == "Fallos")
                {
                    TB1.Rows.Remove(row);
                    break;
                }
            }
        }

        private void Bupdate_Click(object sender, EventArgs e)
        {

            //ShowtablaMarco();
        }

        // Limpia la tabla pero no las referencias ni los marcos.
        private void LimpiarTodo()
        {
            // Resetear referencias
            TxtReferencia.Text = "";
            TxtMarco.Text = "";
            TxtNumColsReferencias.Text = "";

            // Limpiar filas y columnas de la tabla
            TB1.Clear();
            while (TB1.Columns.Count > 1)
            {
                TB1.Columns.RemoveAt(1);
            }

            // Reiniciar con la estructura inicial
            Inicio();

            // Resetear los datos de referencias y marcos
            dato.EliminarTodasReferencias();
            data.EliminarTodosMarcos();

            // Actualizar el DataGridView
            Tabla1.DataSource = TB1;
            Tabla1.Refresh();
        }

        // Limpia tanto marcos como referencias y la lista de referencias.
        private void clearAll_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            BSetNumColsReferencias.Enabled = true;
        }

        // Algoritmo Reloj
        private void AlgoritmoReloj()
        {
            List<Referenciasmodel> referencias = dato.ConsultaReferencias();
            int numMarcos = TB1.Rows.Count - 1;
            int[] marcos = new int[numMarcos];
            bool[] bitUso = new bool[numMarcos];
            int puntero = 0;
            int fallos = 0;
            List<bool> fallosLista = new List<bool>();

            // Inicializar los marcos con -1 para indicar que están vacíos
            for (int i = 0; i < numMarcos; i++)
            {
                marcos[i] = -1;
                bitUso[i] = false;
            }

            // Crear columnas para cada referencia
            for (int i = 1; i <= referencias.Count; i++)
            {
                if (!TB1.Columns.Contains($"Referencia {i}"))
                {
                    TB1.Columns.Add($"Referencia {i}");
                }
            }

            // Procesar cada referencia
            for (int paso = 0; paso < referencias.Count; paso++)
            {
                int referenciaActual = referencias[paso].reference;
                bool encontrado = false;

                // Verificar si la referencia ya está en algún marco
                for (int i = 0; i < numMarcos; i++)
                {
                    if (marcos[i] == referenciaActual)
                    {
                        bitUso[i] = true;
                        encontrado = true;
                        fallosLista.Add(false);
                        break;
                    }
                }

                if (!encontrado)
                {
                    fallos++;
                    fallosLista.Add(true);
                    while (bitUso[puntero])
                    {
                        bitUso[puntero] = false;
                        puntero = (puntero + 1) % numMarcos;
                    }
                    marcos[puntero] = referenciaActual;
                    bitUso[puntero] = true;
                    puntero = (puntero + 1) % numMarcos;
                }
                // Calcular el rendimiento hasta este punto
                double Fallos = (double)fallos / NumColsReferencias;
                double rendimiento = 1 - Fallos;
                textRendimiento.Text = rendimiento.ToString();
                // Actualizar la visualización de los marcos en el DataGridView
                ActualizarMarcos(marcos, paso); // paso para ajustarse a la columna de referencias
            }

            // Agregar la fila de fallos al final
            AgregarFilaFallos(fallosLista);

            // Actualizar DataGridView
            Tabla1.Refresh();
            MessageBox.Show("El puntero de reloj quedo en la posicion:" + puntero);
        }

        // Método para agregar la fila de fallos al final de la tabla
        private void AgregarFilaFallos(List<bool> fallosLista)
        {
            EliminarFilaFallos(); // Eliminar fila de fallos existente antes de agregar una nueva
            DataRow fallosRow = TB1.NewRow();
            fallosRow["Marcos"] = "Fallos";
            for (int i = 0; i < fallosLista.Count; i++)
            {
                fallosRow[$"Referencia {i + 1}"] = fallosLista[i] ? "X" : "-";
            }
            TB1.Rows.Add(fallosRow);
        }

        // Algoritmo FIFO
        private void AlgoritmoFIFO()
        {
            List<Referenciasmodel> referencias = dato.ConsultaReferencias();
            int numMarcos = TB1.Rows.Count - 1; // Excluir la fila de "Referencias"
            int[] marcos = new int[numMarcos];
            Queue<int> fifoQueue = new Queue<int>();
            int fallos = 0;
            List<bool> fallosLista = new List<bool>();

            // Inicializar los marcos con -1 para indicar que están vacíos
            for (int i = 0; i < numMarcos; i++)
            {
                marcos[i] = -1;
            }

            // Crear columnas para cada referencia
            for (int i = 1; i <= referencias.Count; i++)
            {
                if (!TB1.Columns.Contains($"Referencia {i}"))
                {
                    TB1.Columns.Add($"Referencia {i}");
                }
            }

            // Procesar cada referencia
            for (int paso = 0; paso < referencias.Count; paso++)
            {
                int referenciaActual = referencias[paso].reference;

                // Verificar si la referencia ya está en algún marco
                bool encontrado = false;
                for (int i = 0; i < numMarcos; i++)
                {
                    if (marcos[i] == referenciaActual)
                    {
                        encontrado = true;
                        fallosLista.Add(false);
                        break;
                    }
                }

                // Si la referencia no está en ningún marco
                if (!encontrado)
                {
                    fallos++;
                    fallosLista.Add(true);
                    if (fifoQueue.Count < numMarcos)
                    {
                        // Aún hay espacio en los marcos
                        int index = fifoQueue.Count;
                        marcos[index] = referenciaActual;
                        fifoQueue.Enqueue(index);
                    }
                    else
                    {
                        // Reemplazar el marco según FIFO
                        int indexReemplazo = fifoQueue.Dequeue();
                        marcos[indexReemplazo] = referenciaActual;
                        fifoQueue.Enqueue(indexReemplazo);
                    }
                }
                // Calcular el rendimiento hasta este punto
                double Fallos = (double)fallos / NumColsReferencias;
                double rendimiento = 1 - Fallos;
                textRendimiento.Text = rendimiento.ToString();
                // Actualizar la visualización de los marcos en el DataGridView
                ActualizarMarcos(marcos, paso); // paso para ajustarse a la columna de referencias
            }

            // Agregar la fila de fallos al final
            AgregarFilaFallos(fallosLista);

            // Actualizar DataGridView
            Tabla1.Refresh();
        }

        // Algoritmo de óptimo
        private void AlgoritmoOptimo()
        {
            // Obtener las referencias y los marcos
            List<Referenciasmodel> referencias = dato.ConsultaReferencias();
            int numMarcos = TB1.Rows.Count - 1; // -1 para excluir solo la fila de "Referencias"
            int[] marcos = new int[numMarcos];
            int fallos = 0;
            List<bool> fallosLista = new List<bool>();

            // Inicializar los marcos con -1 para indicar que están vacíos
            for (int i = 0; i < marcos.Length; i++)
            {
                marcos[i] = -1;
            }

            // Crear columnas para cada referencia
            for (int i = 1; i <= referencias.Count; i++)
            {
                if (!TB1.Columns.Contains($"Referencia {i}"))
                {
                    TB1.Columns.Add($"Referencia {i}");
                }
            }

            // Procesar cada referencia
            for (int paso = 0; paso < referencias.Count; paso++)
            {
                int referenciaActual = referencias[paso].reference;

                // Verificar si la referencia ya está en algún marco
                bool estaEnMarco = false;
                for (int i = 0; i < marcos.Length; i++)
                {
                    if (marcos[i] == referenciaActual)
                    {
                        estaEnMarco = true;
                        fallosLista.Add(false);
                        break;
                    }
                }

                // Si la referencia no está en ningún marco, buscar el reemplazo óptimo
                if (!estaEnMarco)
                {
                    fallos++;
                    fallosLista.Add(true);
                    int indexReemplazo = -1;
                    int maxDistancia = -1;

                    for (int i = 0; i < marcos.Length; i++)
                    {
                        if (marcos[i] == -1)
                        {
                            indexReemplazo = i;
                            break;
                        }

                        int distancia = int.MaxValue;
                        for (int j = paso + 1; j < referencias.Count; j++)
                        {
                            if (referencias[j].reference == marcos[i])
                            {
                                distancia = j - paso;
                                break;
                            }
                        }

                        if (distancia > maxDistancia)
                        {
                            maxDistancia = distancia;
                            indexReemplazo = i;
                        }
                    }

                    marcos[indexReemplazo] = referenciaActual;
                }
                // Calcular el rendimiento hasta este punto
                double Fallos = (double)fallos / NumColsReferencias;
                double rendimiento = 1 - Fallos;
                textRendimiento.Text = rendimiento.ToString();

                // Actualizar la visualización de los marcos en el DataGridView
                ActualizarMarcos(marcos, paso); // paso para ajustarse a la columna de referencias
            }

            // Agregar la fila de fallos al final
            AgregarFilaFallos(fallosLista);

            // Actualizar DataGridView
            Tabla1.Refresh();
        }

        // Algoritmo de Segunda Oportunidad
        private void AlgoritmoSegundaOportunidad()
        {
            List<Referenciasmodel> referencias = dato.ConsultaReferencias();
            int numMarcos = TB1.Rows.Count - 1;
            int[] marcos = new int[numMarcos];
            int[] bitsReferencia = new int[numMarcos]; // Array para almacenar los bits de referencia
            int puntero = 0;
            int fallos = 0;
            List<bool> fallosLista = new List<bool>();

            // Inicializar los marcos con -1 para indicar que están vacíos y los bits de referencia en 0
            for (int i = 0; i < numMarcos; i++)
            {
                marcos[i] = -1;
                bitsReferencia[i] = 0;
            }

            // Crear columnas para cada referencia
            for (int i = 1; i <= referencias.Count; i++)
            {
                if (!TB1.Columns.Contains($"Referencia {i}"))
                {
                    TB1.Columns.Add($"Referencia {i}");
                }
            }

            // Procesar cada referencia
            for (int paso = 0; paso < referencias.Count; paso++)
            {
                int referenciaActual = referencias[paso].reference;
                bool encontrado = false;

                // Verificar si la referencia ya está en algún marco
                for (int i = 0; i < numMarcos; i++)
                {
                    if (marcos[i] == referenciaActual)
                    {
                        encontrado = true;
                        fallosLista.Add(false);
                        bitsReferencia[i]++; // Incrementar el bit de referencia para esta página en este marco
                        break;
                    }
                }

                if (!encontrado)
                {
                    fallos++;
                    fallosLista.Add(true);

                    while (true)
                    {
                        // Si el marco actualmente apuntado por el puntero está vacío, asignar la nueva página
                        if (marcos[puntero] == -1)
                        {
                            marcos[puntero] = referenciaActual;
                            bitsReferencia[puntero] = 0; // Reiniciar el bit de referencia a 0
                            puntero = (puntero + 1) % numMarcos;
                            break;
                        }
                        else if (bitsReferencia[puntero] == 0)
                        {
                            // Si el bit de referencia es 0, reemplazar la página en este marco
                            marcos[puntero] = referenciaActual;
                            bitsReferencia[puntero] = 0; // Reiniciar el bit de referencia a 0
                            puntero = (puntero + 1) % numMarcos;
                            break;
                        }
                        else
                        {
                            // Si el bit de referencia es 1, darle una segunda oportunidad y continuar con el siguiente marco
                            bitsReferencia[puntero] = 0; // Reiniciar el bit de referencia a 0
                            puntero = (puntero + 1) % numMarcos;
                        }
                    }
                }

                // Calcular el rendimiento hasta este punto
                double fallosRatio = (double)fallos / referencias.Count;
                double rendimiento = 1 - fallosRatio;
                textRendimiento.Text = rendimiento.ToString();

                // Actualizar la visualización de los marcos en el DataGridView
                ActualizarMarcos(marcos, paso);
            }

            // Agregar la fila de fallos al final
            AgregarFilaFallos(fallosLista);

            // Actualizar DataGridView
            Tabla1.Refresh();
        }
        // Algoritmo NRU
        private void AlgoritmoNRU()
        {
            List<Referenciasmodel> referencias = dato.ConsultaReferencias();
            int numMarcos = TB1.Rows.Count - 1;
            int[] marcos = new int[numMarcos];
            bool[] bitUso = new bool[numMarcos];
            bool[] bitModificado = new bool[numMarcos];
            int[] ultimoUso = new int[numMarcos]; // Para llevar un seguimiento del último uso
            int fallos = 0;
            List<bool> fallosLista = new List<bool>();

            // Inicializar los marcos con -1 para indicar que están vacíos
            for (int i = 0; i < numMarcos; i++)
            {
                marcos[i] = -1;
                bitUso[i] = false;
                bitModificado[i] = false;
                ultimoUso[i] = -1; // Inicializamos con -1 indicando que no han sido usados aún
            }

            // Crear columnas para cada referencia
            for (int i = 1; i <= referencias.Count; i++)
            {
                if (!TB1.Columns.Contains($"Referencia {i}"))
                {
                    TB1.Columns.Add($"Referencia {i}");
                }
            }

            // Procesar cada referencia
            for (int paso = 0; paso < referencias.Count; paso++)
            {
                int referenciaActual = referencias[paso].reference;
                bool encontrado = false;

                // Verificar si la referencia ya está en algún marco
                for (int i = 0; i < numMarcos; i++)
                {
                    if (marcos[i] == referenciaActual)
                    {
                        bitUso[i] = true;
                        bitModificado[i] = true; // Se marca como modificado porque está siendo referenciado
                        ultimoUso[i] = paso; // Actualizamos el último uso
                        encontrado = true;
                        fallosLista.Add(false);
                        break;
                    }
                }

                if (!encontrado)
                {
                    fallos++;
                    fallosLista.Add(true);

                    // Determinar el marco a reemplazar
                    int indexReemplazo = -1;
                    int tiempoUltimoUso = int.MaxValue;

                    // Verificar en las referencias previas (fila de referencias)
                    for (int i = 0; i < numMarcos; i++)
                    {
                        if (marcos[i] != -1)
                        {
                            bool usadoRecientemente = false;

                            // Verificar si el marco actual fue usado en las referencias anteriores
                            for (int j = paso - 1; j >= 0; j--)
                            {
                                if (referencias[j].reference == marcos[i])
                                {
                                    usadoRecientemente = true;
                                    break; // Romper el bucle si se encuentra que fue usado recientemente
                                }
                            }

                            if (!usadoRecientemente && ultimoUso[i] < tiempoUltimoUso)
                            {
                                indexReemplazo = i;
                                tiempoUltimoUso = ultimoUso[i];
                            }
                        }
                    }

                    // Si no se encontró una página no usada recientemente, seleccionar la menos recientemente usada
                    if (indexReemplazo == -1)
                    {
                        for (int i = 0; i < numMarcos; i++)
                        {
                            if (ultimoUso[i] < tiempoUltimoUso)
                            {
                                indexReemplazo = i;
                                tiempoUltimoUso = ultimoUso[i];
                            }
                        }
                    }

                    // Reemplazar la página seleccionada
                    marcos[indexReemplazo] = referenciaActual;
                    bitUso[indexReemplazo] = true;
                    bitModificado[indexReemplazo] = false; // Resetear el bit de modificación para la nueva página
                    ultimoUso[indexReemplazo] = paso; // Actualizamos el último uso
                }

                // Calcular el rendimiento hasta este punto
                double Fallos = (double)fallos / NumColsReferencias;
                double rendimiento = 1 - Fallos;
                textRendimiento.Text = rendimiento.ToString();

                // Actualizar la visualización de los marcos en el DataGridView
                ActualizarMarcos(marcos, paso); // paso para ajustarse a la columna de referencias
            }

            // Agregar la fila de fallos al final
            AgregarFilaFallos(fallosLista);

            // Actualizar DataGridView
            Tabla1.Refresh();
        }
    }
}