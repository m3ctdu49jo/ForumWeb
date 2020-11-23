﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForumWebsite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ForumWebsiteDBEntities : DbContext
    {
        public ForumWebsiteDBEntities()
            : base("name=ForumWebsiteDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<article_reply_Tb> article_reply_Tb { get; set; }
        public virtual DbSet<article_Tb> article_Tb { get; set; }
        public virtual DbSet<board_Tb> board_Tb { get; set; }
        public virtual DbSet<user_Tb> user_Tb { get; set; }
    
        public virtual ObjectResult<UpdateArticle_Result> UpdateArticle(Nullable<int> article_id)
        {
            var article_idParameter = article_id.HasValue ?
                new ObjectParameter("article_id", article_id) :
                new ObjectParameter("article_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateArticle_Result>("UpdateArticle", article_idParameter);
        }
    }
}
