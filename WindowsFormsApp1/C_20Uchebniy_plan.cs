//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_20Uchebniy_plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_20Uchebniy_plan()
        {
            this.C_20Predmeti = new HashSet<C_20Predmeti>();
        }
    
        public int Id_Uchebniy_plan { get; set; }
        public Nullable<int> Kol_chasov_dlya_likciy { get; set; }
        public Nullable<int> Kol_chasov_dlya_prakticheskih { get; set; }
        public string Zachet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_20Predmeti> C_20Predmeti { get; set; }
    }
}