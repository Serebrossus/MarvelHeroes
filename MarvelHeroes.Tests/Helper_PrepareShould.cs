using System;
using Xunit;
using MarvelHeroes.Classes;
using Ninject;
using Ninject.Planning.Bindings;
using Ninject.Syntax;

namespace MarvelHeroes.Tests
{
    public class Helper_PrepareShould
    {
        private IKernel _appKernel;
        [Theory]
        [InlineData(new object[] { new string[] {"Repulsor"}})]
        [InlineData(new object[] { new string[] {"Repulsor", "Hammer", "Shield"}})]
        [InlineData(new object[] { new string[] {"repulsor"}})]
        [InlineData(new object[] { new string[] {"repulsor", "hammer", "shield"}})]
        public void PrepareWeapons_Positive(string[] names) {
            _appKernel = new StandardKernel(new AvengersNinjectModule());
            var weapons = _appKernel.PrepareWeapons(names);
            Assert.NotNull(weapons);
            Assert.NotEmpty(weapons);
        }


        [Theory]
        [InlineData(new object[] { new string[] {"thor"}})]
        [InlineData(new object[] { new string[] {"ironman", "thor", "antman"}})]
        [InlineData(new object[] { new string[] {"Thor", "IronMan"}})]
        [InlineData(new object[] { new string[] {"THOR", "IRONMAN"}})]
        public void PrepareWeapons_Negotive(string[] names) {
            _appKernel = new StandardKernel(new AvengersNinjectModule());
            var avengers = _appKernel.PrepareUltimateAvengers(names);
            Assert.NotNull(avengers);
            Assert.NotEmpty(avengers);
        }
    }
}