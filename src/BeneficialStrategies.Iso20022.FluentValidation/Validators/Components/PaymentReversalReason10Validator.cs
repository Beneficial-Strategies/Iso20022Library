// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentReversalReason10"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yEc2KTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Payment Reversal Reason10.
/// <list type="table">
///   <item><term>AdditionalInformation</term><description>Max105Text collection — optional (0..n), fully struct-enforced</description></item>
///   <item><term>Originator</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Reason</term><description>ReversalReason4Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Originator</c> and <c>Reason</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class PaymentReversalReason10Validator : AbstractValidator<PaymentReversalReason10>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentReversalReason10Validator(
        IValidator<PartyIdentification272> originatorValidator,
        IValidator<ReversalReason4Choice_> reasonValidator
    )
    {
        When(x => x.Originator is not null, () => RuleFor(x => x.Originator).SetValidator(originatorValidator!));
        When(x => x.Reason is not null, () => RuleFor(x => x.Reason).SetValidator(reasonValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentReversalReason10Validator()
        : this(new PartyIdentification272Validator(), new ReversalReason4Choice_Validator()) { }
}
