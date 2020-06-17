using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBSample.Models.DataModels
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string LoginId { get; set; }

        [Required]
        public string Password { get; set; }

        public string CompanyCode { get; set; }

        [ForeignKey("CompanyCode")]
        public Company Company { get; set; }
    }
}
