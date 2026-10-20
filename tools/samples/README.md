# Tools for the Samples package (#88)

Used once to move the first slice of test objects into `src/Samples`; kept so the same can be done for the next one, until the
Roslyn rewriter of #88 replaces them.

1. `convert_tests.py <test file>...` rewrites `new Record { A = x }` in test files to `IsoDataFactory.Make<IRecord>(b => b.Set(x => x.A).To(x))`.
   It skips what it cannot read and does not handle `with` expressions or target-typed `new()`.
2. `make_samples.py <test file>...` takes the choice-variant objects out of the files that step 1 has rewritten, writes
   `src/Samples/<Type>/Valid/<Variant>.cs` and points the tests at them.

`bcl-names.txt` lists the public types of the namespaces that implicit usings import (System, System.IO, System.Linq, ...); a sample
class with one of those names gets a trailing underscore.

Run from anywhere; the paths are relative to the script. Run the tests of the files afterwards, with the same count as before.
