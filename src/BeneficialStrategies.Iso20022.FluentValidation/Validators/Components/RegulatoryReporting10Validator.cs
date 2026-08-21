// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RegulatoryReporting10"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _FyCZkXeKEfCdoODv2ypKfw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information needed due to regulatory and/or statutory requirements.
/// <list type="table">
///   <item><term>DebitCreditReportingIndicator</term><description>RegulatoryReportingType1Code — required (1..1), closed enum, fully enforced</description></item>
///   <item><term>Authority</term><description>RegulatoryAuthority2 — optional (0..1)</description></item>
///   <item><term>Details</term><description>StructuredRegulatoryReporting5 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Authority</c> and <c>Details</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
///
/// Known test-coverage gap (2026-08-21): the test suite's happy-path case for this type does not
/// populate a value <see cref="RegulatoryAuthority2Validator"/> or
/// <see cref="StructuredRegulatoryReporting5Validator"/> would reject, so the <c>SetValidator</c>/
/// <c>RuleForEach</c> wiring below is unproven at this level — a regression that removed either
/// call would not be caught here (though <c>RegulatoryAuthority2Validator</c>'s own registry
/// rejection is proven independently in its own test file). A future pass should add a case
/// wiring a populated registry through to this level.
/// </remarks>
public class RegulatoryReporting10Validator : AbstractValidator<RegulatoryReporting10>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public RegulatoryReporting10Validator(
        IValidator<RegulatoryAuthority2> authorityValidator,
        IValidator<StructuredRegulatoryReporting5> detailsValidator
    )
    {
        When(x => x.Authority is not null, () => RuleFor(x => x.Authority).SetValidator(authorityValidator!));
        RuleForEach(x => x.Details).SetValidator(detailsValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public RegulatoryReporting10Validator()
        : this(new RegulatoryAuthority2Validator(), new StructuredRegulatoryReporting5Validator()) { }
}
