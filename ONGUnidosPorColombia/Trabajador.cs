using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONGUnidosPorColombia
{
    class Trabajador
    {
        public string Nombre_Trabajador { get; set; }
        public string Nombre_Empresa { get; set; }
        public int Total_Hijos { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TotalAuxilio { get; set; }
        

        public decimal calcular(decimal TotalAuxilio1)
        {
            this.TotalAuxilio = TotalAuxilio1;
            TotalAuxilio1 = 0;
            return (TotalAuxilio1 = Total_Hijos * 120000);
        }

    }
}
