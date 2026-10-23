# Tools for the Samples package (#88)

> **The Samples package moved** to its own repository, [iso-20022-messages-samples](https://github.com/Beneficial-Strategies/iso-20022-messages-samples) (package `BeneficialStrategies.Iso20022.Messages.Samples`). The scripts below were used to make its first samples from the validator tests that are still here; they write into `src/Samples`, so point `SRC` at a clone of that repository to use them again.

`Rewriter/` is the tool that moved the tests of `FluentValidation.Tests` off the message records (#88): a Roslyn rewriter that opens a
test project with MSBuild, and with the compiler's own knowledge of every type rewrites
`new Foo { A = x }`, target-typed `new() { ... }` and `source with { A = x }` into `IsoDataFactory.Make<IFoo>(...)` and
`IsoDataFactory.With(source, ...)`, and every record type named in a type position (return types, declarations, patterns, `typeof`,
`using` aliases) into its interface.

```
dotnet build tools/samples/Rewriter -c Release
dotnet tools/samples/Rewriter/bin/Release/net10.0/Rewriter.dll src/Some.Tests/Some.Tests.csproj Validators SomeFile.cs [--dry]
```

The project must still compile with the records referenced (the compiler needs them to know the types); drop the reference afterwards.
Constructions it cannot read are left as they are and listed. It rewrites in place, so run the tests before and after and compare the counts.

The two scripts below were used first, for the 24 choice-validator files, and make the named samples of `src/Samples` out of them:

1. `convert_tests.py <test file>...` rewrites `new Record { A = x }` in test files to `IsoDataFactory.Make<IRecord>(b => b.Set(x => x.A).To(x))`.
   It skips what it cannot read and does not handle `with` expressions or target-typed `new()`.
2. `make_samples.py <test file>...` takes the choice-variant objects out of the files that step 1 has rewritten, writes
   `src/Samples/<Type>/Valid/<Variant>.cs` and points the tests at them.

`bcl-names.txt` lists the public types of the namespaces that implicit usings import (System, System.IO, System.Linq, ...); a sample
class with one of those names gets a trailing underscore.

Run from anywhere; the paths are relative to the script. Run the tests of the files afterwards, with the same count as before.
