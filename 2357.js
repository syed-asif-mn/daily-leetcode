/**
 * @param {number[]} nums
 * @return {number}
 */
var minimumOperations = function(nums) {
    var count = 0;
    while(nums.length > 0){
        nums = nums.filter(element => element !== 0);
        if (nums.length === 0) break; 
        var x = Math.min(...nums);
        nums = nums.map(elem => elem - x);
        count+=1;
    }

    return count;
};
