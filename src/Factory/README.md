# BeneficialStrategies.Iso20022.Factory

**Objects for the ISO 20022 interfaces, made for you.** Ask for an interface (a message, a component, a choice variant) and the Factory builds, at run time, a small sealed class that implements it, fills it from XML or JSON, and gives it to you. You never write the implementation, and you do not install one: no message records, no [BeneficialStrategies.Iso20022](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) with its 3,339 messages' worth of classes.

It rests on the idea behind the whole family: the **interfaces are the contract** ([BeneficialStrategies.Iso20022.Interfaces](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Interfaces)), and the tools (validators, readers, queue consumers) are written against them, not against any one implementation. The records are one implementation, a class of your own is another, and the Factory is the one that appears when you ask.

```
dotnet add package BeneficialStrategies.Iso20022.Factory --version 0.7.0-alpha
```

It depends only on [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives), and targets netstandard2.0, net8.0 and net10.0. The packages are in alpha, so the commands name the version. Four examples, each a step further.

## 1. Your own interface

The Factory is not specific to ISO's own messages: it makes an object for any interface that follows the pattern. Here, an interface of your own, with the primitive types for members:

```csharp
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.Serialization;
using BeneficialStrategies.Iso20022.SimpleTypes;

[IsoMessage("xmpl.001.001.01", "Party", "urn:example:xmpl.001.001.01")]   // identifier, element, namespace of the document
public interface IMyMessage : IOuterRecord
{
    [IsoXmlTag("Name")] Max35Text Name { get; }                      // at most 35 characters
    [IsoXmlTag("ChargeBearer")] ChargeBearerType1Code ChargeBearer { get; }   // DEBT, CRED, SHAR or SLEV
}
```

There is no class that implements `IMyMessage`, and you do not write one. Give the reader a factory:

```csharp
var factory = new IsoDataFactory();

var xml = "<Document xmlns=\"urn:example:xmpl.001.001.01\"><Party><Name>Acme Corp</Name><ChargeBearer>SHAR</ChargeBearer></Party></Document>";

var result = Iso20022XmlSerializer.TryRead<IMyMessage>(xml, factory);

if (result.Succeeded)
{
    IMyMessage party = result.Message!;                    // an object of a class built for the interface
    Console.WriteLine($"{party.Name} pays {party.ChargeBearer}");   // Acme Corp pays Shared
}
else
    foreach (var issue in result.Issues)
        Console.WriteLine(issue);                          // every problem, with its path
```

The object is a normal value: its members are the interface's, `Equals` and `GetHashCode` compare the members (and lists by their items), `ToString` shows them (`IMyMessage_1 { Name = Acme Corp, ChargeBearer = Shared }`), and the serializer writes it back to the same XML:

```csharp
Console.WriteLine(Iso20022XmlSerializer.SerializeToString(party));
```
```xml
<Document xmlns="urn:example:xmpl.001.001.01">
  <Party>
    <Name>Acme Corp</Name>
    <ChargeBearer>SHAR</ChargeBearer>
  </Party>
</Document>
```

## 2. A message of the library

Now the interfaces of ISO's own messages. Add the package that has them, and ask for one:

```
dotnet add package BeneficialStrategies.Iso20022.Interfaces --version 0.7.0-alpha
```

```csharp
using BeneficialStrategies.Iso20022.camt;

var result = Iso20022XmlSerializer.TryRead<IFIToFIPaymentCancellationRequestV10>(xml, factory);   // xml: a camt.056.001.10 document

if (result.Succeeded)
    Console.WriteLine(result.Message!.Assignment.Identification);   // DEUTDEFF/240316/CAMT056/00001
```

Everything about it is as in example 1, for a message with a deep tree of components: it reads, compares by value, and writes back to XML that reads into an equal object. Nothing was written and no implementation library was installed. If the document is wrong, the result lists every problem and no object is made:

```
Document/FIToFIPmtCxlReq/Assgnmt/Id: RequiredMissing: Required element <Id> is missing. (line 24, position 6)
```

The validators of [BeneficialStrategies.Iso20022.FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) are written for the interfaces, so they accept the object (`IValidator<IFIToFIPaymentCancellationRequestV10>`). To read XML and validate it in one call, or queue payloads, see [FluentValidation.Xml](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Xml) and [FluentValidation.Payloads](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Payloads), which take the factory too.

## 3. In an application: dependency injection

```csharp
services.AddIso20022Factory(typeof(IFIToFIPaymentCancellationRequestV10), typeof(IBankToCustomerStatementV08));
```

registers one `IsoDataFactory` (also as `IIsoDataFactory`) and, in a host, builds the classes for those messages and everything they reach when the host starts, so no read pays for building a class. Without a host, call `factory.Warm(typeof(IFoo), ...)` yourself at startup. The factory is thread-safe, and what it builds is shared by every factory in the process.

## 4. Making an object by hand

For a test or a sample you want an object without reading anything. `IsoDataFactory.Make<T>` makes one for an interface and sets its members. The interface has no setters, so each member is named with a lambda and then given its value (two steps, so that the value converts to the member's type as it does for a record: `"ID-1"` to a `Max35Text`):

```csharp
var id = IsoDataFactory.Make<IGenericIdentification3>(b => b
    .Set(x => x.Identification).To("ID-1")
    .Set(x => x.Issuer).To("BANK"));

var other = IsoDataFactory.With(id, b => b.Set(x => x.Identification).To("ID-2"));   // a copy, one member changed
Console.WriteLine($"{id.Identification} {other.Identification} {id.Issuer}");         // ID-1 ID-2 BANK
```

`IsoDataFactory.With` is the counterpart of a record's `with`: a copy of an object (of the factory, or a record) with the named members changed; the source is not touched. A member that is not named stays unset (a list is empty). `Make` and `With` build with `IsoDataFactory.Shared`. `BeneficialStrategies.Iso20022.Samples` holds named valid objects made this way, for tests.

## What it costs

* **Building a class** takes about 0.1 millisecond. A class is built once per interface for the life of the process and shared by
  every factory. Measured on this library: the 131 interfaces that pacs.008 reaches build in about 11 ms, the 219 of camt.053 in
  about 27 ms, plus a one-time walk of the message's shape of under 0.2 s. `Warm` moves all of it to startup.
* **Reading** costs what reading into a record costs; an object made by the factory is an ordinary object, with no proxy, no
  interception and no per-instance overhead beyond its fields.
* **Memory:** the built classes cannot be unloaded. Warm only the messages you read. (Building all 17,939 interfaces of the library
  takes minutes and over a gigabyte; there is no reason to.)

## When not to use it

* **Native AOT and trimmed apps:** `System.Reflection.Emit` is not available. Read into the records of `Common` instead.
* **You want `with`, pattern matching on a concrete type or `new Message { ... }`:** use the records. The factory's classes exist
  to be read into and then used through the interface.
* The interface must be public (a nested public interface is fine).

## Your own factory

`IIsoDataFactory` is one method, `object Create(Type iface)`: return an object of a class of yours that implements the interface
and has a public setter for each of its properties. The reader does the rest.
