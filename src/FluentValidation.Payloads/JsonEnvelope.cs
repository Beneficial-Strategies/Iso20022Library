// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// Wraps a raw JSON payload for validation as a specific ISO 20022 message type
/// <typeparamref name="TMessage"/>.
/// </summary>
/// <remarks>
/// The JSON counterpart to <see cref="XmlEnvelope{TMessage}"/> — see its remarks for the full
/// rationale. Pair with <see cref="JsonEnvelopeValidator{TMessage}"/>, registered as
/// <c>IValidator&lt;JsonEnvelope&lt;TMessage&gt;&gt;</c> via <c>AddIso20022PayloadValidators()</c>.
/// </remarks>
/// <param name="Json">The raw, not-yet-deserialized JSON payload.</param>
public sealed record JsonEnvelope<TMessage>(string Json)
    where TMessage : class, IOuterRecord;
