using System;
using System.ComponentModel.DataAnnotations;

namespace DBSample.Models.DataModels
{
    public class BaseEntity
    {
        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        [Timestamp]
        public byte[] VersionNumber { get; set; }

    }
}
