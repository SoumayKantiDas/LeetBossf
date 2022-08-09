public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var l = nums.Length;
        int[] ans = new int[l];

        int temp = 1;
        for (int i = 0; i < l; ++i)
        {
            ans[i] = temp;
            temp *= nums[i];
        }

        temp = 1;
        for (int i = l - 1; i >= 0; --i)
        {
            ans[i] *= temp;
            temp *= nums[i];
        }

        return ans;
    }
}