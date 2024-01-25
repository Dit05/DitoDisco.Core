# DitoDisco.Core
Useful high-level constructs.

## Features
[IGenericEnumerable](/DitoDisco.Core/IGenericEnumerable.cs) - Interface for implementing `System.Collections.Generic.IEnumerable<T>` without the burden of `System.Collections.IEnumerable`.

*Example:*
```
using System.Collections.Generic;
using DitoDisco.Core;

// Without:
class MyEnumerable : IEnumerable<int> {
    public IEnumerator<int> GetEnumerator() {
        for(int i = 1; i <= 10; i++) yield return i;
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator(); // Totally arcane and unnecessary bloat in every type that implements IEnumerable<T>
}

// With:
class MyGenericEnumerable : IGenericEnumerable<int> { // Implements from IEnumerable<T> just the same, without non-generic bloat.
    public IEnumerator<int> GetEnumerator() {
        for(int i = 1; i <= 10; i++) yield return i;
    }
}
```
