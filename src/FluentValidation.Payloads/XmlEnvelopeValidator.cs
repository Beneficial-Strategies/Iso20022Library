// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// Reads the wrapped XML in an <see cref="XmlEnvelope{TMessage}"/> and, when it could be read, delegates to the
/// injected <see cref="IValidator{TMessage}"/> for <typeparamref name="TMessage"/>.
/// </summary>
/// <remarks>
/// <para>
/// <typeparamref name="TMessage"/> is a message record, or a message interface when an <see cref="IIsoDataFactory"/> is
/// registered (the <c>BeneficialStrategies.Iso20022.Factory</c> package supplies one): the XML is then read into
/// the objects the factory makes and no record is needed.
/// </para>
/// <para>
/// Every problem in the XML, not only the first, is a <see cref="ValidationFailure"/> whose
/// <see cref="ValidationFailure.ErrorCode"/> is <c>Xml.</c> + the <see cref="IssueCode"/> (<c>Xml.MalformedXml</c>,
/// <c>Xml.WrongRoot</c>, <c>Xml.RequiredMissing</c>, <c>Xml.FacetViolation</c>, ...) and whose
/// <see cref="ValidationFailure.PropertyName"/> is the XML path; it is never a thrown exception. They are the failures
/// of <c>BeneficialStrategies.Iso20022.FluentValidation.Xml</c>, which this builds on. When the XML cannot be read the
/// message validator does not run.
/// </para>
/// <para>
/// Business-rule failures from the underlying message validator pass through with their
/// <see cref="ValidationFailure.PropertyName"/> untouched, preserving this project's convention
/// of naming message-level failures after their ISO 20022 constraint (e.g.
/// <c>WithName("TotalReturnedInterbankSettlementAmountAndSumRule")</c>) — a caller diffing
/// failures against the message's own validator output sees identical property names either way.
/// </para>
/// </remarks>
public sealed class XmlEnvelopeValidator<TMessage> : AbstractValidator<XmlEnvelope<TMessage>>
    where TMessage : class, IOuterRecord
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the deserialized <typeparamref name="TMessage"/> — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="messageValidator">The validator for the message.</param>
    /// <param name="factory">Makes the objects when <typeparamref name="TMessage"/> is an interface; not needed for a record.</param>
    public XmlEnvelopeValidator(IValidator<TMessage> messageValidator, IIsoDataFactory? factory = null)
    {
        RuleFor(x => x.Xml)
            .Custom(
                (xml, context) =>
                {
                    var read = Iso20022XmlSerializer.TryRead<TMessage>(xml, factory);
                    if (read.Message is null)
                    {
                        foreach (var issue in read.Issues)
                            context.AddFailure(issue.ToFailure());
                        return;
                    }

                    foreach (var failure in messageValidator.Validate(read.Message).Errors)
                        context.AddFailure(failure);
                }
            );
    }
}
