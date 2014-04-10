using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN;
using WatiN.Core;

namespace Sample.Web.SmokeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Verify_WebsiteUp()
        {
            using (var browser = new IE("http://localhost/Sample.Web_deploy"))
            {
                var hasText = browser.ContainsText("Getting started");
                Assert.IsTrue(hasText);
            }
        }
    }
}
