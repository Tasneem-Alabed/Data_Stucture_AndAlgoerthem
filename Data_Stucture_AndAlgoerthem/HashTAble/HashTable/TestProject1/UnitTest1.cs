using HashTable;

namespace HashTable.Tests
{
    public class TestProject1
    {
        [Fact]
        public void SetAndGetKeyValue()
        {
            // Arrange
            var hashtable = new Hashtable();
            string key = "testKey";
            string value = "testValue";

            // Act
            hashtable.Set(key, value);
            var result = hashtable.Get(key);

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void SetAndUpdateValueForKey()
        {
            // Arrange
            var hashtable = new Hashtable();
            string key = "testKey";
            string value1 = "testValue1";
            string value2 = "testValue2";

            // Act
            hashtable.Set(key, value1);
            hashtable.Set(key, value2);
            var result = hashtable.Get(key);

            // Assert
            Assert.Equal(value2, result);
        }

        [Fact]
        public void SetAndCheckIfKeyExists()
        {
            // Arrange
            var hashtable = new Hashtable();
            string key = "testKey";
            string value = "testValue";

            // Act
            hashtable.Set(key, value);
            bool exists = hashtable.Has(key);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public void SetAndCheckIfKeyDoesNotExist()
        {
            // Arrange
            var hashtable = new Hashtable();
            string key = "testKey";

            // Act
            bool exists = hashtable.Has(key);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void GetKeys()
        {
            // Arrange
            var hashtable = new Hashtable();
            hashtable.Set("key1", "value1");
            hashtable.Set("key2", "value2");
            hashtable.Set("key3", "value3");

            // Act
            var keys = hashtable.Keys();

            // Assert
            Assert.Contains("key1", keys);
            Assert.Contains("key2", keys);
            Assert.Contains("key3", keys);
        }
    }
}
