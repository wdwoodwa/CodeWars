Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

FOR EXAMPLE:
uniqueInOrder('AAAABBBCCDAABBB') == ['A', 'B', 'C', 'D', 'A', 'B']
uniqueInOrder('ABBCcAD')         == ['A', 'B', 'C', 'c', 'A', 'D']
uniqueInOrder([1,2,2,3,3])       == [1,2,3]



--------------------------------------------------------------------------------


Going to roll with solutions that will use as few libraries as possible.
Also, I'm working off my personal machine running macos, so I'm using an online 
C# compiler through code wars. 