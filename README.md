# diamond-kata-solver
This is a solver for the [Diamond Kata](https://github.com/davidwhitney/CodeDojos/tree/master/Diamond%20Kata).

## Quick start
Run `.\DiamondKataSolver.exe <letter>`, where `<letter>` is a single character from the English alphabet (both uppercase and lowercase are supported).

## Tests
I used test-driven development (TDD) to develop this solver. The commit history is the most helpful way to see how I used the tests to systematically break the problem down into more manageable subproblems and solve those one after the other, in order to build up to a full solution.

Another thing to note is that the test data is hard coded (not unusual for a typical production-grade C#/.NET project). What's more, the most pragmatic thing to do for the purpose of this kata was to keep the test data within the project codebase.

However, if this project were being worked on by multiple team members and had high footfall, I would consider moving the test data to an external file to prevent accidental modification (though that's why we have Git and blame!).

## Miscellanea
You may see the terms 'girdle' and 'tip' used in the codebase. 

A diamond's girdle is its widest part and its tip is the pointy part where the facets of the diamond meet (the technical term is 'culet', but I figured 'tip' would be more easily understood).



