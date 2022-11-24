using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.CommonTest
{
    public interface IApplicationConfigSections
    {
        string BaseUrl { get; }
        string UserName { get; }
        string Password { get; }

        

}
}
