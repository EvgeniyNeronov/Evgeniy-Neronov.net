//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KosoyPerEntityDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class wp_kosoiwoocommerce_downloadable_product_permissions
    {
        public long permission_id { get; set; }
        public string download_id { get; set; }
        public long product_id { get; set; }
        public long order_id { get; set; }
        public string order_key { get; set; }
        public string user_email { get; set; }
        public Nullable<long> user_id { get; set; }
        public string downloads_remaining { get; set; }
        public System.DateTime access_granted { get; set; }
        public Nullable<System.DateTime> access_expires { get; set; }
        public long download_count { get; set; }
    }
}
