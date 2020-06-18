using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailChecker.Interfaces
{
    public interface IEmailChecker
    {
        int CheckEmails(IList<string> emailsList);
    }
}
