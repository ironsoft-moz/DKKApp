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
    
    public partial class tbl_EducationLevels
    {
        public int EducationLevelID { get; set; }
        public string EducationLevelName { get; set; }
        public Nullable<int> DocumentTypeFrom { get; set; }
        public Nullable<int> DocumentTypeTo { get; set; }
        public Nullable<int> UVZFrom { get; set; }
        public Nullable<int> UVZTo { get; set; }
    }
}
