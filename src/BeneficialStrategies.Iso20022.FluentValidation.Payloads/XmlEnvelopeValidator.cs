// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// Deserializes the wrapped XML in an <see cref="XmlEnvelope{TMessage}"/> and, on success,
/// delegates to the injected <see cref="IValidator{TMessage}"/> for <typeparamref name="TMessage"/>.
/// </summary>
/// <remarks>
/// A deserialization failure — malformed XML, a missing/wrong root element, or an ISO 20022
/// format-constraint violation — surfaces as a single <see cref="ValidationFailure"/> whose
/// <see cref="ValidationFailure.ErrorCode"/> is <c>"XmlParseError"</c>, never a thrown exception.
/// Uses <see cref="Iso20022XmlSerializer.TryDeserialize{TMessage}(string, out TMessage, out Exception)"/>
/// for that non-throwing behavior.
///
/// Business-rule failures from the underlying message validator pass through with their
/// <see cref="ValidationFailure.PropertyName"/> untouched, preserving this project's convention
/// of naming message-level failures after their ISO 20022 constraint (e.g.
/// <c>WithName("TotalReturnedInterbankSettlementAmountAndSumRule")</c>) — a caller diffing
/// failures against the message's own validator output sees identical property names either way.
/// </remarks>
public sealed class XmlEnvelopeValidator<TMessage> : AbstractValidator<XmlEnvelope<TMessage>>
    where TMessage : class, IOuterRecord
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the deserialized <typeparamref name="TMessage"/> — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    public XmlEnvelopeValidator(IValidator<TMessage> messageValidator)
    {
        RuleFor(x => x.Xml)
            .Custom(
                (xml, context) =>
                {
                    if (!Iso20022XmlSerializer.TryDeserialize<TMessage>(xml, out var message, out var error))
                    {
                        context.AddFailure(
                            new ValidationFailure(
                                context.PropertyPath,
                                $"XML could not be parsed as {typeof(TMessage).Name}: {error?.Message}"
                            )
                            {
                                ErrorCode = "XmlParseError",
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
