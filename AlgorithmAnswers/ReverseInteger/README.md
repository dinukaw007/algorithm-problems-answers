# Reverse Integer
Given a 32-bit signed integer, reverse digits of an integer

###### Example 1:
        Input: 123
        Output: 321

###### Example 2:
        Input: -123
        Output: -321

###### Example 2:
        Input: -120
        Output: -21

#### Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [ ![equation](https://latex.codecogs.com/svg.laten?2^{31})  , ![equation](https://latex.codecogs.com/svg.laten?2^{-31}-1)] For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

    The int type represents signed 32-bit integers with values between  –2,147,483,648 and 2,147,483,647

# Solution
##### Approach 1: Pop and Push Digits & Check before Overflow
### Intuition
We can build up the reverse integer one digit at a time. While doing so, we can check beforehand whether or not appending another digit would cause overflow.
### Algorithm
Reversing an integer can be done similarly to reversing a string.

We want to repeatedly "pop" the last digit off of x and "push" it to the back of the rev. In the end, rev will be the reverse of the x.

To "pop" and "push" digits without the help of some auxiliary stack/array, we can use math
```
//pop operation:
pop = x % 10;
x /= 10;

//push operation:
temp = rev * 10 + pop;
rev = temp;
```
However, this approach is dangerous, because the statement can cause overflow.
Luckily, it is easy to check beforehand whether or this statement would cause an overflow.

To explain, lets assume that rev is positive.

 1) If ![equation](https://latex.codecogs.com/svg.laten?temp%3Drev.10+pop) causes overflow, then it must be that ![equation](https://latex.codecogs.com/svg.laten?rev\geq%5Cfrac%7BINTMAX%7D%7B10%7D)
 2) If ![equation](https://latex.codecogs.com/svg.laten?rev>%5Cfrac%7BINTMAX%7D%7B10%7D) then ![equation](https://latex.codecogs.com/svg.laten?temp%3Drev.10+pop)  is  guaranteed to overflow.
 3) If ![equation](https://latex.codecogs.com/svg.laten?rev%3D%3D%5Cfrac%7BINTMAX%7D%7B10%7D) , then ![equation](https://latex.codecogs.com/svg.laten?temp%3Drev.10+pop) will overflow if and only if pop > 7
 4) If rev is negitive ![equation](https://latex.codecogs.com/svg.laten?rev%3D%3D%5Cfrac%7BINTMIN%7D%7B10%7D) then ![equation](https://latex.codecogs.com/svg.laten?temp%3Drev.10+pop) will overflow if and only if pop < -8


### Reference
[![N|Solid](https://avatar-static.segmentfault.com/208/420/2084202859-5a40b414cba5b_huge128)](https://leetcode.com/problems/reverse-integer/solution/)
