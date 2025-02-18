﻿using System.Collections.Generic;
using System.Linq;
using Algorithms.DataComparer;
using Algorithms.Sorting;
using Xunit;

namespace Algorithms.Tests
{
    public class InsertionSortingTest
    {
        [Fact]
        public void SortedData_Apply_ShouldReturnSortedData()
        {
            //Arrange
            var data = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            //Act
            var res = data.ApplyInsertionSort(DataComparers.Int);

            //Assert
            Assert.True(data.SequenceEqual(res));
        }

        [Fact]
        public void UnsortedData_Apply_ShouldReturnSortedData()
        {
            //Arrange
            var data = new List<int>
            {
                5, 6, 7, 8, 9, 10, 11, 12, 10, 9, 5
            };

            //Act
            var res = data.ApplyInsertionSort(DataComparers.Int);

            //Assert
            data.Sort();
            Assert.True(data.SequenceEqual(res));
        }
    }
}
