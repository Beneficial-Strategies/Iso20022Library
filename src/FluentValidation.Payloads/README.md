# BeneficialStrategies.Iso20022.FluentValidation.Payloads

Validate raw ISO 20022 **XML or JSON text**, the way it arrives: off a message queue, out of an HTTP body, from a file. The payload is read, then validated, and a payload that cannot be read is not an exception: its problems come back as ordinary FluentValidation failures, in the same `ValidationResult` as your rules.

Two building blocks, depending on whether you know the message type up front:

* **An envelope validator**, `IValidator<XmlEnvelope<TMessage>>` or `IValidator<JsonEnvelope<TMessage>>`, when the type is known at the call site (a queue bound to one message type). It is just another `IValidator<T>`.
* **The dispatcher**, `IIso20022PayloadValidationDispatcher`, when the payload could be any of several message types and its own content says which (the namespace of the XML document, or the ISO identifier you pass for JSON).

Three examples, each adding one thing to what you reference:

1. [Your own message](#1-your-own-message): nothing but this package.
2. [The full library of messages](#2-the-full-library-of-messages): the ready-made classes and validators for every ISO 20022 message.
3. [Without the classes: the Factory](#3-without-the-classes-the-factory): you want the message's shape, not 3,339 implementations of it.

The packages are in alpha, hence `--prerelease` in the commands.

## 1. Your own message

You do not need the ISO 20022 message library, or its validators. You need a message class of your own whose members are ISO 20022 primitive types, and a validator for it.

```
dotnet add package BeneficialStrategies.Iso20022.FluentValidation.Payloads --prerelease
```

That brings the ISO primitive types and the readers (`BeneficialStrategies.Iso20022.Primitives`), [`BeneficialStrategies.Iso20022.FluentValidation.Xml`](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Xml), FluentValidation and the dependency-injection abstractions. Nothing else. (You also need a container; `Microsoft.Extensions.DependencyInjection` below, or the one of your host.)

A message is an `IOuterRecord` that carries the four constants a reader needs, the same four every record of the message library carries:

```csharp
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.SimpleTypes;
using FluentValidation;

public class MyCustomMessage : IOuterRecord
{
    public const string IsoIdentifier = "xmpl.001.001.01";            // the ISO message identifier
    public const string XmlTag = "Party";                             // the element that holds the message in the document
    public const string DocumentNamespace = "urn:example:xmpl.001.001.01";
    public const string DocumentElementName = "Document";

    [IsoXmlTag("Name")]
    public required Max35Text Name { get; init; }                     // a primitive type: at most 35 characters

    [IsoXmlTag("ChargeBearer")]
    public required ChargeBearerType1Code ChargeBearer { get; init; } // a code set: DEBT, CRED, SHAR or SLEV
}

// An ordinary FluentValidation validator, with the rules of your own. The rules of the types are enforced as the payload is read.
public class MyCustomMessageValidator : AbstractValidator<MyCustomMessage>
{
    public MyCustomMessageValidator() =>
        RuleFor(m => m.ChargeBearer).Equal(ChargeBearerType1Code.Shared).WithMessage("Charges must be shared.");
}
```

Register your validator, then the payload validators, which add an XML and a JSON envelope validator for **every message that has a validator registered**:

```csharp
using BeneficialStrategies.Iso20022.Validation;
using BeneficialStrategies.Iso20022.Validation.Payloads;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IValidator<MyCustomMessage>, MyCustomMessageValidator>();   // yours first
services.AddIso20022PayloadValidators();
using var provider = services.BuildServiceProvider();

var validator = provider.GetRequiredService<IValidator<XmlEnvelope<MyCustomMessage>>>();

var xml = "<Document xmlns=\"urn:example:xmpl.001.001.01\"><Party><Name>Acme Corp</Name><ChargeBearer>SHAR</ChargeBearer></Party></Document>";
var result = validator.Validate(new XmlEnvelope<MyCustomMessage>(xml));

if (!result.IsValid)
    foreach (var error in result.Errors)
        Console.WriteLine($"{error.ErrorCode} {error.PropertyName}: {error.ErrorMessage}");
```

Valid XML gives no output. With the charge bearer `DEBT`, your rule speaks; with `FREE`, which is not a code, the reader does, with the path of the element:

```
EqualValidator ChargeBearer: Charges must be shared.
Xml.BadValue Document/Party/ChargeBearer: 'FREE' is not a value of ChargeBearerType1Code. Expected one of: DEBT, CRED, SHAR, SLEV.
```

JSON is the same with `JsonEnvelope<MyCustomMessage>`. The names are the property names in `snake_case`:

```csharp
var jsonValidator = provider.GetRequiredService<IValidator<JsonEnvelope<MyCustomMessage>>>();
var jsonResult = jsonValidator.Validate(new JsonEnvelope<MyCustomMessage>("{\"name\":\"Acme Corp\",\"charge_bearer\":\"FREE\"}"));
```
```
JsonParseError Json: JSON could not be parsed as MyCustomMessage: Unknown ChargeBearerType1Code value: 'FREE'
```

**When you do not know the type.** The dispatcher looks at the payload, finds your message class by its `DocumentNamespace` (XML) or `IsoIdentifier` (JSON), reads it, runs its validator and hands the message back:

```csharp
services.AddIso20022PayloadValidationDispatcher();      // next to AddIso20022PayloadValidators()
// ...
var dispatcher = provider.GetRequiredService<IIso20022PayloadValidationDispatcher>();

Iso20022PayloadValidationResult dispatched = dispatcher.ValidateXml(xml);
// dispatched.IsValid, dispatched.MessageType (typeof(MyCustomMessage)), dispatched.Message (a MyCustomMessage, as object)

dispatched = dispatcher.ValidateJson("{\"name\":\"Acme Corp\",\"charge_bearer\":\"SHAR\"}", "xmpl.001.001.01");
```

For a namespace it does not know:

```
UnknownMessageType $root: Unrecognized ISO 20022 document namespace 'urn:example:something.else'.
```

## 2. The full library of messages

You would rather not write the classes or their rules: the message library has every ISO 20022 message as a ready-made class, and the validators of ISO's own rules for them.

```
dotnet add package BeneficialStrategies.Iso20022 --prerelease
dotnet add package BeneficialStrategies.Iso20022.FluentValidation --prerelease
```

`BeneficialStrategies.Iso20022` is the message classes; `.FluentValidation` is the validators. Register the validators of the messages you handle (`rootTypes`) and then the payload validators:

```csharp
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Validation;
using BeneficialStrategies.Iso20022.Validation.Payloads;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddIso20022Validators(rootTypes: [typeof(FIToFIPaymentCancellationRequestV10)]);   // and the other messages you handle
services.AddIso20022PayloadValidators();
services.AddIso20022PayloadValidationDispatcher();
using var provider = services.BuildServiceProvider();
```

**Known type.** A queue consumer bound to exactly one message type validates each body as it arrives, XML or JSON:

```csharp
public sealed class CancellationQueueHandler(IValidator<JsonEnvelope<FIToFIPaymentCancellationRequestV10>> validator)
{
    public void Handle(string messageBody)
    {
        var result = validator.Validate(new JsonEnvelope<FIToFIPaymentCancellationRequestV10>(messageBody));
        if (!result.IsValid)
        {
            foreach (var error in result.Errors)
                Console.WriteLine($"{error.ErrorCode} {error.PropertyName}: {error.ErrorMessage}");
            return;   // dead-letter, nack, ... whatever your queue client calls for
        }
        // ...
    }
}
```

Malformed JSON and a value that breaks its type are failures like any other, in the same list, with no separate `catch`:

```
JsonParseError Json: JSON could not be parsed as FIToFIPaymentCancellationRequestV10: 'Max35Text' allows at most 35 character(s) but received 58: 'DEUTDEFF/240316/CAMT056/00001/A-REFERENCE-THAT-...'.
```

The validator says the body is valid but, like any `IValidator<T>`, does not hand the object back; if you need it, read it with `Iso20022JsonSerializer.Deserialize<T>` (or use the dispatcher, which returns it).

**Type unknown.** A queue that carries any of several message types is read by the dispatcher, which finds the type from the payload and returns the message:

```csharp
var dispatcher = provider.GetRequiredService<IIso20022PayloadValidationDispatcher>();

Iso20022PayloadValidationResult result = dispatcher.ValidateXml(xmlBody);

if (!result.IsValid)
{
    foreach (var error in result.ValidationResult.Errors)
        Console.WriteLine($"{error.ErrorCode} {error.PropertyName}: {error.ErrorMessage}");
    return;
}

switch (result.Message)   // typed as object: the type was only known once the payload was read
{
    case FIToFIPaymentCancellationRequestV10 request:
        Console.WriteLine(request.Assignment.Identification);   // DEUTDEFF/240316/CAMT056/00001
        break;
    // a case for each message you registered
}
```

For XML, **every** problem is reported, not only the first. The error code is `Xml.` + the kind (`Xml.MalformedXml`, `Xml.WrongRoot`, `Xml.RequiredMissing`, `Xml.BadValue`, `Xml.FacetViolation`, `Xml.UnexpectedElement`, ...), `PropertyName` is the XML path and `CustomState` is the `DeserializationIssue` with the line and position:

```
Xml.FacetViolation Document/FIToFIPmtCxlReq/Assgnmt/Id: 'Max35Text' allows at most 35 character(s) but received 58: 'DEUTDEFF/240316/CAMT056/00001/A-REFERENCE-THAT-...'.
```

## 3. Without the classes: the Factory

The message library is large, and perhaps you do not want 3,339 messages' worth of classes in your application. Register a factory, and the XML is read into the message's **interface**: the factory builds, on the fly, a small class that implements it, and no implementation library is needed at all.

```
dotnet add package BeneficialStrategies.Iso20022.Interfaces --prerelease
dotnet add package BeneficialStrategies.Iso20022.FluentValidation --prerelease
dotnet add package BeneficialStrategies.Iso20022.Factory --prerelease
```

(`.FluentValidation` brings `.Interfaces`; it is listed because it is what you program against.) Register the factory, then the validators of the interfaces, then the payload validators (which look at what is registered):

```csharp
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.Validation;
using BeneficialStrategies.Iso20022.Validation.Payloads;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddIso20022Factory(typeof(IFIToFIPaymentCancellationRequestV10));                    // builds its classes at start-up
services.AddIso20022Validators(rootTypes: [typeof(IFIToFIPaymentCancellationRequestV10)]);
services.AddIso20022PayloadValidators();
services.AddIso20022PayloadValidationDispatcher();
using var provider = services.BuildServiceProvider();

// the envelope of the interface
var validator = provider.GetRequiredService<IValidator<XmlEnvelope<IFIToFIPaymentCancellationRequestV10>>>();
var result = validator.Validate(new XmlEnvelope<IFIToFIPaymentCancellationRequestV10>(xml));

// or the dispatcher, which now resolves the interface of the document's namespace and reads into it
var dispatched = provider.GetRequiredService<IIso20022PayloadValidationDispatcher>().ValidateXml(xml);
var request = (IFIToFIPaymentCancellationRequestV10)dispatched.Message!;
Console.WriteLine(request.Assignment.Identification);        // DEUTDEFF/240316/CAMT056/00001
```

The failures and their meaning are the same as in example 2. `request` is an object of a class the factory wrote for the occasion (`request.GetType().Name` is something like `IFIToFIPaymentCancellationRequestV10_1`), and it is a normal value: equal when its members are equal, with a `ToString` that shows them. **JSON is read into the message classes only**, so the JSON envelope and `ValidateJson` need the message library (example 2).

## Good to know

* **Where the message classes are found.** The dispatcher and `ValidateJson` look a type up in the `Iso20022MessageTypeRegistry` of `Primitives`, which holds the message classes (`IOuterRecord` with the constants above) of the loaded assemblies that reference it, and the interfaces marked with `[IsoMessage]`. When a payload can arrive before any such type has been used in the process, hand the assemblies in: `AddIso20022PayloadValidators(messageAssemblies: [typeof(MyCustomMessage).Assembly])` or `Iso20022MessageTypeRegistry.AddAssembly(...)`.
* **Which validator runs.** The validators of the message library are written for the message *interfaces*; an envelope validates the object the payload was read into through the validator of its interface (or the validator registered for the class itself, as in example 1).
* **The dispatcher's own error codes** are `UnknownMessageType` (a namespace or identifier it does not know), `NoValidatorRegistered` and, for JSON, `PayloadParseError`. The envelope validators report a JSON problem as `JsonParseError`.
* **A plain method call, no container.** To validate XML with `validator.Validate(xml, out message)`, with the message handed back, use [BeneficialStrategies.Iso20022.FluentValidation.Xml](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Xml) directly. The XML envelope validator and the dispatcher here report exactly its failures.
* **Targets** netstandard2.0 (.NET Framework 4.6.1+, Mono, Unity), net8.0 and net10.0, like the validators package it works with.
