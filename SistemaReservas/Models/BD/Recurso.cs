using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaReservas.Models
{
    public class Recurso
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Disponivel { get; set; }
        public int Quantidade { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int ID_Tipo { get; set; }
    }
}