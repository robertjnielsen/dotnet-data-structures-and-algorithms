# Linked List Implementation
Code Fellows 401 .NET - Code Challenge 05  
_Author: [Robert James Nielsen](https://github.com/robertjnielsen)_

## Problem Domain
To learn about Linked Lists, we were to create our own implementation of a Linked List. The (high-level) requirements were as such:
- Create a Node class that has properties for the value stored in the Node, and a reference to the next Node.
- Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
- Define a method called `Insert` which takes any value as an argument, and adds a new node with that value to the head of the list with an O(1) Time performance.
- Define a method called `Includes` which takes any value as an argument, and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
- Define a method called `ToString` which takes in no arguments, and returns a string representing all the values in the Linked List, formatted as:
	- `"valA -> valB -> valC -> NULL"`

## Inputs And Expected Outputs
This challenge was just an implementation and introductory understanding of the Linked List data structure. We did not utilize the data structure in a practical way for this challenge.

## Big O

#### Insert() Method

|Time|Space|
|:---:|:---:|
|O(1)|O(1)|

Time is **O(1)** becuause this `Insert()` method will always insert a new Node object at the beginning of the Linked List, no matter the size of the Linked List.

Space is **O(1)** because the method will only create and insert one new Node object into the Linked List, as defined in the method parameters.

#### Includes() Method

|Time|Space|
|:---:|:---:|
|O(n)|O(1)|

Time is **O(n)** because it doesn't matter if the Linked List contains 1 or 100 Node objects, the method will have to traverse through each of those objects within the List sequentially until it finds a matching value (if the value exists).

Space is **O(1)** because the method is not instantiating or adding any new data to memory.

#### ToString() Method

|Time|Space|
|:---:|:---:|
|O(n)|O(1)|

Time is **O(n)** because it doesn't matter if the Linked List contains 1 or 100 Node objects, the method will have to traverse through each of those objects within the List sequentially to append all values to the StringBuilder instance.

Space is **O(1n)** because the method is adding a single new StringBuilder instance to memory.

## Whiteboard Visual

A whiteboard visual was not required for this code challenge, as we were only building a basic implementation of a Linked List data structure.

## Change Log

**1.3** - 20200323
- Documentation complete.

**1.2** - 20200323
- Code challenge complete.
- All tests passed.

**1.1** - 20200322
- Test project created.

**1.0** - 20200322
- Project / solution files created.
- Repository initialized.

