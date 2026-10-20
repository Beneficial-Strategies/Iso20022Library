# BeneficialStrategies.Iso20022.Interfaces

An interface for every ISO 20022 message, component and choice: the **shape** of each type, with no implementation. Write against the shape, and decide separately what supplies the objects: a class of your own, the ready-made records, or classes made for you at run time.

```
dotnet add package BeneficialStrategies.Iso20022.Interfaces --prerelease
```

The package depends only on [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives) (the types of the members: `Max35Text`, the code sets, the amounts). The packages are in alpha, hence `--prerelease`.

## Why this package is the nucleus

This is the contract of the family. Almost every other tool is built on **the interfaces of the ISO 20022 message shapes, not on any one implementation of them**:

* the **validators** ([FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation)) are written for `IValidator<IGroupHeader131>`, so they judge anything that implements the interface;
* the **readers** (the XML and JSON serializers, [FluentValidation.Xml](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Xml) and [FluentValidation.Payloads](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Payloads)) read a document *into an interface*, with objects the [Factory](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Factory) makes for it;
* the **Factory** writes the classes that implement them, and the **Samples** build their objects against them;
* the **saga toolkit** consumes and publishes messages typed by these interfaces;
* the **ready-made records** of [BeneficialStrategies.Iso20022](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) are just one implementation, a convenient one, and nothing above depends on them.

Because the interface is the contract and the implementation is interchangeable, **a legacy system can start to take part in an ISO 20022 architecture without being replaced.** The `Invoice`, `Payment` or `Customer` class you have had for years can implement one of these interfaces (map its members onto the interface's), and from then on the validators accept it, a consumer typed to the interface takes it, and the rest of the tooling treats it as what it now is. You adopt as much of the standard as you want, one component at a time, and keep your domain objects. Nothing in the rest of the family needs to know yours is not one of ours.

Everything else in this family implements this package or builds on it; it is the nucleus of the implementation of the standard.

Three examples, each a step further. Each uses nothing but this package.

## 1. Your own class

An interface is plain C#. Implement one in a class of your own (an entity, a DTO, a type of another message framework), and everything written against the interface works with it:

```csharp
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.SimpleTypes;

public sealed class MyIdentification : IGenericIdentification3
{
    public Max35Text Identification => "MINE-1";
    public Max35Text? Issuer => null;
}

static string Describe(IGenericIdentification3 id) => $"{id.Identification} / {id.Issuer?.ToString() ?? "no issuer"}";

Console.WriteLine(Describe(new MyIdentification()));      // MINE-1 / no issuer
```

`Max35Text` is a primitive type that holds at most 35 characters, so you cannot build a value that is too long (`"MINE-1"` converts to it implicitly). A member that is **required** is not nullable (`Identification`), one that is **optional** is (`Issuer`), and one that **may repeat** is an `IEnumerable<T>`.

## 2. A choice, and its variants

ISO 20022 has choices: an account is identified *either* by an IBAN *or* by some other identification. A choice is an interface (`IAccountIdentification4Choice`), and each variant is an interface of its own, in a namespace named for the choice, that also derives from it. Test for a variant with a type pattern:

```csharp
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.SimpleTypes;

public sealed class MyIban : IIBAN
{
    public IBAN2007Identifier Value => "DE89370400440532013000";
}

static string DescribeAccount(IAccountIdentification4Choice account) => account switch
{
    IIBAN iban => $"IBAN {iban.Value}",
    IOther other => $"account {other.Identification}",
    _ => "an account of another kind",
};

Console.WriteLine(DescribeAccount(new MyIban()));      // IBAN DE89370400440532013000
```

A choice can hold only one variant, and the type says so: an object is an `IIBAN` or an `IOther`, and you ask which.

## 3. A message, and what a reader needs to know about it

A message interface (`IFIToFICustomerCreditTransferV14`, ISO's `pacs.008.001.14`) is shaped like a component, and also says how the message is read and written: its identifier, the XML element that holds it and the namespace of its document. A reader or writer needs nothing else, so it works with **any** class that implements the interface:

```csharp
using BeneficialStrategies.Iso20022;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.pacs;

var message = IsoMessageAttribute.Find(typeof(IFIToFICustomerCreditTransferV14))!;
Console.WriteLine($"{message.IsoIdentifier}  <{message.XmlTag}>  {message.DocumentNamespace}");
// pacs.008.001.14  <FIToFICstmrCdtTrf>  urn:iso:std:iso:20022:tech:xsd:pacs.008.001.14

Console.WriteLine(Iso.KindOf(typeof(IFIToFICustomerCreditTransferV14)));   // Message
Console.WriteLine(Iso.KindOf(typeof(IGenericIdentification3)));            // Component
Console.WriteLine(Iso.KindOf(typeof(IAccountIdentification4Choice)));      // Choice
Console.WriteLine(Iso.KindOf(typeof(IIBAN)));                              // ChoiceVariant
```

`Iso.KindOf(Type)` tells the kind of any type of the model, and an interface carries a marker of its kind (`IIsoComponent`, `IIsoChoice`, `IIsoChoiceVariant`, and `IOuterRecord` for a message).

## Where the objects come from

The interfaces are only the shape. Something has to implement them, and the packages of the family differ in what:

| You want | Package | |
|---|---|---|
| a class of your own | this package | examples 1 to 3 |
| a ready-made class for every message, component and choice | [BeneficialStrategies.Iso20022](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) | the records implement these interfaces, with XML and JSON serialization |
| classes made for you, on the fly, as you ask for an interface | [BeneficialStrategies.Iso20022.Factory](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Factory) | no implementation library needed |
| the rules the types cannot express, checked on anything that implements the interface | [BeneficialStrategies.Iso20022.FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) | written for these interfaces |
| valid and invalid objects to use in tests | `BeneficialStrategies.Iso20022.Samples` | built through the Factory |

## How the interfaces are shaped

* **Namespaces are those of the records:** `IGroupHeader93` is in `BeneficialStrategies.Iso20022.Components`, a message such as `IFIToFICustomerCreditTransferV14` in its business area (`BeneficialStrategies.Iso20022.pacs`), a choice in `BeneficialStrategies.Iso20022.Choices`.
* **An interface is flat:** it lists every member of its own version and inherits nothing but the marker of its kind.
* **Nullability is the `required` of the records:** a required member is not nullable, an optional one is, and a member that may repeat is an `IEnumerable<T>`.
* **A choice is an interface and each variant derives from it:** `Choices.PartyIdentification8Choice.IBICOrBEI` derives from `IPartyIdentification8Choice`.
* **Primitive types** (`Max35Text`, code sets, amounts) are those of [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives).

Targets netstandard2.0 (.NET Framework 4.6.1+, Mono, Unity), net8.0 and net10.0.
