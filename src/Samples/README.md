# BeneficialStrategies.Iso20022.Samples

Named ISO 20022 objects for tests: valid ones, and invalid ones for known issues, built through the
[`Factory`](../Factory/README.md) against the **interfaces**. A test that needs "a valid account identification" takes one from
here and needs neither the message records (`BeneficialStrategies.Iso20022.Common`) nor ten lines of setup.

Targets netstandard2.0, net8.0 and net10.0. It is a work in progress (#88): today it holds the choice variants of 24 choices; the
rest of the model comes with the tests that use it.

## Use

```csharp
// the IBAN variant of AccountIdentification4Choice, valid
IAccountIdentification4Choice id = Samples.AccountIdentification4Choice.Valid.IBAN.Minimal;

var result = validator.TestValidate(id);   // a validator of the FluentValidation package, for example
```

## Layout

```
Samples/<Type>/Valid/<Name>.cs      a static class per sample family, with Minimal and Maximal
Samples/<Type>/Invalid/<Issue>.cs   one static class per known issue (none yet)
```

* **Namespace and name.** `BeneficialStrategies.Iso20022.Samples.<Type>.Valid.<Name>`, where `<Type>` is the type's name as in the model
  and `<Name>` is the choice variant (or, later, the scenario).
* **Every access builds a new object.** `Minimal` and `Maximal` are properties, not fields: the objects have setters, so a
  sample that was shared could be changed by one test and read by another.
* **Minimal and Maximal** are two valid shapes: `Maximal` has more members set than `Minimal`. They are not yet "only the required
  members" and "every member": the values come from the tests the samples were moved out of. `Maximal` exists only where it differs.
* **Larger samples are built from smaller ones.** `AccountIdentification4Choice.Valid.Other.Maximal` uses
  `AccountSchemeName1Choice.Valid.Proprietary.Minimal` for its scheme name.
* **A name that is also a type of `System` gets a trailing underscore**: `Valid.DateTime_`, `Valid.Type_`. (The ones the model has are
  `DateTime`, `Decimal`, `Index`, `Range`, `Single`, `Type` and `ValueType`.)

The objects come from `IsoDataFactory.Make<T>`; see the Factory package for how to write one of your own.
