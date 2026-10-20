// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// Wraps a raw XML payload for validation as a specific ISO 20022 message type
/// <typeparamref name="TMessage"/>.
/// </summary>
/// <remarks>
/// Pair with <see cref="XmlEnvelopeValidator{TMessage}"/> — registered as
/// <c>IValidator&lt;XmlEnvelope&lt;TMessage&gt;&gt;</c> via
/// <c>AddIso20022PayloadValidators()</c> — to deserialize-then-validate raw XML through the exact
/// same <c>IValidator&lt;T&gt;</c> surface as every other validator in this project: a malformed
/// or structurally invalid payload becomes a <see cref="ValidationFailure"/> in the result, not a
/// thrown exception.
/// <code>
/// var validator = provider.GetRequiredService&lt;IValidator&lt;XmlEnvelope&lt;PaymentReturnV15&gt;&gt;&gt;();
/// var result = validator.Validate(new XmlEnvelope&lt;PaymentReturnV15&gt;(rawXml));
/// </code>
/// Use this overload when the target message type is known at the call site (e.g. a consumer
/// bound to one message type). For payloads whose type isn't known until the payload itself is
/// inspected, use <see cref="IIso20022PayloadValidationDispatcher"/> instead.
/// </remarks>
/// <param name="Xml">The raw, not-yet-deserialized XML payload.</param>
public sealed record XmlEnvelope<TMessage>(string Xml)
    where TMessage : class, IOuterRecord;
