﻿using H.Socket.IO.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H.Socket.IO.Tests
{
    [TestClass]
    public class SocketIoUtilitiesTests
    {
        [TestMethod]
        public void GetEventValuesTest()
        {
            CollectionAssert.AreEqual(
                new [] { "message", "value" }, 
                "[\"message\",\"value\"]".GetJsonArrayValues());

            CollectionAssert.AreEqual(
                new[] { "message" },
                "[\"message\"]".GetJsonArrayValues());

            CollectionAssert.AreEqual(
                new[] { "message", "{}" },
                "[\"message\",{}]".GetJsonArrayValues());

            CollectionAssert.AreEqual(
                new[] { "new message", "{\"username\":\"1\",\"message\":\"1\"}" },
                "[\"new message\",{\"username\":\"1\",\"message\":\"1\"}]".GetJsonArrayValues());
        }
    }
}
