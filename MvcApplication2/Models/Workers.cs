//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Workers
    {
        public Workers()
        {
            this.Operation = new HashSet<Operation>();
            this.Orders = new HashSet<Orders>();
            this.webpages_Roles = new HashSet<webpages_Roles>();
        }
    
        public int IdWorker { get; set; }
        public string login { get; set; }
        public string fio { get; set; }
        public int workExp { get; set; }
        public int salary { get; set; }
    
        public virtual ICollection<Operation> Operation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}