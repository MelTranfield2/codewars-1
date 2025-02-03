using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PrimeService.Tests

{
    public class VariableNamesTest1
    {
        [Fact]
        public void Test1()
        {
            VariableNames variables = new VariableNames();

            var boolProp = typeof(VariableNames).GetField("bool");
            Assert.Equal(typeof(bool), boolProp?.FieldType);
            // Assert.That(CheckType(VariableNames, "bool", typeof(bool)), Is.True);

            var charProp = typeof(VariableNames).GetField("char");
            Assert.Equal(typeof(char), charProp?.FieldType);
        
            var sbyteProp = typeof(VariableNames).GetField("sbyte");
            Assert.Equal(typeof(sbyte), sbyteProp?.FieldType);
        }
    }
}