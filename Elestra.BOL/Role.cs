﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elestra.BOL
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
