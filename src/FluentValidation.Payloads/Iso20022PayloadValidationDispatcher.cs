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
/// <c>MethodInfo.Invoke</c> call, not a fresh
/// <see cref="MethodInfo.MakeGenericMethod"/> per call.
/// </remarks>
internal sealed class Iso20022PayloadValidationDispatcher : IIso20022PayloadValidationDispatcher
{
    private static readonly MethodInfo XmlReadOpenMethod = typeof(Iso20022PayloadValidationDispatcher).GetMethod(
        nameof(ReadXml),
        BindingFlags.NonPublic | BindingFlags.Static
    )!;

    private static readonly MethodInfo JsonTryDeserializeOpenMethod = typeof(Iso20022JsonSerializer).GetMethod(
        nameof(Iso20022JsonSerializer.TryDeserialize)
    )!;

    private static readonly ConcurrentDictionary<Type, Func<XDocument, IIsoDataFactory?, (object? Message, IReadOnlyList<DeserializationIssue> Issues)>> XmlReaders = new();
    private static readonly ConcurrentDictionary<Type, MethodInfo> JsonTryDeserializeMethods = new();

    private readonly IServiceProvider _serviceProvider;

    public Iso20022PayloadValidationDispatcher(IServiceProvider serviceProvider) =>
        _serviceProvider = serviceProvider;

    public Iso20022PayloadValidationResult ValidateXml(string xml)
    {
        XDocument document;
        try
        {
            document = XDocument.Parse(xml, LoadOptions.SetLineInfo);
        }
        catch (XmlException ex)
        {
            return NoTypeFailure(new DeserializationIssue("", IssueCode.MalformedXml, null, ex.Message, ex.LineNumber, ex.LinePosition));
        }
        catch (Exception ex) when (ex is ArgumentNullException or ArgumentException)
        {
            return NoTypeFailure(new DeserializationIssue("", IssueCode.MalformedXml, null, $"There is no XML text: {ex.Message}"));
        }

        var documentNamespace = document.Root?.Name.NamespaceName;
        if (documentNamespace is null)
            return NoTypeFailure("XML has no root element.", "UnknownMessageType");

        // With a factory registered the XML is read into the message interface, so no record is needed; otherwise into the record.
        var factory = _serviceProvider.GetService(typeof(IIsoDataFactory)) as IIsoDataFactory;
        Type? messageType = null;
        if (factory is not null && Iso20022MessageTypeRegistry.TryGetInterfaceByDocumentNamespace(documentNamespace, out var messageInterface))
            messageType = messageInterface;
        else if (Iso20022MessageTypeRegistry.TryGetByDocumentNamespace(documentNamespace, out var record))
            messageType = record;
        if (messageType is null)
            return NoTypeFailure($"Unrecognized ISO 20022 document namespace '{documentNamespace}'.", "UnknownMessageType");

        var (message, issues) = XmlReaders.GetOrAdd(
            messageType,
            t => (Func<XDocument, IIsoDataFactory?, (object?, IReadOnlyList<DeserializationIssue>)>)
                XmlReadOpenMethod.MakeGenericMethod(t).CreateDelegate(typeof(Func<XDocument, IIsoDataFactory?, (object?, IReadOnlyList<DeserializationIssue>)>))
        )(document, factory);
        if (message is null)
            return new Iso20022PayloadValidationResult(new ValidationResult(issues.Select(i => i.ToFailure()).ToList()), messageType, null);
        return Validate(messageType, message);
    }

    // The same reading as the Xml package's extensions: every problem, with its path.
    private static (object? Message, IReadOnlyList<DeserializationIssue> Issues) ReadXml<T>(XDocument document, IIsoDataFactory? factory)
        where T : class, IOuterRecord
    {
        var read = Iso20022XmlSerializer.TryRead<T>(document, factory);
        return (read.Message, read.Issues);
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

        return Validate(messageType, message!);
    }

    private Iso20022PayloadValidationResult Validate(Type messageType, object message)
    {
        // The validators are written for the message interface (#28); a validator registered for the record itself is also used.
        var messageInterface = messageType.IsInterface ? messageType : MessageValidatorAdapters.InterfaceOf(messageType);
        var validator =
            (messageInterface is null ? null : _serviceProvider.GetService(typeof(IValidator<>).MakeGenericType(messageInterface)))
            as IValidator
            ?? _serviceProvider.GetService(typeof(IValidator<>).MakeGenericType(messageType)) as IValidator;
        if (validator is null)
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
        var nonGenericContext = new ValidationContext<object>(message);
        var validationResult = validator.Validate(nonGenericContext);
        return new Iso20022PayloadValidationResult(validationResult, messageType, message);
    }

    private static Iso20022PayloadValidationResult NoTypeFailure(string message, string errorCode) =>
        new(SingleFailure(message, errorCode), null, null);

    private static Iso20022PayloadValidationResult NoTypeFailure(DeserializationIssue issue) =>
        new(new ValidationResult([issue.ToFailure()]), null, null);

    // MethodInfo.Invoke supports out parameters via the args array: pass placeholder slots for
    // them, then read the values Invoke writes back into those slots after it returns.
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
