namespace Solutions.SearchInsertPosition;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var intervalStart = 0;
        var intervalEnd = nums.Length - 1;
        do
        {
            var index = (intervalEnd + intervalStart) / 2;

            if (target == nums[index])
            {
                return index;
            }
            else if (target > nums[index])
            {
                intervalStart = index;
            }
            else
            {
                intervalEnd = index;
            }

        } while (intervalStart + 1 < intervalEnd);

        return target <= nums[intervalStart] ? intervalStart 
            : target <= nums[intervalEnd] ? intervalEnd 
            : intervalEnd + 1;
    }
}