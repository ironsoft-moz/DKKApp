//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DKKApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Curators
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Curators()
        {
            this.tbl_Schools = new HashSet<tbl_Schools>();
        }
    
        public int CuratorID { get; set; }
        public string CuratorName { get; set; }
        public string CuratorShortName { get; set; }
        public string Curator { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Schools> tbl_Schools { get; set; }
    }
}