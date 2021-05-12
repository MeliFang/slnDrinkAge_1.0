//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrinkAge_1._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.FavoriteProducts = new HashSet<FavoriteProduct>();
            this.FavoriteStores = new HashSet<FavoriteStore>();
            this.MemberACHVs = new HashSet<MemberACHV>();
            this.MemPointDetails = new HashSet<MemPointDetail>();
            this.Orders = new HashSet<Order>();
            this.CommentDetails = new HashSet<CommentDetail>();
        }
    
        public int MemberID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public byte[] MemberPIC { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Birth { get; set; }
        public string Phone { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> Exp { get; set; }
        public Nullable<int> Point { get; set; }
        public Nullable<int> ACHVID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriteProduct> FavoriteProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriteStore> FavoriteStores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberACHV> MemberACHVs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemPointDetail> MemPointDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentDetail> CommentDetails { get; set; }
    }
}
