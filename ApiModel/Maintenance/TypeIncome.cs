using System;
using Dapper.Contrib.Extensions;

namespace ApiModel.Maintenance
{
    public class TypeIncome
    {
        [Key]
        public int idTypeIncome { get; set; }
        public string nameTypeIncome { get; set; }
        public string descriptionTypeIncome { get; set; }
    }
}
