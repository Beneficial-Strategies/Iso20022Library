# BeneficialStrategies.Iso20022.Samples

Named ISO 20022 objects for tests: valid ones, and invalid ones for known issues, built through the
[`Factory`](../Factory/README.md) against the **interfaces**. A test that needs "a valid account identification" takes one from
here and needs neither the message records (`BeneficialStrategies.Iso20022.Common`) nor ten lines of setup.

Targets netstandard2.0, net8.0 and net10.0. It is a work in progress (#88): today it holds the choice variants of 24 choices; the
rest of the model comes with the tests that use it.

The tools that moved the first tests onto it are in `tools/samples/`; the pattern is the same for every type that follows.

## Use

```csharp
// the IBAN variant of AccountIdentification4Choice, valid
IAccountIdentification4Choice id = Samples.AccountIdentification4Choice.Valid.IBAN.Minimal;

var result = validator.TestValidate(id);   // a validator of the FluentValidation package, for example
```

## Layout

```
Samples/<Type>/Valid/<Scenario>.cs     a static class per scenario, with Minimal and (where it differs) Maximal
Samples/<Type>/Invalid/<Issue>.cs      one static class per known issue (none yet)
```

* **Namespace and name.** `BeneficialStrategies.Iso20022.Samples.<Type>.Valid.<Scenario>`. `<Type>` is the name of the message, component or choice
  as in the model. For a **variant of a choice** `<Scenario>` is the variant (`AccountIdentification4Choice.Valid.Other`); for **any other type** it is
  `Standard` (`CashAccount40.Valid.Standard`).
* **Every access builds a new object.** `Minimal` and `Maximal` are properties, not fields: the objects have setters, so a
  sample that was shared could be changed by one test and read by another.
* **Minimal and Maximal** are two valid shapes: `Maximal` has more members set than `Minimal`. They are not yet "only the required
  members" and "every member": the values come from the tests the samples were moved out of. `Maximal` exists only where it differs.
  A scenario with a third shape is not allowed; give it a scenario of its own.
* **Built from other samples.** `AccountIdentification4Choice.Valid.Other.Maximal` uses `AccountSchemeName1Choice.Valid.Proprietary.Minimal` for its
  scheme name, and `Party50Choice.Valid.Agent.Maximal` uses `BranchAndFinancialInstitutionIdentification8.Valid.Standard.Maximal`. A sample is written
  with `IsoDataFactory.Make<T>` (and `IsoDataFactory.With` to change a copy of another); a test never constructs a model object itself.
* **A name that is also a type of `System` gets a trailing underscore**: `Valid.DateTime_`, `Valid.Type_`. (The ones the model has are
  `DateTime`, `Decimal`, `Index`, `Range`, `Single`, `Type` and `ValueType`.)
* **Not here yet:** samples for the primitive values (simple types, code sets, amounts). Today the samples cover the choice variants of 24 choices
  and the components they need (#88).

The objects come from `IsoDataFactory.Make<T>`; see the Factory package for how to write one of your own.
