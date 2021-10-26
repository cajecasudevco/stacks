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

        [Test]
        public void Push_Argumento_Valido()
        {
            var stack = new Stacks<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));

            
        }

    }
}
