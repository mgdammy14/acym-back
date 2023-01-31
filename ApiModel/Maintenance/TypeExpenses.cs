using System;
using Dapper.Contrib.Extensions;

namespace ApiModel.Maintenance
{
    public class TypeExpenses
    {
        [Key]
        public int idTypeExpenses { get; set; }
        public string nameTypeExpensese { get; set; }
        public string descriptionTypeExpenses { get; set; }
    }
}
