//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prestamos
    {
        public int IdPrestamo { get; set; }
        public Nullable<int> IdLibro { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<System.DateTime> FecPrestamo { get; set; }
        public Nullable<System.DateTime> FecDevolucion { get; set; }
    
        public virtual Libro Libro { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}