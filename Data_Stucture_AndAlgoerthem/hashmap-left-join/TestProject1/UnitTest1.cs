using hashmap_lef_join;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void test1()
        {
            var map1 = new HashMap<string, string>(100);
            map1.Set("A", "Value1");
            map1.Set("B", "Value2");

            var map2 = new HashMap<string, string>(100);
            map2.Set("B", "Value3");
            map2.Set("C", "Value4");

            var hashMap = new HashMap<string, string>(100);
            var result = hashMap.LeftJoin(map1, map2);

            Assert.Equal(2, result.Count);
            Assert.Equal(new[] { "A", "Value1", null }, result[0]);
            Assert.Equal(new[] { "B", "Value2", "Value3" }, result[1]);
        }

            [Fact]
        public void test2()
        {
            var map1 = new HashMap<string, string>(100);
            map1.Set("A", "Value1");
            map1.Set("B", "Value2");

            var map2 = new HashMap<string, string>(100);

            var hashMap = new HashMap<string, string>(100);
            var result = hashMap.LeftJoin(map1, map2);

            Assert.Equal(2, result.Count);
            Assert.Equal(new[] { "A", "Value1", null }, result[0]);
            Assert.Equal(new[] { "B", "Value2", null }, result[1]);
        }
       
    }
}