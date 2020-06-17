using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBSample.Models.DataModels
{
    public class Company : BaseEntity
    {
        [Key]
        public string CompanyCode { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public bool DownloadFlg { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
