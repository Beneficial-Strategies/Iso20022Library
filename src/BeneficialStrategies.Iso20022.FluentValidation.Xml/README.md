# BeneficialStrategies.Iso20022.FluentValidation.Xml

```
dotnet add package BeneficialStrategies.Iso20022.FluentValidation.Xml --version 0.7.0-alpha
```

Validate ISO 20022 XML straight from text, a document or an element. Every problem in the XML is reported with its path, in the same `ValidationResult` as the rules; when the XML could be read, you also get the record.

* Depends on [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives) (the reader is there) and FluentValidation. Not on the message records, and not on dependency injection.
* Targets netstandard2.0 (.NET Framework 4.6.1+, Mono, Unity), net8.0 and net10.0.
* For validation inside a container (envelope validators, a dispatcher that finds the message type from the XML), see [BeneficialStrategies.Iso20022.FluentValidation.Payloads](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Payloads), which builds on this package.

## Use

The validators of [BeneficialStrategies.Iso20022.FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) are written for the interfaces (`IValidator<IFIToFICustomerCreditTransferV14>`), and an interface cannot be read into, so the call names the class to read the XML into. Declare the `out` variable **with its type**; that is how the class is found:

```csharp
IValidator<IFIToFICustomerCreditTransferV14> validator =
    provider.GetRequiredService<IValidator<IFIToFICustomerCreditTransferV14>>();

ValidationResult result = validator.Validate(xml, out FIToFICustomerCreditTransferV14? message);

if (!result.IsValid)
    foreach (var failure in result.Errors)
        Console.WriteLine($"{failure.ErrorCode} {failure.PropertyName}: {failure.ErrorMessage}");
```

(`out var message` does not compile: it cannot say which class to read. A class that does not implement the interface does not compile either.)

The same method takes an `XDocument` or an `XElement`, and has an async form, `ValidateAsync<TInterface, TRecord>`, returning the result and the record. An `XElement` can be any part of a document, so `IValidator<INameAndAddress5>` with `NameAndAddress5` validates a part on its own; pass a `ReadContext` with the namespace and a path prefix when it is a fragment of a larger document.

## Without the records

With a factory, the XML is read into the interface itself and no record is named, so you do not reference `BeneficialStrategies.Iso20022.Common` at all. The factory comes from [BeneficialStrategies.Iso20022.Factory](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Factory), which builds the classes that implement the interfaces at run time:

```csharp
var factory = new IsoDataFactory();   // or the singleton from AddIso20022Factory(...)

ValidationResult result = validator.Validate(xml, factory, out IFIToFICustomerCreditTransferV14? message);
```

One type argument, inferred from the validator and the `out` variable (`out var message` works here, since the interface is the validator's own; it is only the record overloads that need the `out` variable declared with its type). The same overloads exist for an `XDocument`, an `XElement` and `ValidateAsync`. The result and `message` mean what the next section says. This package depends only on the `IIsoDataFactory` abstraction in `Primitives`, so you can pass a factory of your own as well.

## What you get back

| The XML | `result` | `message` |
|---|---|---|
| could not be read (malformed, wrong root, a required element missing, a bad value, …) | **every** problem found, not only the first. `ErrorCode` is `Xml.` + the kind (`Xml.RequiredMissing`, `Xml.BadValue`, `Xml.FacetViolation`, `Xml.UnexpectedElement`, `Xml.MalformedXml`, …), `PropertyName` the XML path, `CustomState` the `DeserializationIssue` with the line and position | `null`. The rules do not run, because they would judge a half-built record |
| could be read, and the rules pass | valid | the record |
| could be read, and a rule fails | the rule failures, `PropertyName` the property path | **the record**, so you can log or inspect it |

`result.IsValid` says whether the whole thing passed. A `PropertyName` is an XML path for a reading problem and a property path for a rule; the `Xml.` prefix of the error code tells them apart.
