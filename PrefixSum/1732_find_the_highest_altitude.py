class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        highestAltitude = currentAltitude = 0
        for i in range(len(gain)):
            currentAltitude = currentAltitude + gain[i]
            if (currentAltitude > highestAltitude):
                highestAltitude = currentAltitude

        return highestAltitude