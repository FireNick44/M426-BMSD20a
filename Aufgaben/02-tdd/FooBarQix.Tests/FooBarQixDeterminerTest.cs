using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        public void generalTest()
        {
            //Arrange
            double num = 1;
            string expected = "1";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void fooTest()
        {
            //Arrange
            double num = 3;
            string expected = "foo";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void barTest()
        {
            //Arrange
            double num = 5;
            string expected = "bar";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void qixTest()
        {
            //Arrange
            double num = 7;
            string expected = "qix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void fooQixTest()
        {
            //Arrange
            double num = 21;
            string expected = "fooqix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void fooBarTest()
        {
            //Arrange
            double num = 15;
            string expected = "foobar";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void barQixTest()
        {
            //Arrange
            double num = 35;
            string expected = "barqix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void fooBarQixTest()
        {
            //Arrange
            double num = 105;
            string expected = "foobarqix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            //Act
            string actual = fooBarQixDeterminer.determine(num);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}