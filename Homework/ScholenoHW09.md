# C# Homework 09
## Name: Anthony Scholeno
---

##### 1.What is an enum?
1. Is a value type data type. The enum is used to declare a list of named integer constants. A symbolic constant. You give a series of numbers names
---
##### 2.Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, Corporal, Sergeant or Lieutenant, Captain, Major?
2. Enum Rank{
  Private, PFC, LcPl, Corporal, Sergeant, StaffSergeant, GySgt, MSgt, MGySgt}
--
##### 3.Using the Ranks enum, assign a rank to yourself and a friend
3. Rank Anthony = Rank.StaffSergeant;
---
##### 4.Determine the numeric index of particular ranks, using the Ranks enum
4. Console.WriteLine((int)Ranks.StaffSergeant);
---
##### 5.How do you select the type of an enum?
5. When you declare an enumeration, the enumeration literals are given values of type int. You can also choose to base your enumeration on a different underlying integer type. For example, to declare that
the underlying type for Season is a short rather than an int, you can write this:
enum Season : short { Spring, Summer, Fall, Winter }
---
##### 6.What is a struct?
6. A struct is a value type data type. It helps you to make a single variable hold related data of various data types.
---
##### 7.List some differences between classes and structs
7. Struct cannot have a default constructor, Struct are value types and are copied on assignment. A struct cannot inherit directly from another class or strut.
---
##### 8.Are structs stored on the stack or on the heap? What about enums?
8. structs and enums are allocated on the stack.
---
##### 9.Review the documentation for the C# System.Int32 struct. List the fields. List the methods.
9. Fields-MaxValue and MinValue, Methods-CompareTo, Equals, Parse, TryParse.
---
##### 10.Declare a struct named DOD with four branches.
10. {public string Army,
     public string Marines,
     public string Navy,
     public string AirForce,
     public string SpaceForce}
---
##### 11.Why can’t you create a default constructor for a struct?
11. Because for a value type, compilers by defaults neither generate a default constructor, nor do they generate a call to the default constructor.
---
##### 12.What is CIL? What does the CLR do to the CIL?
12.Common Intermediate Language is a ByteCode and the Language of the .NET platform into which are compiled source code written in high level language.  Role of CLR(Command Language Runtime) in the execution of a C# program.
