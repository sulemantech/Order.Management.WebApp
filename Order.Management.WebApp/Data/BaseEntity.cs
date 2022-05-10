using System;
using System.ComponentModel.DataAnnotations;

namespace Order.Management.WebApp.Data
{
    public class BaseEntity
    {
        public System.Int64 Id
        {
            get;
            set;
        }
        public DateTime AddedDate
        {
            get;
            set;
        }
        public DateTime UpdatedDate
        {
            get;
            set;
        }
    }
}
