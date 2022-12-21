using AuthenticationMernis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationMernis.Abstract
{
    public interface ICustomerCheckService 
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
