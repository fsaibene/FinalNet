using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PuertoVaras.Models
{
    public enum TipoHabitacion
    {
        Simple,
        Doble,
        Matrimonial
    }
    public class Habitacion
    {
        [Key]
        public int ID_HABITACION { get; set; }
        public int NUMERO { get; set; }
        public bool DISPONIBLE { get; set; }
        public TipoHabitacion TIPO_HABITACION { get; set; }
        public int PRECIO { get; set; }
    }
}