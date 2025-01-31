# F# Mutable Variable Swap Bug

This repository demonstrates a common misunderstanding involving mutable variables and function scope in F#.

## Problem

The `swap` function attempts to swap the values of two mutable variables. However, the output is unexpected.  The values are not swapped after calling the function, even though it seems to perform the swap within the function body. This is different from the behavior of mutable variables in imperative languages such as C# or Java.

## Solution

The issue arises from F#'s handling of mutable variables passed as arguments.  Within the `swap` function, `x` and `y` are copies of the original variables; modifying them within the function doesn't affect the original variables outside of the function scope. To fix this, we need to pass the variables by reference.  F# does not have explicit references like C#, but this is simulated by using tuples and pattern matching in the solution.
