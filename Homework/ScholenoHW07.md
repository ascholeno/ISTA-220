# Programming in C# Chapter 7 Homework
### Anthony Scholeno


1. What is a class? According to the book, what does a class "arrange?"

a class is a type
Class is the root word of the term classification. When you design a class, you systematically arrange information and behavior into a meaningful entity.

2. What are the two purposes of encapsulation?

The two purposes of encapsulation are to combine methods and data within a class; in other words, to support classification and to control the accessibility of the methods and data; in other words, to control the use of the class.

3. How do you instantiate an instance of a class? How do you access that instance?

The syntax for instantiating a new instance of a class is to specify the name of the class (Circle is used in the book as an example) and then declare a name for it as you would a variable.  The "new" keyword creates a new instance of the class. You access it by calling it.  It looks like this:

    `Circle c; //Create a circle variable
    c = new Circle()  //Initialize it`


4. What is the default access of the fields and methods of a class?  How do you change the default?

The default access of the fields and methods of a class are private. To change it to public you write the keyword public before its declaration.

5. What is the syntax for writing a constructor?

    `class Circle
    {
      private int radius;
      public Circle()
      {
      radius = 0;
      }
    }`



6. What is the difference between class fields and methods, and instance fields and methods? How do you create class fields and methods?

Methods that belong to a class and that operate on the data belonging to a particular instance of a class are called instance methods. Class fields and methods are written within the class itself and are scoped locally to that class.  Instances are objects written in another part of code apart from the originating class and are called so their fields and methods may be used.

7. How do you bring a static class in scope? Why would you want to bring a static class in scope?

using statements.  It is useful to do this for utility methods such as those found within the Math class.

8. Can you think of a good reason to create an anonymous class? What is it?

As a way to encapsulate a set of read-only properties into a single object without having to explicitly define a type first.

9. What is polymorphism as this term is used in computer science? This is not in the book.

Polymorphism is often referred to as the third pillar of object-oriented programming, after encapsulation and inheritance. Polymorphism is a Greek word that means "many-shaped" and it has two distinct aspects:

At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays. When this occurs, the object's declared type is no longer identical to its run-time type.

Base classes may define and implement virtual methods, and derived classes can override them, which means they provide their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type of the object, and invokes that override of the virtual method. Thus in your source code you can call a method on a base class, and cause a derived class's version of the method to be executed. (MSDN)

10. What is message passing as this term is used in computer science? This is not in the book.

In computer science, message passing is a technique for invoking behavior (i.e., running a program) on a computer. The invoking program sends a message to a process (which may be an actor or object) and relies on the process and the supporting infrastructure to select and invoke the actual code to run. Message passing differs from conventional programming where a process, subroutine, or function is directly invoked by name. Message passing is key to some models of concurrency and object-oriented programming.

Message passing is used ubiquitously in modern computer software. It is used as a way for the objects that make up a program to work with each other and as a means for objects and systems running on different computers (e.g., the Internet) to interact. Message passing may be implemented by various mechanisms, including channels. (Wikipedia)

11. What was the first object oriented programming language?

Simula

12. Consider this quote by Alexander Stepanov:

I find OOP technically unsound. It attempts to decompose the world in terms of interfaces that vary on a single type. To deal with the real problems you need multisorted algerbras - families of interfaces that span multiple types. I find OOP philosophically unsound. It claims that everything is an object. Even if it is true it is not very interesting - saying that everything is an object is saying nothing at all.

  - Who is Alexander Stephanov? What do you think about this quote?

Alexander Alexandrovich Stepanov (Russian: Алекса́ндр Алекса́ндрович Степа́нов), born November 16, 1950 in Moscow, is a Russian computer programmer, best known as an advocate of generic programming and as the primary designer and implementer of the C++ Standard Template Library, which he started to develop around 1992 while employed at HP Labs. He had earlier been working for Bell Labs close to Andrew Koenig and tried to convince Bjarne Stroustrup to introduce something like Ada generics in C++. He is credited with the notion of concept. (Wikipedia)

I tend to agree with the philosophical point made in this quote.  Object oriented programming makes programming more accessible to people especially people who are less inclined toward math.  That point alone probably justifies the existence of object oriented programming as not all programmers would have to aptitude or desire to solve problems mathematically. However it is a more cumbersome less controlled mechanism for writing a program.  It also relies heavily on a compiling program and interface.  While I think object oriented programming may be a less pure form of coding I think it is ultimately necessary for the continuation of the industry.  I think that as programs continue to become increasingly more complex object oriented programming will become increasingly useful.
