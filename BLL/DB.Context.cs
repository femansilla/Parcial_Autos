﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int SP_Delete_Auto(Nullable<int> codeAuto)
        {
            var codeAutoParameter = codeAuto.HasValue ?
                new ObjectParameter("codeAuto", codeAuto) :
                new ObjectParameter("codeAuto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Auto", codeAutoParameter);
        }
    
        public virtual ObjectResult<SP_Get_All_Autos_Result> SP_Get_All_Autos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Autos_Result>("SP_Get_All_Autos");
        }
    
        public virtual ObjectResult<string> SP_validateUser(string user, string password)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_validateUser", userParameter, passwordParameter);
        }
    }
}
