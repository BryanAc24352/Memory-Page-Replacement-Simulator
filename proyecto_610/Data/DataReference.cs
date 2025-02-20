using proyecto_610.Referencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_610.Data
{
    public class DataReference
    {
        List<Referenciasmodel> lista = new List<Referenciasmodel>();


        public void GuardarReferencias(Referenciasmodel Data) {
            lista.Add(Data);
        }

        public List<Referenciasmodel> ConsultaReferencias (){
            return lista;
        }

        public void EliminarTodasReferencias(){
            lista.Clear();
        }
    }
}
