using System;
using GradeBook;
using Xunit;

namespace Gradebook.tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(1.1);
            book.AddGrade(2.2);
            book.AddGrade(3.3);
            
            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(1.1, result.Low);
            Assert.Equal(3.3, result.High);
            Assert.Equal(2.2, result.Average, 1);
            Assert.Equal('F', result.Letter);
        }
    }
}
