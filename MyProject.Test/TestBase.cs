using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;

namespace $safeprojectname$
{
    [TestClass]
    public class TestBase
    {
        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private Stopwatch Stopwatch { get; set; }

        /// <summary>
        /// Starts a clock
        /// </summary>
        [TestInitialize]
        public void Initialization()
        {
            // Start counting time
            this.Stopwatch = new Stopwatch();
            this.Stopwatch.Start();
        }

        [TestCleanup]
        public void End()
        {
            // Stop counting time
            this.Stopwatch.Stop();

            string filename = TestContext.TestRunDirectory + "/TestsPerformance.txt";
            string text = "";

            // Write the top of the file
            if (!File.Exists(filename))
                text = "Unit Test run on " + DateTime.Now.ToShortDateString() + " "
                            + DateTime.Now.ToShortTimeString() + Environment.NewLine;

            text += TestContext.TestName + " " + this.Stopwatch.Elapsed.ToString(@"mm\:ss\.fffffff", null);
            text += " ";         

            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
                text += "FAILED";
            else
                text += "SUCCESS";
            text += Environment.NewLine;

            File.AppendAllText(filename, text);


            // Just to keep the test results
            TestContext.AddResultFile("TestsPerformance.txt");
        }
    }
}
