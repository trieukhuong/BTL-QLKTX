using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_QLKTX.Models
{
    [Table("Person")]
    public class Person
    {
        [key]
        public string PersonName { get; set; }
        public string PersonID { get; set; }
    }
}