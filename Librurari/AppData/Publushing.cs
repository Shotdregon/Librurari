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
    
    public partial class Publushing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publushing()
        {
            this.Book = new HashSet<Book>();
        }
    
        public int IdPublishing { get; set; }
        public string NamePublishing { get; set; }
        public int Countruy { get; set; }
        public Nullable<int> CIty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Book { get; set; }
        public virtual City City1 { get; set; }
        public virtual Countru Countru { get; set; }
    }
}