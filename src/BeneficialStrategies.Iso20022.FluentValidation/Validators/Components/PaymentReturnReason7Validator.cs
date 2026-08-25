// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentReturnReason7"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wrllwTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID — matched exactly, no gap.
///
/// Provides further details on the reason of the return of the transaction.
/// <list type="table">
///   <item><term>Originator</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Reason</term><description>ReturnReason5Choice_ — optional (0..1)</description></item>
///   <item><term>AdditionalInformation</term><description>Max105Text collection — optional (0..&#8734;); length enforced by struct constructor — no rule needed</description></item>
/// </list>
///
/// No cross-field constraints found for this component itself.
///
/// Dependency injection: <c>Originator</c> and <c>Reason</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class PaymentReturnReason7Validator : AbstractValidator<PaymentReturnReason7>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the two optional building blocks — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public PaymentReturnReason7Validator(
        IValidator<PartyIdentification272> originatorValidator,
        IValidator<ReturnReason5Choice_> reasonValidator
    )
    {
        When(x => x.Originator is not null, () => RuleFor(x => x.Originator).SetValidator(originatorValidator!));
        When(x => x.Reason is not null, () => RuleFor(x => x.Reason).SetValidator(reasonValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentReturnReason7Validator()
        : this(new PartyIdentification272Validator(), new ReturnReason5Choice_Validator()) { }
}
