using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    public class Reserva
    {
        private Localizacion TDestino;
        private Localizacion TOrigen;
        private DateTime dFecha;

        public Localizacion Destino
        {
            get
            {
                return TDestino;
            }
            set
            {
                TDestino = value;
            }
        }

        public Localizacion Origen
        {
            get
            {
                return TOrigen;
            }
            set
            {
                TOrigen = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return dFecha;
            }
            set
            {
                dFecha = value;
            }
        }

    }
}
