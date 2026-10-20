# BeneficialStrategies.Iso20022.Factory

Read ISO 20022 messages into their **interfaces** without the message records. The package builds, at run time, a small sealed
class for each interface you ask for (a message, a component, a choice variant) and gives it to the reader to fill. You depend on
`Primitives` and on whatever supplies the interfaces; you do not depend on `BeneficialStrategies.Iso20022.Common`
(3,339 messages' worth of records).

Targets netstandard2.0, net8.0 and net10.0.

## Use

```csharp
var factory = new IsoDataFactory();

var result = Iso20022XmlSerializer.TryRead<IFIToFICustomerCreditTransferV14>(xml, factory);
if (result.Succeeded)
    IFIToFICustomerCreditTransferV14 message = result.Message;   // an object of a class built for the interface
else
    foreach (var issue in result.Issues) Console.WriteLine(issue);   // every problem, with its path
```

The object is a normal value: its members are the interface's, `Equals` and `GetHashCode` compare the members (and lists by
their items), `ToString` shows them, the validators of the `FluentValidation` package accept it (`IValidator<IFoo>`), and the
serializer writes it back to the same XML.

## Making an object by hand

For a test or a sample, `IsoDataFactory.Make<T>` makes an object for an interface and sets its members. The interface has no
setters, so each member is named with a lambda and then given its value (two steps, so that the value converts to the member's
type as it does for a record: `"MSG-1"` to a `Max35Text`).

```csharp
var id = IsoDataFactory.Make<IGenericIdentification3>(b => b
    .Set(x => x.Identification).To("ID-1")
    .Set(x => x.Issuer).To("BANK"));
```

A member that is not named stays unset (a list is empty). `new IsoBuilder<T>` is not public: use `Make`, which builds with
`IsoDataFactory.Shared`. The `Samples` package holds named objects made this way.

## Dependency injection

```csharp
services.AddIso20022Factory(typeof(IFIToFICustomerCreditTransferV14), typeof(IBankToCustomerStatementV08));
```

registers one `IsoDataFactory` (also as `IIsoDataFactory`) and, in a host, builds the classes for those messages and everything
they reach when the host starts. Without a host, call `factory.Warm(typeof(IFoo), ...)` yourself at startup.

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
