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
    
    public partial class TCuentaAhorroPasarela
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TCuentaAhorroPasarela()
        {
            this.TTarjetaPasarela = new HashSet<TTarjetaPasarela>();
        }
    
        public string NroCuenta { get; set; }
        public string TipoDeCuenta { get; set; }
        public string Banco { get; set; }
        public Nullable<int> CodCliente { get; set; }
    
        public virtual TClientePasarela TClientePasarela { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTarjetaPasarela> TTarjetaPasarela { get; set; }
    }
}
