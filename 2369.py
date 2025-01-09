def validPartition(nums):
    n = len(nums)
    # Initialize DP variables
    dp_prev2 = False  # dp[i-2]
    dp_prev1 = nums[0] == nums[1]  # dp[i-1]
    dp_curr = False  # dp[i]
    
    if n == 2:
        return dp_prev1

    for i in range(2, n):
        dp_curr = False
        # Check the last two elements
        if nums[i] == nums[i-1] and dp_prev1:
            dp_curr = True
        # Check the last three elements
        if (nums[i] == nums[i-1] == nums[i-2] or
            nums[i] == nums[i-1] + 1 == nums[i-2] + 2) and dp_prev2:
            dp_curr = True
        
        # Update DP variables
        dp_prev2 = dp_prev1
        dp_prev1 = dp_curr
    
    return dp_curr
