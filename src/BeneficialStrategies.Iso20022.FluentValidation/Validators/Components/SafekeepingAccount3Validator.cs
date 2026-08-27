// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SafekeepingAccount3"/> per the ISO 20022 specification.
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
///   <item><term>InstructedBalance</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..10</description></item>
/// </list>
/// </remarks>
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public class SafekeepingAccount3Validator : AbstractValidator<SafekeepingAccount3>
{
    public SafekeepingAccount3Validator()
    {
        RuleFor(x => x.InstructedBalance)
            .NotEmpty()
            .WithMessage("SafekeepingAccount3.InstructedBalance must contain at least one element (1..10).");
    }
}
