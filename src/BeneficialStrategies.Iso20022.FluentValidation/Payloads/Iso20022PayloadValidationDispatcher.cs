// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Concurrent;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <inheritdoc cref="IIso20022PayloadValidationDispatcher"/>
/// <remarks>
/// Resolution is entirely dynamic — reflection over the runtime <see cref="Type"/> discovered
/// from <see cref="Iso20022MessageTypeRegistry"/>, not compile-time generics — because the target
/// message type isn't known until the payload (XML) or an out-of-band hint (JSON) is inspected.
/// The closed generic <see cref="MethodInfo"/>s this requires (one per message type, for whichever
/// serializer's <c>TryDeserialize&lt;T&gt;</c> was needed) are cached after first use, so repeat
/// dispatch to an already-seen message type costs one dictionary lookup plus one
/// <see cref="MethodInfo.Invoke(object?, object?[]?)"/> call, not a fresh
/// <see cref="MethodInfo.MakeGenericMethod"/> per call.
/// </remarks>
internal sealed class Iso20022PayloadValidationDispatcher : IIso20022PayloadValidationDispatcher
{
    private static readonly MethodInfo XmlTryDeserializeOpenMethod = typeof(Iso20022XmlSerializer)
        .GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Single(m =>
            m.Name == nameof(Iso20022XmlSerializer.TryDeserialize)
            && m.GetParameters()[0].ParameterType == typeof(XDocument)
        );

    private static readonly MethodInfo JsonTryDeserializeOpenMethod = typeof(Iso20022JsonSerializer).GetMethod(
        nameof(Iso20022JsonSerializer.TryDeserialize)
    )!;

    private static readonly ConcurrentDictionary<Type, MethodInfo> XmlTryDeserializeMethods = new();
    private static readonly ConcurrentDictionary<Type, MethodInfo> JsonTryDeserializeMethods = new();

    private readonly IServiceProvider _serviceProvider;

    public Iso20022PayloadValidationDispatcher(IServiceProvider serviceProvider) =>
        _serviceProvider = serviceProvider;

    public Iso20022PayloadValidationResult ValidateXml(string xml)
    {
        XDocument document;
        try
        {
            document = XDocument.Parse(xml);
        }
        catch (Exception ex) when (ex is XmlException or ArgumentNullException or ArgumentException)
        {
            return NoTypeFailure($"XML could not be parsed: {ex.Message}", "XmlParseError");
        }

        var documentNamespace = document.Root?.Name.NamespaceName;
        if (
            documentNamespace is null
            || !Iso20022MessageTypeRegistry.TryGetByDocumentNamespace(documentNamespace, out var messageType)
        )
        {
            return NoTypeFailure(
                documentNamespace is null
                    ? "XML has no root element."
                    : $"Unrecognized ISO 20022 document namespace '{documentNamespace}'.",
                "UnknownMessageType"
            );
        }

        return Dispatch(
            messageType,
            (out object? message, out Exception? error) => TryDeserializeXml(messageType, document, out message, out error)
        );
    }

    public Iso20022PayloadValidationResult ValidateJson(string json, string isoIdentifier)
    {
        if (!Iso20022MessageTypeRegistry.TryGetByIsoIdentifier(isoIdentifier, out var messageType))
        {
            return NoTypeFailure(
                $"Unrecognized ISO 20022 message identifier '{isoIdentifier}'.",
                "UnknownMessageType"
            );
        }

        return Dispatch(
            messageType,
            (out object? message, out Exception? error) => TryDeserializeJson(messageType, json, out message, out error)
        );
    }

    private delegate bool TryDeserializeDelegate(out object? message, out Exception? error);

    private Iso20022PayloadValidationResult Dispatch(Type messageType, TryDeserializeDelegate tryDeserialize)
    {
        if (!tryDeserialize(out var message, out var error))
        {
            return new Iso20022PayloadValidationResult(
                SingleFailure($"Payload could not be parsed as {messageType.Name}: {error?.Message}", "PayloadParseError"),
                messageType,
                null
            );
        }

        var validatorInterface = typeof(IValidator<>).MakeGenericType(messageType);
        if (_serviceProvider.GetService(validatorInterface) is not IValidator validator)
        {
            return new Iso20022PayloadValidationResult(
                SingleFailure($"No validator is registered for {messageType.Name}.", "NoValidatorRegistered"),
                messageType,
                message
            );
        }

        // The non-generic IValidator.Validate takes an IValidationContext, not a bare object —
        // ValidationContext<object> plus GetFromNonGenericContext is FluentValidation's own
        // documented adapter for dispatching to an IValidator<T> whose T isn't known at compile
        // time (exactly this scenario: messageType is only known at runtime).
        var nonGenericContext = new ValidationContext<object>(message!);
        var validationResult = validator.Validate(nonGenericContext);
        return new Iso20022PayloadValidationResult(validationResult, messageType, message);
    }

    private static Iso20022PayloadValidationResult NoTypeFailure(string message, string errorCode) =>
        new(SingleFailure(message, errorCode), null, null);

    // MethodInfo.Invoke supports out parameters via the args array: pass placeholder slots for
    // them, then read the values Invoke writes back into those slots after it returns.
    private static bool TryDeserializeXml(Type messageType, XDocument document, out object? message, out Exception? error)
    {
        var method = XmlTryDeserializeMethods.GetOrAdd(
            messageType,
            t => XmlTryDeserializeOpenMethod.MakeGenericMethod(t)
        );
        var args = new object?[] { document, null, null };
        var success = (bool)method.Invoke(null, args)!;
        message = args[1];
        error = (Exception?)args[2];
        return success;
    }

    private static bool TryDeserializeJson(Type messageType, string json, out object? message, out Exception? error)
    {
        var method = JsonTryDeserializeMethods.GetOrAdd(
            messageType,
            t => JsonTryDeserializeOpenMethod.MakeGenericMethod(t)
        );
        var args = new object?[] { json, null, null };
        var success = (bool)method.Invoke(null, args)!;
        message = args[1];
        error = (Exception?)args[2];
        return success;
    }

    private static ValidationResult SingleFailure(string message, string errorCode) =>
        new([new ValidationFailure("$root", message) { ErrorCode = errorCode }]);
}
