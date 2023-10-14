using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using PizzBuzz;
using System;
using Xunit;
namespace TestProject1
{
    public class UnitTest1

    {
        [Fact]
        public void test1()
        {
         
            BST tree = new BST();

            tree.Insert(30);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(33);


            var fizzBuzz = tree.putInNewStringTree(tree);
    
            Assert.Equal("FizzBuzz", fizzBuzz.root.name);
            Assert.Equal("Fizz", fizzBuzz.root.left.name);
            Assert.Equal("1", fizzBuzz.root.left.left.name);

            Assert.Equal("Buzz", fizzBuzz.root.right.name);
        }

        [Fact]
        public void test2()
        {

            BST t1 = new BST();



            var fizzBuzz = t1.putInNewStringTree(t1);

            Assert.Null(fizzBuzz);
           
        }







    }
}

    