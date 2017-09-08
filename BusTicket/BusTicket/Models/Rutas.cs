using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    public class Rutas
    {

        public int ID { get; set; }
        public string Conductor { get; set; }
        public string Cia { get; set; }
        public Localizacion TerminalOrigen { get; set; }
        public Localizacion TerminalDestino { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public override string ToString()
        {
            //return $"Ruta: {Conductor}-{Cia}--{FechaInicio}/{FechaFin}";
            return $"Ruta: {TerminalOrigen.Ciudad} ({TerminalOrigen.Estacion}) - {TerminalDestino.Ciudad} ({TerminalDestino.Estacion}) / Salida: {FechaInicio} - Llegada: {FechaFin} / Conductor: {Conductor} - Compania: {Cia}";
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID, typeof(int));
            info.AddValue("Conductor", Conductor, typeof(string));
            info.AddValue("Cia", Cia, typeof(string));
            info.AddValue("TOrigen", TerminalOrigen, typeof(Localizacion));
            info.AddValue("TDestino", TerminalDestino, typeof(Localizacion));
            info.AddValue("FechaInicio", FechaInicio, typeof(DateTime));
            info.AddValue("FechaFin", FechaFin, typeof(DateTime));
        }
        public Rutas(SerializationInfo info, StreamingContext context)
        {
            ID = (int)info.GetValue("id", typeof(int));
            Conductor = (string)info.GetValue("Conductor", typeof(string));
            Cia = (string)info.GetValue("Cia", typeof(string));
            TerminalOrigen = (Localizacion)info.GetValue("TOrigen", typeof(Localizacion));
            TerminalDestino = (Localizacion)info.GetValue("TDestino", typeof(Localizacion));
            FechaInicio = (DateTime)info.GetValue("FechaInicio", typeof(DateTime));
            FechaFin = (DateTime)info.GetValue("FechaFin", typeof(DateTime));
        }
        public Rutas()
        {

        }
    }
}
