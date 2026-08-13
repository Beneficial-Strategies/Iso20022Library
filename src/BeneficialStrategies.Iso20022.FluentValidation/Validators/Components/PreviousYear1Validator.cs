// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PreviousYear1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// TODO: Abbreviated validator — only enforces the known Defect 2 minimum-collection-size gap(s)
/// below. NOT yet reviewed for full spec compliance (other field-level constraints, cross-field
/// rules) or covered by a test file. Full treatment is being done first for CAMT-reachable
/// components; this one was not in that reachable set as of 2026-08-13. See
/// docs/multiplicity-audit-2026-08.md and docs/multiplicity-defect2-2026-08.tsv.
///
/// Known model defect(s):
/// <list type="table">
///   <item><term>SpecificPreviousYears</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..&#8734;</description></item>
/// </list>
/// </remarks>
public sealed class PreviousYear1Validator : AbstractValidator<PreviousYear1>
{
    public PreviousYear1Validator()
    {
        RuleFor(x => x.SpecificPreviousYears)
            .NotEmpty()
            .WithMessage("PreviousYear1.SpecificPreviousYears must contain at least one element (1..∞).");
    }
}
