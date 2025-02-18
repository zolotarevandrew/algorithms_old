﻿using System.Collections.Generic;
using System.Linq;
using Algorithms.DataComparer;
using Algorithms.Sorting;
using Xunit;

namespace Algorithms.Tests
{
    public class QuickSortingTest
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
            var res = data.ApplyQuickSort(DataComparers.Int);

            //Assert
            Assert.True(data.SequenceEqual(res));
        }

        [Fact]
        public void UnsortedData_Apply_ShouldReturnSortedData()
        {
            //Arrange
            var data = new List<int>
            {
                13, 3, 8, 1, 15, 2, 3, 7
            };

            //Act
            var res = data.ApplyQuickSort(DataComparers.Int);

            //Assert
            data.Sort();
            Assert.True(data.SequenceEqual(res));
        }
    }
}
