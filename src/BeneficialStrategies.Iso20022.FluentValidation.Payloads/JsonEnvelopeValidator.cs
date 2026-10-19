// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// Deserializes the wrapped JSON in a <see cref="JsonEnvelope{TMessage}"/> and, on success,
/// delegates to the injected <see cref="IValidator{TMessage}"/> for <typeparamref name="TMessage"/>.
/// </summary>
/// <remarks>
/// The JSON counterpart to <see cref="XmlEnvelopeValidator{TMessage}"/> — see its remarks for the
/// full rationale. A deserialization failure surfaces as a single <see cref="ValidationFailure"/>
/// whose <see cref="ValidationFailure.ErrorCode"/> is <c>"JsonParseError"</c>, using
/// <see cref="Iso20022JsonSerializer.TryDeserialize{TMessage}(string, out TMessage, out Exception)"/>.
/// </remarks>
public sealed class JsonEnvelopeValidator<TMessage> : AbstractValidator<JsonEnvelope<TMessage>>
    where TMessage : class, IOuterRecord
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the deserialized <typeparamref name="TMessage"/> — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    public JsonEnvelopeValidator(IValidator<TMessage> messageValidator)
    {
        RuleFor(x => x.Json)
            .Custom(
                (json, context) =>
                {
                    if (!Iso20022JsonSerializer.TryDeserialize<TMessage>(json, out var message, out var error))
                    {
                        context.AddFailure(
                            new ValidationFailure(
                                context.PropertyPath,
                                $"JSON could not be parsed as {typeof(TMessage).Name}: {error?.Message}"
                            )
                            {
                                ErrorCode = "JsonParseError",
                            }
                        );
                        return;
                    }

                    foreach (var failure in messageValidator.Validate(message).Errors)
                        context.AddFailure(failure);
                }
            );
    }
}
