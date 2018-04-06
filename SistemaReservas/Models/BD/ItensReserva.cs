using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaReservas.Models
{
    public class ItensReserva
    {
        public int ID { get; set; }
        public int ID_Reserva { get; set; }
        public int ID_Recurso { get; set; }
    }
}