# Code description

## **Task:** Write a program that takes elements with less or equal length to **3** from **string[]** array and puts into new array. 
## Example:

### [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
### [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
### [“Russia”, “Denmark”, “Kazan”] → []
---

### 1. Create a Method which finds the lenght of the final array. **ArrLength()**.
    - go through each element with "for" loop.
    - check the lengt of element.
    - save the valid elements count in variable.
### 2. Create a Method which puts valid elements in new array.
    - go through the array with "for" loop.
    - check the length and put the valid elements in new array.
### 3. Print both arrays to see the result.