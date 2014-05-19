using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpKatas
{
    // todo #3: (see below)


    #region DoNotModify
    // DO NOT MODIFY THIS FILE FOR THIS CLASS FOR THIS KATA
    public class SomeoneElsesClass
    {
        public List<int> Numbers { get; set; }
    }
    #endregion

    public static class ExtensionMethods
    {
        public static int? FindNumberOrDefault(this SomeoneElsesClass list, int number)
        {
            return list.Numbers.Contains(number) ? (int?)number : null;
        }
    }


    [TestFixture]
    public class TestExtensionMethods
    {
        [Test]
        public void FindNumberOrDefault_NumberExists_ReturnIt()
        {
            var someoneElsesClass = new SomeoneElsesClass
            {
                Numbers = new List<int> { 1, 2, 3 }
            };
            Assert.AreEqual(1, someoneElsesClass.FindNumberOrDefault(1));
        }

        [Test]
        public void FindNumberOrDefault_NumberDoesNotExist_ReturnNull()
        {
            var someoneElsesClass = new SomeoneElsesClass
            {
                Numbers = new List<int> { 1, 2, 3 }
            };
            var v = someoneElsesClass.FindNumberOrDefault(4);
            Assert.IsNull(v);
        }

        [Test]
        [Ignore]
        public void FindNumberOrDefault_SomeoneElsesClassIsNull_CheckForNull()
        {
            // todo #3: What's bizarre about the following test? Why is there no error? Consider reverse engineering the code with a tool like Just Decompile to get the answer.
            SomeoneElsesClass someoneElsesClass = null;
            Assert.IsNull(someoneElsesClass.FindNumberOrDefault(4));
        }
    }
}

