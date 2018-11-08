## ZigZag Conversion
String

The string "PAYPALSISHIRING" is written in a zigzag pattern on a given numbers of rows like this : (you may want to dispaly this pattern in a fixe font for better legibility)
```
    P   A   H   N
    A P L S I I G
    Y   I   R
```    
    
And then read line by line :
"PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows :
string covert (string tex , int nRows);

```
convert("PAHNAPLSIIGYIR",3) should return "PAHNAPLSIIGYIR"
```


# Solution
##### Approach 1: Sort by Row
### Intuition
By iterating through the string from left to right, we can easily determine which row in the Zig-Zag pattern that a character belongs to.
### Algorithm
We can use  ![equation](https://latex.codecogs.com/svg.laten?%5Cmin(numRows,len[s])) lists to represent the non-empty rows of the Zig-Zag Pattern.

Iterate through ss from left to right, appending each character to the appropriate row. The appropriate row can be tracked using two variables: the current row and the current direction.

The current direction changes only when we moved up to the topmost row or moved down to the bottommost row.

### Complexity Analysis

 - Time Complexity: ![equation](https://latex.codecogs.com/svg.laten?O(n)) , where  ![equation](https://latex.codecogs.com/svg.laten?n%3D%3Dlen(n))
 - Space Complexity: ![equation](https://latex.codecogs.com/svg.laten?O(n))

### Reference
[![N|Solid](https://avatar-static.segmentfault.com/208/420/2084202859-5a40b414cba5b_huge128)](https://leetcode.com/problems/zigzag-conversion/solution/)