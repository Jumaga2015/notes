using AM.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI
{
    //Agregar los campos que que tiene el formulario
    public class BusquedaInfo
    {
        public string Nombre { get; set; }
        public string Filtro { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public CriteriaIndex IndexCriteria { get; set; }
        public CriteriaSearch SearchCriteria { get; set; }
    }



    
}
