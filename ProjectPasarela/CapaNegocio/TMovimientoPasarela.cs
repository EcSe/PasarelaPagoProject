//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaNegocio
{
    using System;
    using System.Collections.Generic;
    
    public partial class TMovimientoPasarela
    {
        public int RegistroMovimiento { get; set; }
        public Nullable<System.DateTime> FechaMovimiento { get; set; }
        public Nullable<decimal> MontoRetiro { get; set; }
        public Nullable<decimal> SaldoDisponible { get; set; }
        public string NroTarjeta { get; set; }
        public string Activo { get; set; }
    
        public virtual TTarjetaPasarela TTarjetaPasarela { get; set; }
    }
}
