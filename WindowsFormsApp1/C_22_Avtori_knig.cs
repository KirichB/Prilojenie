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
    
    public partial class C_22_Avtori_knig
    {
        public int Kod_avtora_knigi { get; set; }
        public Nullable<int> Kod_avtora { get; set; }
        public Nullable<int> Kod_knigi { get; set; }
    
        public virtual C_22Knigi C_22Knigi { get; set; }
    }
}
