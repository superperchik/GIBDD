//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GIBDD_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Cars = new HashSet<Car>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string middlename { get; set; }
        public string fathersname { get; set; }
        public string passportserial { get; set; }
        public string passportnumber { get; set; }
        public Nullable<int> postcode { get; set; }
        public string address { get; set; }
        public string addresslife { get; set; }
        public string company { get; set; }
        public string jobname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
