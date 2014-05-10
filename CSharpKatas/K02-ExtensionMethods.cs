using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpKatas
{
    // todo #0: Uncomment everything (Ctrl-A, Ctrl-KU)
    // todo #1: Without modifying SomeoneElsesClass add a new class that makes the unit tests pass
    // todo #2: Refactor so that there are no loops or if statements.
    // todo #3: (see below)


    #region DoNotModify
    // DO NOT MODIFY THIS FILE FOR THIS CLASS FOR THIS KATA
    public class SomeoneElsesClass
    {
        public List<int> Numbers { get; set; }
    }
    #endregion

    public class MyClass :  SomeoneElsesClass
    {
        public int? FindNumberOrDefault(int number)
        {
            return Numbers.Contains(number) ? (int?)number : null;
        }
    }

    [TestFixture]
    public class TestExtensionMethods
    {
        [Test]
        public void FindNumberOrDefault_NumberExists_ReturnIt()
        {
            var myClassInstance = new MyClass
            {
                Numbers = new List<int> { 1, 2, 3 }
            };
            Assert.AreEqual(1, myClassInstance.FindNumberOrDefault(1));
        }

        [Test]
        public void FindNumberOrDefault_NumberDoesNotExist_ReturnNull()
        {
            var myClassInstance = new MyClass
            {
                Numbers = new List<int> { 1, 2, 3 }
            };
            var v = myClassInstance.FindNumberOrDefault(4);
            Assert.IsNull(v);
        }

        [Test]
        [Ignore]
        public void FindNumberOrDefault_SomeoneElsesClassIsNull_CheckForNull()
        {
            // todo #3: What's bizarre about the following test? Why is there no error? Consider reverse engineering the code with a tool like Just Decompile to get the answer.
            MyClass myClassInstance = null;
            Assert.IsNull(myClassInstance.FindNumberOrDefault(4));
        }
    }
}

