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
    
    public partial class C_20Nomer_P
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_20Nomer_P()
        {
            this.C_20Raspisanie = new HashSet<C_20Raspisanie>();
        }
    
        public int Id_Nomer_pari { get; set; }
        public Nullable<int> Nomer { get; set; }
    
        public virtual C_20Nomer_P C_20Nomer_P1 { get; set; }
        public virtual C_20Nomer_P C_20Nomer_P2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_20Raspisanie> C_20Raspisanie { get; set; }
    }
}