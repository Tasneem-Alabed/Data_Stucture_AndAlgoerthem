using HashTable;

namespace HashTable.Tests
{
    public class TestProject1
    {
        [Fact]
        public void TestSetAndGetKeyValue()
        {
             
            var hashTable = new Hash(5);

             
            hashTable.set("key1", "value1");
            hashTable.set("key2", "value2");

             
            Assert.Equal("value1", hashTable.get("key1"));
            Assert.Equal("value2", hashTable.get("key2"));
        }

        [Fact]
        public void TestNotFound()
        {
             
            var hashTable = new Hash(5);
 
            Assert.Equal("Not Found", hashTable.get("nonexistent_key"));
        }

        [Fact]
        public void TestHasExistingKey()
        {
           
            var hashTable = new Hash(5);
            hashTable.set("existing_key", "value");

            Assert.True(hashTable.has("existing_key"));
        }

        [Fact]
        public void TestHasNonExistentKey()
        {
           
            var hashTable = new Hash(10);

            
            Assert.False(hashTable.has("nonexistent_key"));
        }

        [Fact]
        public void TestReturnAllKeys()
        {
            
            var hashTable = new Hash(5);
            hashTable.set("key1", "value1");
            hashTable.set("key2", "value2");

           
            string[] keys = hashTable.Keys();

           
            Assert.Contains("key1", keys);
            Assert.Contains("key2", keys);
        }
    }
}
