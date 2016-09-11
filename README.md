LeetCode Solutions in .NET Core
===============================

Solutions to the problems on [LeetCode](https://leetcode.com/problemset/algorithms/) 
along with XUnit test tests.

## Setup
1. Install .Net Core on Windows/Mac/Linux ([Instructions](https://www.microsoft.com/net/core))
1. Install [VSCODE](https://code.visualstudio.com/)
1. Clone this repo locally

## RunTest
1. Solutions for individual problems are in the /src/LeetcodeSolutions folder
1. To run all tests:
    1. Navigate to /test/LeetcodeSolutions.tests
    1. Run "dotnet test"
1. To run test for a particular solution:
    1. Navigate to /test/LeetcodeSolutions.tests
    1. Run the below command (where "SolXXXProblemNameTest" is the test
    class for the problem you want to test)
    > dotnet test -class "SumitGouthaman.LeetcodeSolutions.UnitTests.SolXXXProblemNameTest"

## Note
1. Solutions here use C# features to keep solutions simple and succinct.
Since LeetCode does not yet support a newer mono version, the C# 6
constructs have to be converted into appropriate pre - C#6 constructs.
```c#
    // Assume "node" is a nullable reference
    // We want to set val = 0 if node is null, else val = node.val
    
    // In C# 6:
    int val = node?.val ?? 0;

    // Pre C# 6:
    int val = (node != null) ? node.val : 0;
```
