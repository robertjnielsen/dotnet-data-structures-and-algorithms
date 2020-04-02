# Multi-Bracket Validation

_Author: [Robert James Nielsen](https://github.com/robertjnielsen)_

## Problem Domain

Write a method called `MultiBracketValidation` that takes in a string and returns a boolean value whether or not the brackets in the string are valid pairs. There are three types of valid brackets:
- Curly Braces: `{ }`
- Parenthesis: `( )`
- Square Brackets: `[ ]`

## Inputs And Expected Outputs

|Input|Output|
|:---:|:---:|
|`{}`|`True`|
|`{}()[]`|`True`|
|`{}{Extra}[Characters](())`|`True`|
|`[{()]`|`False`|
|`(](`|`False`|
|`{`|`False`|

## Big O

|Time|Space|
|:---:|:---:|
|O(n)|O(n)|

Time is **O(n)** because the method has to iterate through every character in the input string to determine what is an opening and closing bracket, and compare them.

Space is **O(n)** because every opening bracket is added to the `Stack` as a new `Node` instance in order to `Pop` them in the correct order for comparison to closing brackets.

## Whiteboard Visual

## Change Log

**1.2** - 20200402
- Documentation complete to current version.
- Method `MultiBracketValidation` complete.
- Helper method `ValidateOnPop` complete.

**1.1** - 20200402
- `Stack` class created.
- `Node` class created.

**1.0** - 20200402
- README / documentation started.
- Project and solution files created.
- Whiteboard complete.