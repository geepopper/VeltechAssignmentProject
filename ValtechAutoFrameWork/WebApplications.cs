using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtechAutoFrameWork
{
    interface WebApplications
    {
        void ClickElement(string elementIdentifier, string locator);

        bool SetValue(string elementIdenfier, string locator, string text, bool verifyInput = false);
        

    }
}
