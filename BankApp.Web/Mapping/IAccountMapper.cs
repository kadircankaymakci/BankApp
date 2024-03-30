using BankApp.Web.Data.Entities;
using BankApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Web.Mapping
{
    public interface IAccountMapper
    {
        Account Map(AccountCreateModel model);
    }
}
