using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Utils
{
    public static class IWebElementExtensions
    {
        public static int MaxLengthAttributeValue(this IWebElement element)
        {
            var attribute = element.GetAttribute("maxlength");
            Assert.IsNotNull(attribute, "The element does not have a maxlength attribute.");
            return int.Parse(attribute);
        }

        public static int MinLengthAttributeValue(this IWebElement element)
        {
            var attribute = element.GetAttribute("minlength");
            Assert.IsNotNull(attribute, "The element does not have a minlength attribute.");
            return int.Parse(attribute);
        }
    }
}
