// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AcceptanceResult6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _RBvu4dp-Ed-ak6NoX_4Aeg_2046006177
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of elements used to provide detailed information on the acceptance result.
/// <list type="table">
///   <item><term>Accepted</term><description>YesNoIndicator — required (1..1)</description></item>
///   <item><term>RejectReason</term><description>MandateReason1Choice_ — optional (0..1)</description></item>
///   <item><term>AdditionalRejectReasonInformation</term><description>Max105Text — optional collection (0..∞)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>Accepted</c> is required
/// (1..1) and already a <c>required</c> C# property; <c>AdditionalRejectReasonInformation</c>'s
/// items are already fully struct-enforced (Max105Text) — no rule needed beyond that.
///
/// Dependency injection: <c>RejectReason</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class AcceptanceResult6Validator : AbstractValidator<AcceptanceResult6>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>RejectReason</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="rejectReasonValidator">
    /// Validator for the optional <c>RejectReason</c> building block (MandateReason1Choice_, 0..1)
    /// — only invoked when present.
    /// </param>
    public AcceptanceResult6Validator(IValidator<MandateReason1Choice_> rejectReasonValidator)
    {
        When(
            x => x.RejectReason is not null,
            () => RuleFor(x => x.RejectReason).SetValidator(rejectReasonValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>RejectReason</c> is validated by
    /// its own default validator (<see cref="MandateReason1Choice_Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public AcceptanceResult6Validator()
        : this(new MandateReason1Choice_Validator()) { }
}
