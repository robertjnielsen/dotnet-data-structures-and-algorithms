# Binary Trees

Code Fellows 401 .NET Course - Code Challenge 15  
_Author: [Robert James Nielsen](https://github.com/robertjnielsen)_

## Problem Domain

- Create a `Node` class that has properties for the value stored in the node, the left child node, and the right child node.
- Create a `BinaryTree` class.
- Define a method for each of the depth first traversals called `PreOrder`, `InOrder`, and `PostOrder` which returns an array of the values, ordered appropriately.
- Create a `BinarySearchTree` class.
- Define a method named `Add` that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
- Define a method named `Contains` that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## Inputs And Expected Outputs

#### Sample Tree Input
```
    5
   / \
  3   7
 / \
2   4
```

#### Sample Outputs

`PreOrder` : `{ 5, 3, 2, 4, 7 }`  
`InOrder` : `{ 2, 3, 4, 5, 7}`  
`PostOrder` : `{2, 4, 3, 7, 5}`  
`Contains` : `True`

## Big O

|Time|Space|
|:---:|:---:|
|O(n)|O(1)|

All of the methods in this challenge are the same for Big O notation except for one, which I will over after:

Time: The Time efficiency for all methods is **O(n)** because each method has to traverse an **n** number of Node objects in the Tree to determine where to Add a new Node, or to return values of Node objects.

Space: The Space efficiency for all methods is **O(1)** because in all methods (except `Add`, covered below) we are not instantiating anything new to memory.

Space (`Add` Method): I believe that the `Add` method is also an **O(1)** operation, because even though it is adding a new Node instance to memory, it is only the one instance each time the method is called.

## Whiteboard Visual

![Binary Search Tree Add Method Whiteboard](../../Assets/Images/BinarySearchTreeAdd.jpg)

## Change Log

**1.4** - 20200406
- Documentation complete to current version.

**1.3** - 20200406
- All relevent tests passed.
- BinaryTree methods complete.

**1.2** - 20200406
- All relevent tests passed.
- BinarySearchTree methods complete.

**1.1** - 20200406
- BinarySearchTree class created.
- BinaryTree class created.
- Node class created.

**1.0** - 20200406
- Test project files created.
- Project / Solution files created.
- Whiteboard completed.