//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sexo
    {
        public Sexo()
        {
            this.Cliente = new HashSet<Cliente>();
        }
    
        public int IdSexo { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
