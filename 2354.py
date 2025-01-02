class Solution:
    def countExcellentPairs(self, nums: List[int], k: int) -> int:
        nums = list(set(nums))
        
        set_bits = [bin(num).count('1') for num in nums]
        
        set_bits.sort()
        
        count = 0
        for bits in set_bits:
            # Find the minimum required set bits for the pair
            required = k - bits
            # Find the first index where set_bits[idx] >= required
            idx = bisect_left(set_bits, required)
            # All elements from idx to the end of the list form valid pairs
            count += len(set_bits) - idx
        
        return count
