//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlegDiplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupCars
    {
        public int Id { get; set; }
        public Nullable<int> GroupId { get; set; }
        public Nullable<int> CarId { get; set; }
    
        public virtual Groups Groups { get; set; }
        public virtual Cars Cars { get; set; }
    }
}