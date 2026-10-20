# BeneficialStrategies.Iso20022.Samples

**Named ISO 20022 objects for your tests.** When a test needs "a valid account identification", "a valid cash account" or, in time, "a valid payment message", it takes one from here instead of building it by hand: no ten lines of setup, no message records to install, and the same object every time.

The samples are built against the **interfaces** of the model ([BeneficialStrategies.Iso20022.Interfaces](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Interfaces)), the contract the rest of the family is written to, with the objects made by the [Factory](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Factory). So a sample works with anything that takes the interface: the validators, a consumer of a message bus, a method of your own.

```
dotnet add package BeneficialStrategies.Iso20022.Samples --version 0.7.0-alpha
```

It depends on `Primitives`, `Interfaces` and `Factory`, not on the message records, and targets netstandard2.0, net8.0 and net10.0. The package is in alpha and **not on NuGet yet**; the samples that exist today cover 24 choices and the components they need (see [What is here](#what-is-here-and-what-is-coming)). Three examples, each a step further.

## 1. Take a sample

A sample is a static property. Its path says what it is: the type, `Valid`, the scenario, and how much of it is filled.

```csharp
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using Samples = BeneficialStrategies.Iso20022.Samples;

// a valid account identification, the IBAN variant of the choice
IAccountIdentification4Choice id = Samples.AccountIdentification4Choice.Valid.IBAN.Minimal;

Console.WriteLine(id);                              // IIBAN_1 { Value = DE89370400440532013000 }
if (id is IIBAN iban) Console.WriteLine($"IBAN {iban.Value}");     // IBAN DE89370400440532013000
```

**Every access builds a new object**, so a test can never change what another test reads: the objects have setters (the Factory's classes need them), and a shared sample would be a shared variable.

```csharp
var again = Samples.AccountIdentification4Choice.Valid.IBAN.Minimal;
Console.WriteLine($"{ReferenceEquals(id, again)} {id.Equals(again)}");   // False True: two objects, equal by value
```

## 2. Samples are built from samples

A bigger sample is made of the samples of its parts. A valid cash account contains a valid account identification:

```csharp
using BeneficialStrategies.Iso20022.Components;

ICashAccount40 account = Samples.CashAccount40.Valid.Standard.Minimal;
Console.WriteLine(((IIBAN)account.Identification!).Value);          // DE89370400440532013000: the IBAN sample of example 1
```

Most scenarios have two shapes: **`Minimal`** has few members set, **`Maximal`** more. They are both valid, and the second is there for the test that needs the optional parts:

```csharp
var small = Samples.AccountIdentification4Choice.Valid.Other.Minimal;
var large = Samples.AccountIdentification4Choice.Valid.Other.Maximal;
Console.WriteLine($"{small.Identification} scheme={(small.SchemeName is null ? "none" : "set")}");   // ACCT-001 scheme=none
Console.WriteLine($"{large.Identification} scheme={(large.SchemeName is null ? "none" : "set")}");   // ACCT-001 scheme=set
```

The scheme name of the `Maximal` is itself a sample (`AccountSchemeName1Choice.Valid.Proprietary.Minimal`), so a message's `Minimal` is made of the `Minimal` of its header and its parts, all the way down.

## 3. In a test

A sample is an ordinary object of the interface, so it goes wherever the interface does. With the validators of [BeneficialStrategies.Iso20022.FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation):

```csharp
var validator = provider.GetRequiredService<IValidator<IAccountIdentification4Choice>>();   // from services.AddIso20022Validators()

Assert.True(validator.Validate(Samples.AccountIdentification4Choice.Valid.Other.Maximal).IsValid);
```

When a test needs a **variation** of a sample, copy it and change what the test is about. The sample itself is untouched:

```csharp
using BeneficialStrategies.Iso20022.Factory;

var changed = IsoDataFactory.With(Samples.AccountIdentification4Choice.Valid.Other.Minimal, b => b
    .Set(x => x.Identification).To("OTHER-2"));

Console.WriteLine(changed.Identification);                                              // OTHER-2
Console.WriteLine(Samples.AccountIdentification4Choice.Valid.Other.Minimal.Identification);   // ACCT-001
```

## The standard for samples

Every sample follows one pattern, so a sample is found by its name:

```
Samples/<Type>/Valid/<Scenario>.cs     a static class per scenario, with Minimal and (where it differs) Maximal
Samples/<Type>/Invalid/<Issue>.cs      one static class per known issue
```

* **Namespace and name:** `BeneficialStrategies.Iso20022.Samples.<Type>.Valid.<Scenario>`. `<Type>` is the name of the message, component or choice as in the model. For a **variant of a choice**, `<Scenario>` is the variant (`AccountIdentification4Choice.Valid.Other`); for **any other type** it is `Standard` (`CashAccount40.Valid.Standard`).
* **`Minimal` and `Maximal`:** two valid shapes; `Maximal` has more members set, and exists only where it differs from `Minimal`. They are not yet "only the required members" and "every member", see below.
* **Properties, not fields,** so each access builds a new object.
* **Built from other samples,** with `IsoDataFactory.Make<T>` (and `IsoDataFactory.With` to change a copy of another); a sample makes objects of the interfaces only that way.
* **A name that is also a type of `System` gets a trailing underscore:** `Valid.DateTime_`, `Valid.Type_` (the ones the model has are `DateTime`, `Decimal`, `Index`, `Range`, `Single`, `Type` and `ValueType`).

## What is here, and what is coming

Today: the variants of 24 choices (`AccountIdentification4Choice`, `AmountType4Choice`, `Party50Choice`, ...) and the components they need (`CashAccount40`, `PostalAddress27`, ...). The values in them are those of the tests they were moved out of, so `Minimal` is "few members" and `Maximal` is "more members", not yet "only the required members" and "every member" in the sense of the model.

Coming, as the tests that use them are moved onto the samples: the rest of the messages, components and choices; samples for the **primitive values** (simple types, code sets, amounts); the `Invalid` samples, one class for each known issue, which the validators' own tests use; and, for the whole model, `Minimal` and `Maximal` generated from the interfaces.
