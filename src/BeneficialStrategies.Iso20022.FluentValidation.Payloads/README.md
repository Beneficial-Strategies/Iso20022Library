# BeneficialStrategies.Iso20022.FluentValidation.Payloads

```
dotnet add package BeneficialStrategies.Iso20022.FluentValidation.Payloads --version 0.7.0-alpha
```

Validate raw ISO 20022 XML or JSON payloads (for example off a message queue): the payload is deserialized, then validated with the
validators of [BeneficialStrategies.Iso20022.FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation).

* Depends on [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives) (the serializers are there), FluentValidation and `Microsoft.Extensions.DependencyInjection.Abstractions`; not on the message records.
* To validate XML with a plain method call, with every reading problem reported and the record handed back, and no container, see [BeneficialStrategies.Iso20022.FluentValidation.Xml](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Xml); the envelope validators here are being moved onto it (#21).
* Targets netstandard2.0 (.NET Framework 4.6.1+, Mono, Unity), net8.0 and net10.0, like the validators package it works with.
* The message records are found by the `Iso20022MessageTypeRegistry` of Primitives: the loaded assemblies that reference it, plus the ones you hand to `AddIso20022PayloadValidators(messageAssemblies: [...])` or `Iso20022MessageTypeRegistry.AddAssembly(...)`. Do that when a payload may arrive before any record type has been used in the process.
* The validators are written for the message interfaces; the envelope validators validate the record the payload is read into, through the validator of its interface.


Often what you have is raw XML or JSON text (off a queue, from an HTTP body), and you want deserialization failures to show up as
ordinary validation errors too, not as a separate exception-handling path. Two building blocks cover this, depending on whether you
know the message type up front:

- `IValidator<XmlEnvelope<TMessage>>` / `IValidator<JsonEnvelope<TMessage>>` — when the type is
  known at the call site (e.g. a queue bound to one message type). Registered via
  `AddIso20022PayloadValidators()`; behaves as literally just another `IValidator<T>`.
- `IIso20022PayloadValidationDispatcher` — when the payload could be any one of several message
  types, resolved from the payload itself. Registered via `AddIso20022PayloadValidationDispatcher()`.

Either way, a parse failure becomes a `ValidationFailure` in the result (`ErrorCode` values like
`"XmlParseError"`, `"JsonParseError"`, `"UnknownMessageType"`), never a thrown exception.

### Example 1 — known type, JSON payload

A queue consumer bound to exactly one message type validates each message body as it arrives:

```C#
using BeneficialStrategies.Iso20022.pacs;
using BeneficialStrategies.Iso20022.Serialization;
using BeneficialStrategies.Iso20022.Validation;
using BeneficialStrategies.Iso20022.Validation.Payloads;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

// Top-level statements must precede type declarations in a file, so the setup code
// comes first here — CreditTransferQueueHandler (declared below) is only referenced
// by type, never constructed directly, so declaration order doesn't matter for it.
var services = new ServiceCollection();
services.AddIso20022Validators(rootTypes: [typeof(FIToFICustomerCreditTransferV14)]);
services.AddIso20022PayloadValidators();
services.AddSingleton<CreditTransferQueueHandler>();
using var provider = services.BuildServiceProvider();

var handler = provider.GetRequiredService<CreditTransferQueueHandler>();
// handler.Handle(messageBodyFromYourQueueClient);

public sealed class CreditTransferQueueHandler
{
    private readonly IValidator<JsonEnvelope<FIToFICustomerCreditTransferV14>> _validator;

    public CreditTransferQueueHandler(
        IValidator<JsonEnvelope<FIToFICustomerCreditTransferV14>> validator
    ) => _validator = validator;

    public void Handle(string messageBody)
    {
        var envelope = new JsonEnvelope<FIToFICustomerCreditTransferV14>(messageBody);
        var result = _validator.Validate(envelope);
        if (!result.IsValid)
        {
            foreach (var error in result.Errors)
                Console.WriteLine($"  {error.PropertyName}: {error.ErrorMessage}");

            // Covers malformed JSON (ErrorCode "JsonParseError") the same way as an
            // ordinary business-rule violation — same list, same shape, no separate
            // catch block needed.
            return; // dead-letter, nack, etc. — whatever your queue client calls for.
        }

        // `result` proves the body is valid but, like any IValidator<T> result,
        // doesn't hand the deserialized instance back — re-deserializing once, now
        // that you know it's valid, is cheap and keeps "is this valid" and "give me
        // the object" as separate concerns.
        var message = Iso20022JsonSerializer.Deserialize<FIToFICustomerCreditTransferV14>(
            messageBody
        );
        var firstTransfer = message.CreditTransferTransactionInformation[0];
        var endToEndId = firstTransfer.PaymentIdentification.EndToEndIdentification;
        Console.WriteLine($"Processing transfer {endToEndId}");
    }
}
```

### Example 2 — type unknown up front, XML payload, one of several candidates

A queue that carries any of several related message types — here, three events in a payment's
lifecycle — resolved from each payload's own root document namespace, then dispatched by a
`switch` on the resolved type:

```C#
using BeneficialStrategies.Iso20022.pacs;
using BeneficialStrategies.Iso20022.Validation;
using BeneficialStrategies.Iso20022.Validation.Payloads;
using Microsoft.Extensions.DependencyInjection;

// Top-level statements must precede type declarations in a file, so the setup code
// comes first here — PaymentLifecycleQueueHandler (declared below) is only referenced
// by type, never constructed directly, so declaration order doesn't matter for it.
var services = new ServiceCollection();
services.AddIso20022Validators(
    rootTypes:
    [
        typeof(FIToFIPaymentStatusReportV16),
        typeof(FIToFIPaymentReversalV14),
        typeof(PaymentReturnV15),
    ]
);
services.AddIso20022PayloadValidationDispatcher();
services.AddSingleton<PaymentLifecycleQueueHandler>();
using var provider = services.BuildServiceProvider();

var handler = provider.GetRequiredService<PaymentLifecycleQueueHandler>();
// handler.Handle(xmlBodyFromYourQueueClient);

public sealed class PaymentLifecycleQueueHandler
{
    private readonly IIso20022PayloadValidationDispatcher _dispatcher;

    public PaymentLifecycleQueueHandler(
        IIso20022PayloadValidationDispatcher dispatcher
    ) => _dispatcher = dispatcher;

    public void Handle(string xmlBody)
    {
        var result = _dispatcher.ValidateXml(xmlBody);

        if (!result.IsValid)
        {
            // Covers malformed XML, an unrecognized document namespace, and ordinary
            // business-rule failures alike — all as ValidationFailure entries, none of
            // them a thrown exception.
            foreach (var error in result.ValidationResult.Errors)
                Console.WriteLine($"  {error.PropertyName}: {error.ErrorMessage}");
            return;
        }

        // result.Message is the deserialized instance, typed as `object` since the
        // concrete type wasn't known until the payload was inspected — pattern-match
        // it to each type you expect.
        switch (result.Message)
        {
            case FIToFIPaymentStatusReportV16 statusReport:
            {
                var count = statusReport.TransactionInformationAndStatus.Count;
                Console.WriteLine($"Status report: {count} transaction(s)");
                break;
            }

            case FIToFIPaymentReversalV14 reversal:
            {
                var count = reversal.TransactionInformation.Count;
                Console.WriteLine($"Reversal request: {count} transaction(s)");
                break;
            }

            case PaymentReturnV15 paymentReturn:
            {
                var count = paymentReturn.TransactionInformation.Count;
                Console.WriteLine($"Payment return: {count} transaction(s)");
                break;
            }

            default:
                // Only reachable if a validator for a fourth type got registered
                // without a matching case being added here — rootTypes below scopes
                // DI to exactly the three types this handler knows about, so nothing
                // else should ever validate.
                throw new InvalidOperationException(
                    $"Unhandled message type: {result.MessageType}"
                );
        }
    }
}
```

