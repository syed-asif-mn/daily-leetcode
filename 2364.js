/**
 * @param {number[]} nums
 * @return {number}
 */
function countBadPairs(nums) {
    const n = nums.length;
    let badPairs = 0;
    const freqMap = new Map();

    for (let j = 0; j < n; j++) {
        const diff = nums[j] - j;

        // Count good pairs using the current diff
        if (freqMap.has(diff)) {
            badPairs += j - freqMap.get(diff); // Add bad pairs so far
            freqMap.set(diff, freqMap.get(diff) + 1); // Increment the frequency
        } else {
            badPairs += j; // All pairs with indices before j are bad
            freqMap.set(diff, 1); // Initialize the frequency
        }
    }

    return badPairs;
}
