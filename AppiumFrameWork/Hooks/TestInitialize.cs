using AppiumFrameWork.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFrameWork.Hooks
{
    [TestFixture]

    public class TestInitialize : Base
    {

        [SetUp]
        public void InitializeTest()
        {
            AndroidContext = StartAppiumServerForHybrid();
        }

        [TearDown]
        public void CleanUp()
        {
            appiumUtilities.CloseAppiumServer();
        }
        
    }
}
