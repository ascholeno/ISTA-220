# Programming in C# Chapter 10 Homework
### Anthony Scholeno

1. What does an array look like in memory?

An array is an unordered sequence of items that live in a contiguous block of memory and are accessed by using an index.
(pg 221)

2. Where is memory allocated to hold an array, on the stack or on the heap?

The memory is allocated on the heap. (pg 222)

3. Where is memory allocated to hold an array reference, on the stack or on the heap?

The memory is allocated on the stack. (pg 222)

4. Can an array hold values of different types?

Yes only if we create an object array. If we don't a compile time error will pop saying cannot convert type string to int

5. Describe the syntax of the condition for a foreach loop.

ForEach is a way to execute a statement or a set of statement multiple numbers of times depending on the result of a condition to be evaluated.

The foreach statement declares an iteration variable that automatically acquires the value of each element in the array. The type of this variable must match the type of the elements in the array. The foreach statement is the preferred way to iterate through an array; it expresses the intention of the code directly, and all of the for loop scaffolding drops away. (pg 226)

6. How do you make a deep copy of an array?

You must use the appropriate code in a for loop statement. (pg 230)

7. What is the difference in the syntax between a multi-dimensional array and an array of arrays?

A multi-dimensional array is always an even shape and the number of elements is equal to the rows * columns. However an array of arrays or jagged array allows for columns or rows of varying length and does not always result in a symmetric shape. (pg 230)  Jagged arrays are array reference, where as multi-dimensional arrays can only store elements and dimensions.

8. What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words, what determines whether you would use one as opposed to the other?

Jagged arrays are array reference, where as multi-dimensional arrays can only store elements and dimensions.

9. How do you “flatten” a multidimensional array?

We access the 2d array total element count--the length property of a 2d returns this value We copy the 2d array into 1D array. We return 1D array.

10. When we use a for loop, we can change the values of the array elements inside the loop. When we use a foreach loop, we cannot change the values of the array elements inside the loop. Why not? How is for different from foreach?

ForEach is shorthand to give you values in memory location, for gives you the memory location
