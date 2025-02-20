using proyecto_610.Referencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_610.Data
{
    public class Datamarcos{

        List<marcosmodel> lista = new List<marcosmodel>();


        public void Guardarmarcos(marcosmodel Data)
        {
            lista.Add(Data);
        }

        public List<marcosmodel> ConsultaMarcos()
        {
            return lista;
        }

        public void EliminarTodosMarcos(){
            lista.Clear();
        }
    }
}
