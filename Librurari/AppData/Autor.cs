//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Librurari.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Autor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autor()
        {
            this.Book = new HashSet<Book>();
        }
    
        public int IdAutor { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronumic { get; set; }
        public Nullable<int> Countru { get; set; }
    
        public virtual Countru Countru1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Book { get; set; }
    }
}