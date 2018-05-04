using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaReservas.Models
{
    public class Reserva
    {
        [Key]
        public int ID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DataInicial { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DataFinal { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HoraInicial { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HoraFinal { get; set; }
        [Display(Name ="Usuario")]
        public int ID_Usuario { get; set; }

    }
}