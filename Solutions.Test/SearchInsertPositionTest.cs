using Xunit;
using Solutions.SearchInsertPosition;

namespace Solutions.Test;

public class SearchInsertPositionTest
{
    [Fact]
    public void SearchInsertOfNonExistentTarget()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 1, 3, 6, 11, 14, 18, 32, 43, 59 };
        int target = 23;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(6, resultIndex);
    }

    [Fact]
    public void SearchInsertOfExistentTarget()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 5, 12, 32, 43, 71, 115, 116, 137 };
        int target = 115;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(5, resultIndex);
    }

    [Fact]
    public void SearchInsertOfTargetWhenItIsMoreLast()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 5, 12, 32, 43, 71, 115, 116, 137 };
        int target = 147;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(8, resultIndex);
    }

    [Fact]
    public void SearchInsertOfTargetWhenItIsLessFirst()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 5, 12, 32, 43, 71, 115, 116, 137 };
        int target = 3;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(0, resultIndex);
    }

    [Fact]
    public void SearchInsertOfTargetWhenItIsLast()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 5, 12, 32, 43, 71, 115, 116, 137 };
        int target = 137;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(7, resultIndex);
    }

    [Fact]
    public void SearchInsertOfTargetWhenItIsFirst()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 5, 12, 32, 43, 71, 115, 116, 137 };
        int target = 5;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(0, resultIndex);
    }

    [Fact]
    public void SearchInsertOfTargetWhenItLessLast()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 2, 4, 6 };
        int target = 5;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(2, resultIndex);
    }

    [Fact]
    public void SearchInsertOfTargetWhenItMoreFirst()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 5, 12, 32, 43, 71, 115, 116, 137 };
        int target = 6;
        // Act
        int resultIndex = solution.SearchInsert(nums, target);
        // Assert
        Assert.Equal(1, resultIndex);
    }

    [Fact]
    public void SearchInsertOfRandom()
    {
        // Arrange
        Solution solution = new Solution();
        for (int i = 0; i < 10000; i++)
        {
            var list = new List<int>();
            var lenght = Random.Shared.Next(1, 10);
            for (int j = 0; j < lenght; j++)
            {
                list.Add(Random.Shared.Next(1, 10000));
            }

            int[] nums = list.Distinct().Order().ToArray();
            int trueIndex = Random.Shared.Next(0, nums.Length);
            int target = nums[trueIndex];
            if (Random.Shared.Next(0, 2) == 1)
            {
                target++;
                trueIndex++;
            }
            else  if (Random.Shared.Next(0, 2) == 1)
            {
                target--;
            }
            // Act
            int resultIndex = solution.SearchInsert(nums, target);
            // Assert
            Assert.Equal(trueIndex, resultIndex);
        }
    }
}