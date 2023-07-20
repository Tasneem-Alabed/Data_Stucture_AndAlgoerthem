using ConsoleApp1;
namespace TestProject1
{
    public class UnitTest1
    {
      
            [Fact]
            public void test()
            {
               
                AnimalShelter shelter = new AnimalShelter();
                shelter.Enqueue(new Animal("cat", "Fluffy"));
                shelter.Enqueue(new Animal("dog", "Buddy"));

               
                Animal result = shelter.Dequeue("invalid"); 

        
                Assert.Null(result);
            }

            [Fact]
            public void test1()
            {
             
                AnimalShelter shelter = new AnimalShelter();
                Animal cat1 = new Animal("cat", "Whiskers");
                Animal dog1 = new Animal("dog", "Max");
                Animal cat2 = new Animal("cat", "Mittens");

                shelter.Enqueue(cat1);
                shelter.Enqueue(dog1);
                shelter.Enqueue(cat2);

              
                Animal result1 = shelter.Dequeue("cat"); 
                Animal result2 = shelter.Dequeue("cat"); 
                Animal result3 = shelter.Dequeue("dog"); 

            
                Assert.Equal("Whiskers", result1.name);
                Assert.Equal("Mittens", result2.name);
                Assert.Equal("Max", result3.name);
            }
        }
    }

