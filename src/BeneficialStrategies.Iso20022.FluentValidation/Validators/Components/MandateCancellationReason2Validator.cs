// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateCancellationReason2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _5w0E6TEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the reason for the mandate cancellation request.
/// <list type="table">
///   <item><term>Originator</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Reason</term><description>MandateReason1Choice_ — required (1..1)</description></item>
///   <item><term>AdditionalInformation</term><description>Max105Text — optional collection (0..∞)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>AdditionalInformation</c>'s
/// items are already fully struct-enforced (Max105Text) — no rule needed beyond that.
///
/// Dependency injection: <c>Originator</c> and <c>Reason</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MandateCancellationReason2Validator : AbstractValidator<MandateCancellationReason2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>Originator</c> building block and the required <c>Reason</c> building
    /// block — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="originatorValidator">
    /// Validator for the optional <c>Originator</c> building block (PartyIdentification272, 0..1)
    /// — only invoked when present.
    /// </param>
    /// <param name="reasonValidator">
    /// Validator for the required <c>Reason</c> building block (MandateReason1Choice_, 1..1).
    /// </param>
    public MandateCancellationReason2Validator(
        IValidator<PartyIdentification272> originatorValidator,
        IValidator<MandateReason1Choice_> reasonValidator
    )
    {
        RuleFor(x => x.Reason).SetValidator(reasonValidator);

        When(x => x.Originator is not null, () => RuleFor(x => x.Originator).SetValidator(originatorValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Originator</c> and <c>Reason</c>
    /// are each validated by their own default validator (<see cref="PartyIdentification272Validator"/>,
    /// <see cref="MandateReason1Choice_Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public MandateCancellationReason2Validator()
        : this(new PartyIdentification272Validator(), new MandateReason1Choice_Validator()) { }
}
