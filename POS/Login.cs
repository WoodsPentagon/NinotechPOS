//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Login()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanAddItem { get; set; }
        public bool CanEditItem { get; set; }
        public bool CanDeleteItem { get; set; }
        public bool CanAddProduct { get; set; }
        public bool CanEditProduct { get; set; }
        public bool CanDeleteProduct { get; set; }
        public bool CanAddSupplier { get; set; }
        public bool CanEditSupplier { get; set; }
        public bool CanDeleteSupplier { get; set; }
        public bool CanAddCustomer { get; set; }
        public bool CanStockIn { get; set; }
        public bool CanSellItem { get; set; }
        public bool CanAddUser { get; set; }
        public bool CanDeleteUser { get; set; }
        public bool CanVoidSale { get; set; }
        public bool CanEditInventory { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
