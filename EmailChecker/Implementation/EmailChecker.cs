using EmailChecker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailChecker.Implementation
{
    public class EmailChecker : IEmailChecker
    {
        public int CheckEmails(IList<string> emailsList)
        {
            HashSet<string> uniqueEmails = new HashSet<string>();

            foreach(string email in emailsList)
            {
                var result = email.Split("@")[0].Split("+")[0].Replace(".", "");

                uniqueEmails.Add(result);
            }

            return uniqueEmails.Count;
        }
    }
}
