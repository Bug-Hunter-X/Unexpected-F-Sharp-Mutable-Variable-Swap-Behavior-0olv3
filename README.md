# F# Mutable Variable Swap Bug

This repository demonstrates an uncommon error in F# related to swapping mutable variables.  The issue arises from the difference between directly assigning values and using references when working with mutable variables. 

The `bug.fs` file shows the problematic code, while `bugSolution.fs` provides the corrected implementation.  The core issue involves understanding how mutability works with references in F#.