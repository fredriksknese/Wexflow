﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wexflow.DotnetCore.Tests
{
    [TestClass]
    public class SshCmd
    {
        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void CsvToSqlTest()
        {
            // TODO
            Helper.StartWorkflow(150);
        }

    }
}
