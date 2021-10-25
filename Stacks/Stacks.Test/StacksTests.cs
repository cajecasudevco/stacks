using NUnit.Framework;
using Stacks;

namespace Stacks.Test
{
    [TestFixture]
    public class StacksTests
    {
        
        [Test]
        public void Push_Argumento_Nulo_ArrojaExcepcion()
        {
            var stack = new Stacks<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);


        }
    }
}
