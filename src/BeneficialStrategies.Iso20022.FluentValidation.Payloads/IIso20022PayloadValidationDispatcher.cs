// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// Validates a raw XML or JSON payload of unknown ISO 20022 message type by resolving the
/// concrete message type from the payload itself (XML) or a caller-supplied identifier (JSON),
/// then delegating to that type's registered <see cref="IValidator{T}"/>.
/// </summary>
/// <remarks>
/// XML carries a self-describing root document namespace (the <c>&lt;Document xmlns="urn:iso:..."&gt;</c>
/// wrapper every ISO 20022 message shares), so <see cref="ValidateXml"/> can resolve the message
/// type from the payload alone via <see cref="Iso20022MessageTypeRegistry"/>. ISO 20022's JSON
/// binding has no equivalent discriminator, so <see cref="ValidateJson"/> always requires the
/// caller to supply the target ISO 20022 message identifier (e.g. <c>"pacs.008.001.14"</c>) out of
/// band — from a queue header, HTTP content-type parameter, enclosing envelope, or similar.
///
/// Every failure mode — malformed payload, unrecognized message type, no validator registered for
/// the resolved type — surfaces as a <see cref="ValidationFailure"/> inside the returned
/// <see cref="Iso20022PayloadValidationResult.ValidationResult"/>, never a thrown exception, so
/// callers get the same result shape regardless of which of these problems occurred. The returned
/// <see cref="Iso20022PayloadValidationResult"/> also carries the resolved message type and the
/// deserialized instance itself, so a caller that anticipates more than one possible message type
/// can act differently per type — typically by switching on
/// <see cref="Iso20022PayloadValidationResult.MessageType"/> after confirming
/// <see cref="Iso20022PayloadValidationResult.IsValid"/>.
///
/// Use this when the message type isn't known until the payload (or an out-of-band hint) is
/// inspected. When the type IS known at the call site, prefer resolving
/// <c>IValidator&lt;XmlEnvelope&lt;TMessage&gt;&gt;</c> /
/// <c>IValidator&lt;JsonEnvelope&lt;TMessage&gt;&gt;</c> directly — it avoids this dispatcher's
/// per-type reflection and gives ordinary compile-time type safety.
/// </remarks>
public interface IIso20022PayloadValidationDispatcher
{
    /// <summary>
    /// Deserializes <paramref name="xml"/> as the message type indicated by its root element's
    /// document namespace, then validates it with that type's registered <see cref="IValidator{T}"/>.
    /// </summary>
    /// <param name="xml">The raw XML payload, including its <c>&lt;Document&gt;</c> root.</param>
    Iso20022PayloadValidationResult ValidateXml(string xml);

    /// <summary>
    /// Deserializes <paramref name="json"/> as the message type identified by
    /// <paramref name="isoIdentifier"/>, then validates it with that type's registered
    /// <see cref="IValidator{T}"/>.
    /// </summary>
    /// <param name="json">The raw JSON payload.</param>
    /// <param name="isoIdentifier">
    /// The ISO 20022 message identifier the payload should be interpreted as, e.g.
    /// <c>"pacs.008.001.14"</c> — supplied out of band, since JSON carries no self-describing
    /// type discriminator (see remarks on <see cref="IIso20022PayloadValidationDispatcher"/>).
    /// </param>
    Iso20022PayloadValidationResult ValidateJson(string json, string isoIdentifier);
}
