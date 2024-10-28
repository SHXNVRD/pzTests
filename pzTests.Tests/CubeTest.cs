using Cube;
using Xunit;

namespace pzTests.Tests
{
    public class CubeTest
    {
        [Fact]
        public void Get_Volume_8_Returned()
        {
            var cube = new Parallelepiped(2, 2, 2);
            Assert.Equal(8, cube.GetVolume());
        }

        [Fact]
        public void Get_LongestSide_10_Returned()
        {
            var cube = new Parallelepiped(2, 2, 10);
            Assert.Equal(10, cube.GetLongestSide());
        }

        [Fact]
        public void Get_IsCube_True_Returned()
        {
            var cube = new Parallelepiped(2, 2, 2);
            Assert.True(cube.IsCube);
        }
    }
}