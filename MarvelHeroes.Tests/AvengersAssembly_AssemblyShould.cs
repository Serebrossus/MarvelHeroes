using System;
using Xunit;
using MarvelHeroes.Classes;
using Ninject;
using Ninject.Planning.Bindings;
using Ninject.Syntax;

namespace MarvelHeroes.Tests
{
    public class AvengersAssembly_AssemblyShould
    {
        private IKernel _appKernel;

        [Fact]
        public void Assembly()
        {
            _appKernel = new StandardKernel(new AvengersNinjectModule());
            var assembly = new AvengersAssembly();
            var result = assembly.Assembly(_appKernel, "thor");
            Assert.False(result, "1 should not be assemble");
        }

        [Theory]
        [InlineData("thor")]
        [InlineData("ironman, thor")]
        [InlineData("captainamerica")]
        [InlineData(" ")]
        public void ReturnFalseGivenValuesLessThan2(string value)
        {
            _appKernel = new StandardKernel(new AvengersNinjectModule());
            var assembly = new AvengersAssembly();
            var result = assembly.Assembly(_appKernel, value);
            Assert.False(result, $"{value} should not be assemble");
        }
    }
}
