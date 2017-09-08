using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    public class Localizacion
    {
        public int ID { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Estacion { get; set; }

        public override string ToString()
        {
            return $"{Estacion} - {Ciudad}, {Estado}, {Pais}";
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID, typeof(int));
            info.AddValue("Estado", Estado, typeof(string));
            info.AddValue("Ciudad", Ciudad, typeof(string));
            info.AddValue("Pais", Pais, typeof(string));
            info.AddValue("Estacion", Estacion, typeof(string));
        }
        public Localizacion(SerializationInfo info, StreamingContext context)
        {
            ID = (int)info.GetValue("ID", typeof(int));
            Estado = (string)info.GetValue("Estado", typeof(string));
            Ciudad = (string)info.GetValue("Ciudad", typeof(string));
            Pais = (string)info.GetValue("Pais", typeof(string));
            Estacion = (string)info.GetValue("Estacion", typeof(string));
        }

        public Localizacion()
        {

        }
    }
}
