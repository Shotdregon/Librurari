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
    
    public partial class BookPikingBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookPikingBook()
        {
            this.ReturnBook = new HashSet<ReturnBook>();
        }
    
        public int Id { get; set; }
        public int IdBook { get; set; }
        public int IdBookPiking { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual BookPiking BookPiking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnBook> ReturnBook { get; set; }
    }
}