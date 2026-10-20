# BeneficialStrategies.Iso20022.FluentValidation.Xml

Read ISO 20022 XML into an object and validate it in one call. You get your object, populated, **or** every problem found, in the same `ValidationResult` FluentValidation always gives you, each with the path of the XML element it is about.

The package is built so that you take only what you need. Three examples, each adding one thing:

1. [Your own class](#1-your-own-class): nothing but this package.
2. [The full library of messages](#2-the-full-library-of-messages): the ready-made classes for every ISO 20022 message.
3. [Without the classes: the Factory](#3-without-the-classes-the-factory): you want a message's shape, not 3,339 implementations of it.

The packages are in alpha, hence `--prerelease` in the commands.

## 1. Your own class

You do not need the ISO 20022 message library to use this. You need a class of your own whose members are ISO 20022 primitive types, and the XML to read into it.

```
dotnet add package BeneficialStrategies.Iso20022.FluentValidation.Xml --prerelease
```

That brings `BeneficialStrategies.Iso20022.Primitives` (the ISO primitive types, code sets and the XML reader) and FluentValidation. Nothing else.

```csharp
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.SimpleTypes;
using BeneficialStrategies.Iso20022.Validation;
using FluentValidation;
using FluentValidation.Results;

public class MyCustomClass
{
    [IsoXmlTag("Name")]
    public required Max35Text Name { get; init; }                  // a primitive type: at most 35 characters

    [IsoXmlTag("ChargeBearer")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }   // a code set: DEBT, CRED, SHAR or SLEV
}

// An ordinary FluentValidation validator. Put rules of your own in it; the ISO rules of the types are already enforced as the XML is read.
public class MyCustomClassValidator : AbstractValidator<MyCustomClass> { }
```

Read some XML into it:

```csharp
var xml = XElement.Parse("<Party><Name>Acme Corp</Name><ChargeBearer>SHAR</ChargeBearer></Party>");

ValidationResult result = new MyCustomClassValidator().Validate(xml, out MyCustomClass? mine);

if (result.IsValid)
    Console.WriteLine($"{mine!.Name} pays {mine.ChargeBearer}");            // Acme Corp pays Shared
else
    foreach (var failure in result.Errors)
        Console.WriteLine($"{failure.ErrorCode} {failure.PropertyName}: {failure.ErrorMessage}");
```

With bad XML, `mine` is `null` and `result` lists **every** problem, not only the first:

```
<Party><Name>A name that is a good deal longer than thirty-five characters</Name><ChargeBearer>FREE</ChargeBearer></Party>

Xml.FacetViolation Party/Name: 'Max35Text' allows at most 35 character(s) but received 61: 'A name that is a good deal longer than thirty-f...'.
Xml.BadValue Party/ChargeBearer: 'FREE' is not a value of ChargeBearerType1Code. Expected one of: DEBT, CRED, SHAR, SLEV.
```

```
<Party><Name>Acme Corp</Name></Party>

Xml.RequiredMissing Party/ChargeBearer: Required element <ChargeBearer> is missing.
```

What made that work: `[IsoXmlTag]` says which element a member is read from; `required` makes a missing element an error; and the types `Max35Text` and `ChargeBearerType1Code` carry their ISO format rules with them, so they are checked while reading. Declare the `out` variable **with its type** (`out MyCustomClass? mine`; `out var mine` does not compile): that is how the reader knows what to build.

## 2. The full library of messages

You would rather not write the classes: ISO 20022 has thousands of them. The message library has every message, component and choice as a ready-made C# class, and the validators of ISO's own rules for them.

```
dotnet add package BeneficialStrategies.Iso20022 --prerelease
dotnet add package BeneficialStrategies.Iso20022.FluentValidation --prerelease
```

`BeneficialStrategies.Iso20022` is the message classes; `.FluentValidation` is the validators. The validators are written for the **interfaces** of the messages (`IValidator<IFIToFIPaymentCancellationRequestV10>`), so you pick the class to read into with the `out` variable:

```csharp
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Validation;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddIso20022Validators();                       // from BeneficialStrategies.Iso20022.FluentValidation
using var provider = services.BuildServiceProvider();

var validator = provider.GetRequiredService<IValidator<IFIToFIPaymentCancellationRequestV10>>();

ValidationResult result = validator.Validate(xml, out FIToFIPaymentCancellationRequestV10? message);

if (result.IsValid)
    Console.WriteLine(message!.Assignment.Identification);      // DEUTDEFF/240316/CAMT056/00001
else
    foreach (var failure in result.Errors)
        Console.WriteLine($"{failure.ErrorCode} {failure.PropertyName}: {failure.ErrorMessage}");
```

`xml` is a camt.056.001.10 document as text. If its `<Id>` is longer than 35 characters:

```
Xml.FacetViolation Document/FIToFIPmtCxlReq/Assgnmt/Id: 'Max35Text' allows at most 35 character(s) but received 58: 'DEUTDEFF/240316/CAMT056/00001/A-REFERENCE-THAT-...'.
```

`FIToFIPaymentCancellationRequestV10` is the class of the message library, and `message` is an instance of it. The two type arguments of the call, the interface and the class, are inferred from the validator and the `out` variable. A class that does not implement the interface does not compile.

## 3. Without the classes: the Factory

The message library is large, and perhaps you do not want 3,339 messages' worth of classes in your application. You want to read a message and get an object that has the message's shape, nothing more. The **Factory** builds that class for you, on the fly, the first time it is asked for a message interface, so no implementation library is needed at all.

```
dotnet add package BeneficialStrategies.Iso20022.Interfaces --prerelease
dotnet add package BeneficialStrategies.Iso20022.FluentValidation --prerelease
dotnet add package BeneficialStrategies.Iso20022.Factory --prerelease
```

`.Interfaces` has an interface for every message, component and choice and no implementation (`.FluentValidation` brings it too; it is listed because it is what you program against). `.Factory` makes the objects.

```csharp
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.Validation;

var factory = new IsoDataFactory();      // or the singleton from services.AddIso20022Factory(...)

ValidationResult result = validator.Validate(xml, factory, out IFIToFIPaymentCancellationRequestV10? message);

if (result.IsValid)
    Console.WriteLine(message!.Assignment.Identification);      // DEUTDEFF/240316/CAMT056/00001
```

`validator` is the same one as in example 2, and the result and the failures mean the same. The difference is that you name **no class**: you ask for the interface, and the factory supplies an object of a class it wrote for the occasion (`message.GetType().Name` is something like `IFIToFIPaymentCancellationRequestV10_1`). It is a normal value: its members are the interface's, two of them with the same content are equal, `ToString` shows them, and the serializer can write it back to XML. Because the validators are written for the interfaces, they accept it as they accept the records.

This package depends only on the `IIsoDataFactory` abstraction in `Primitives`, so a factory of your own works as well.

## What you get back

| The XML | `result` | the object |
|---|---|---|
| could not be read (malformed, wrong root, a required element missing, a bad value, …) | **every** problem found, not only the first. `ErrorCode` is `Xml.` + the kind (`Xml.RequiredMissing`, `Xml.BadValue`, `Xml.FacetViolation`, `Xml.UnexpectedElement`, `Xml.MalformedXml`, …), `PropertyName` the XML path, `CustomState` the `DeserializationIssue` with the line and position | `null`. The rules do not run, because they would judge a half-built object |
| could be read, and the rules pass | valid | the object |
| could be read, and a rule fails | the rule failures, `PropertyName` the property path | **the object**, so you can log or inspect it |

`result.IsValid` says whether the whole thing passed. A `PropertyName` is an XML path for a reading problem and a property path for a rule; the `Xml.` prefix of the error code tells them apart.

## More ways to call it

* The same methods take an `XDocument`, an `XElement` or text, and have async forms (`ValidateAsync`, returning the result and the object).
* An `XElement` can be any part of a document: validate a component such as `IValidator<INameAndAddress5>` on its own element. When it is a fragment of a larger document, pass a `ReadContext` with the namespace and a path prefix so that the paths in the failures are the paths of the whole document.
* For validation inside a container (envelope validators, a dispatcher that finds the message type from the XML itself), see [BeneficialStrategies.Iso20022.FluentValidation.Payloads](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Payloads), which builds on this package.

## Dependencies and targets

* Depends on [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives) (the reader is there) and FluentValidation. Not on the interfaces, not on the message classes, not on dependency injection: those come with the examples above, when you want them.
* Targets netstandard2.0 (.NET Framework 4.6.1+, Mono, Unity), net8.0 and net10.0.
