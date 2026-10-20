# BeneficialStrategies.Iso20022.Primitives

The foundation of the ISO 20022 family: the **primitive data types** (text, numbers, dates, identifiers, amounts), the **code sets** and **external codes**, each refusing a value that ISO does not allow, and the **XML and JSON readers and writers** that know them. It has no message definitions at all, and depends on no other package of the family; every other package is built on it.

## Why these are types, and not strings

The best way to deal with dirty data is to stop it at the front door.

We could have made every field in ISO 20022 a `string` and moved on, as most libraries do. We chose the opposite, on purpose: a **type designed to fit the standard exactly** for every primitive in it. An amount is not text that probably holds a number; it is an `ActiveCurrencyAndAmount`, with a currency and a `decimal`, within the digits ISO allows. A country is a `CountryCode`, two upper-case letters. A name is a `Max35Text`. If a field is supposed to fit a pattern, then the pattern is burned into the type, and you cannot construct a value that does not fit.

Three things follow, and they are the reason this is the backbone of everything else:

* **Bad data has nowhere to go.** The value is checked once, at the edge, when it is built or read, and it is refused there with a message that names the type, the value and the rule. Everything behind that door, your business rules, your database, the next system, is holding data that is already right. You do not find a `"$140Yen"` where a number should be, or a date that is not a date, two weeks after it was persisted, in the back end, where the only thing left to do is guess what was meant.
* **It travels the way the standard says, and only that way.** These types do not know any other wire format. They are written and read as ISO 20022 defines them, in XML and in JSON, so what you send and what you store is compatible with the published standard and with every other system that follows it, by construction.
* **In memory it is a first-class value.** Once it is across the door, the amount is a `decimal`, the date a `DateOnly`, the code an enumeration you can `switch` on, the identifier a token that compares by value. You do your business logic on real numbers, dates and enumerations, not on text you have to convert again, and again, before you can use it. A method that takes `(ActiveCurrencyAndAmount, ChargeBearerType1Code)` cannot be called with the arguments swapped, which a method that takes two strings can.

They are assignable from strings and from the natural .NET types (a `string` to a `Max35Text`, a `DateOnly` to an `ISODate`), so using them costs you nothing at the call site. What they will not do is hold a value the standard does not allow, or travel any way but the standard's. That is what makes them structs of their own, not an alias for something looser: the type **is** the specification, in the compiler and at run time, so your infrastructure can rely on the data being compatible with the international standard and ready for the rules of your business.

## Install

```
dotnet add package BeneficialStrategies.Iso20022.Primitives --prerelease
```

The packages are in alpha, hence `--prerelease`. Three examples, each a step further, and each using nothing but this package.

## 1. Values that refuse what ISO does not allow

A primitive type is an immutable struct that can only hold a value of its ISO format, so an invalid value cannot exist: it is refused when you build it.

```csharp
using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.SimpleTypes;

Max35Text name = "Acme Corp";        // converts implicitly from a string; 1 to 35 characters
Console.WriteLine(name);              // Acme Corp

try { _ = new Max35Text(new string('x', 36)); }
catch (Iso20022FormatException ex) { Console.WriteLine($"{ex.TargetType.Name}: {ex.Violation} - {ex.Message}"); }
// Max35Text: TooLong - 'Max35Text' allows at most 35 character(s) but received 36: 'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx'.

Console.WriteLine(Max35Text.TryCreate("", out _));      // False: no exception, when you would rather ask
```

* **Simple types** (`Max35Text`, dates, identifiers, numbers): structs that refuse a value outside the ISO format by throwing `Iso20022FormatException`, which says which type, which value and which constraint (`ex.Violation`, `ex.Constraint`). `TryCreate` is the form that does not throw.
* **Code sets** are enums (`ChargeBearerType1Code.Shared` is `SHAR` on the wire), and **external codes** are structs (`ActiveCurrencyCode`, `CountryCode`) that check the format of a code whose accepted values live outside the standard:

  ```csharp
  try { _ = new ActiveCurrencyCode("eur"); }
  catch (Iso20022FormatException ex) { Console.WriteLine(ex.Message); }
  // 'eur' is not a valid ActiveCurrencyCode. ISO 20022 pattern constraint: ^[A-Z]{3}$
  ```
* **Amounts** are the currency-and-amount data types. Each refuses a value outside the limits of its ISO type: not negative, and at most so many digits in all and after the decimal point (18 and 5 for `ActiveCurrencyAndAmount`; trailing zeros do not count):

  ```csharp
  try { _ = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = -1m }; }
  catch (Iso20022FormatException ex) { Console.WriteLine(ex.Message); }
  // '-1' is not a valid ActiveCurrencyAndAmount. ISO 20022 pattern constraint: not negative
  ```

## 2. Your own class, read from and written to XML

The same types make the members of a class of your own, and the reader fills it from XML, telling you **every** problem it finds. A message is an `IOuterRecord` that carries four constants: its ISO identifier, the XML element that holds it and the namespace and root element of its document.

```csharp
using BeneficialStrategies.Iso20022.Serialization;

public class MyCustomMessage : IOuterRecord
{
    public const string IsoIdentifier = "xmpl.001.001.01";
    public const string XmlTag = "Party";
    public const string DocumentNamespace = "urn:example:xmpl.001.001.01";
    public const string DocumentElementName = "Document";

    [IsoXmlTag("Name")]
    public required Max35Text Name { get; init; }                      // at most 35 characters

    [IsoXmlTag("ChargeBearer")]
    public required ChargeBearerType1Code ChargeBearer { get; init; } // DEBT, CRED, SHAR or SLEV
}
```

`[IsoXmlTag]` says which element a member is read from, and `required` makes a missing element an error. Read some XML:

```csharp
var xml = "<Document xmlns=\"urn:example:xmpl.001.001.01\"><Party><Name>Acme Corp</Name><ChargeBearer>SHAR</ChargeBearer></Party></Document>";

DeserializationResult<MyCustomMessage> read = Iso20022XmlSerializer.TryRead<MyCustomMessage>(xml);

if (read.Succeeded)
    Console.WriteLine($"read: {read.Message!.Name} pays {read.Message.ChargeBearer}");   // read: Acme Corp pays Shared
else
    foreach (var issue in read.Issues)
        Console.WriteLine($"{issue.Code} {issue.Path}: {issue.Reason}");
```

With a name of 61 characters and a charge bearer that is not a code:

```
FacetViolation Document/Party/Name: 'Max35Text' allows at most 35 character(s) but received 61: 'A name that is a good deal longer than thirty-f...'.
BadValue Document/Party/ChargeBearer: 'FREE' is not a value of ChargeBearerType1Code. Expected one of: DEBT, CRED, SHAR, SLEV.
```

Nothing is thrown: the result is the message or the list of problems, each with the path of the element, its kind (`MalformedXml`, `WrongRoot`, `RequiredMissing`, `BadValue`, `FacetViolation`, `UnexpectedElement`, ...) and, for malformed XML, the line and position. `Iso20022XmlSerializer` also has `TryRead` for a `XDocument` and `Read` for an `XElement` (any part of a document, with a `ReadContext` when it is a fragment), `Deserialize` and `TryDeserialize` if you prefer exceptions or a `bool`, and writes a message back:

```csharp
var mine = new MyCustomMessage { Name = "Acme Corp", ChargeBearer = ChargeBearerType1Code.Shared };
Console.WriteLine(Iso20022XmlSerializer.SerializeToString(mine));
```
```xml
<Document xmlns="urn:example:xmpl.001.001.01">
  <Party>
    <Name>Acme Corp</Name>
    <ChargeBearer>SHAR</ChargeBearer>
  </Party>
</Document>
```

To turn those problems into FluentValidation failures instead, see [BeneficialStrategies.Iso20022.FluentValidation.Xml](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Xml).

## 3. And as JSON

The same class has a JSON form, with the ISO naming (`snake_case` property names, the wire codes of the code sets):

```csharp
var json = Iso20022JsonSerializer.SerializeToString(mine);
Console.WriteLine(json);                                         // {"name":"Acme Corp","charge_bearer":"SHAR"}

Iso20022JsonSerializer.TryDeserialize<MyCustomMessage>(json, out var back, out var error);          // true: back.Name is Acme Corp
Iso20022JsonSerializer.TryDeserialize<MyCustomMessage>("{\"name\":\"Acme Corp\",\"charge_bearer\":\"FREE\"}", out _, out error);
Console.WriteLine(error!.Message);                               // Unknown ChargeBearerType1Code value: 'FREE'
```

`TryDeserialize` never throws for bad input: a value that breaks its type is a `JsonException`, with the JSON path in its `Path`. For a class that is not a message, `Iso20022PrimitiveJsonOptions.Default` carries the converters of the primitive types, for use with `System.Text.Json` directly.

## What else is in this package

Besides the types and the readers, this package holds the small contracts the rest of the family agrees on:

* **The kinds of ISO type and how to tell them apart:** `IIsoComponent`, `IIsoChoice`, `IIsoChoiceVariant`, `IOuterRecord` and the attributes (`[IsoId]`, `[IsoXmlTag]`, `[IsoMessage]`, `[IsoAmount]`); `Iso.KindOf(Type)` answers for any type of the model.
* **`IIsoDataFactory`**, the abstraction that makes an object for an interface, which is how a reader fills an *interface* instead of a class (the [Interfaces](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Interfaces) package has the interfaces, and [Factory](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Factory) makes the objects).
* **The collection types** (`ValueList<T>`, `SimpleValueList<T>`), and the **`Iso20022MessageTypeRegistry`**, which finds a message type from a namespace or an ISO identifier.

## Where to go from here

| You want | Package |
|---|---|
| the shape of every ISO 20022 message, component and choice, so a class of yours can stand in for one | [BeneficialStrategies.Iso20022.Interfaces](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Interfaces) |
| a ready-made class for every message | [BeneficialStrategies.Iso20022](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) (depends on this package; same namespaces) |
| the rules the types cannot express, as FluentValidation validators | [BeneficialStrategies.Iso20022.FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) |

## Frameworks

net8.0, net10.0 and **netstandard2.0**, so the primitives can be used from .NET Framework 4.6.1 and later, Mono 5.4 and later, Xamarin and Unity (the records package is net8.0 and net10.0 only). The `netstandard2.0` build depends on `System.Text.Json`, `Portable.System.DateTimeOnly` (the `DateOnly` and `TimeOnly` types that `ISODate` and `ISOTime` use) and `Microsoft.Bcl.HashCode`.
