using DBSample.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSample.Models
{
    public static class DBInitializer
    {
        public static void Initialize(SampleContext context)
        {
            context.Database.EnsureCreated();

            if (context.Companies.Any()) return;

            var companies = new Company[]
            {
                new Company{ CompanyCode = "AB", CompanyName = "会社A", DownloadFlg = true, CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Company{ CompanyCode = "CD", CompanyName = "会社B", DownloadFlg = true, CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Company{ CompanyCode = "EF", CompanyName = "会社C", DownloadFlg = true, CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Company{ CompanyCode = "GH", CompanyName = "会社D", DownloadFlg = true, CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Company{ CompanyCode = "IJ", CompanyName = "会社E", DownloadFlg = true, CreateDate = DateTime.Now, UpdateDate = DateTime.Now }
            };

            context.Companies.AddRange(companies);
            context.SaveChanges();


            var users = new User[]
            {
                new User{ UserName = "ユーザーA", LoginId = "aaa", Password = "aaa", CompanyCode = "AB", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new User{ UserName = "ユーザーB", LoginId = "bbb", Password = "bbb", CompanyCode = "AB", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new User{ UserName = "ユーザーC", LoginId = "ccc", Password = "ccc", CompanyCode = "CD", CreateDate = DateTime.Now, UpdateDate = DateTime.Now }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }

    }
}
