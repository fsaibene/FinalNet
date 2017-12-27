using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PuertoVaras.Models
{
    public enum TipoCliente
    {
        Habitual,
        Esporádico
    }
    public class Cliente
    {

        [Key]
        public int ID_CLIENTE { get; set; }
        [StringLength(20)]
        public string NOMBRE { get; set; }
        public TipoCliente TIPO_CLIENTE { get; set; }
    }
}