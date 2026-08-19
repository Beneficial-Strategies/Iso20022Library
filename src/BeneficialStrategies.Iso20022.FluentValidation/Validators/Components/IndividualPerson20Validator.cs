// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="IndividualPerson20"/> per the ISO 20022 specification.
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
///   <item><term>Citizenship</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..3</description></item>
///   <item><term>PostalAddress</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..5</description></item>
/// </list>
/// </remarks>
public class IndividualPerson20Validator : AbstractValidator<IndividualPerson20>
{
    public IndividualPerson20Validator()
    {
        RuleFor(x => x.Citizenship)
            .NotEmpty()
            .WithMessage("IndividualPerson20.Citizenship must contain at least one element (1..3).");

        RuleFor(x => x.PostalAddress)
            .NotEmpty()
            .WithMessage("IndividualPerson20.PostalAddress must contain at least one element (1..5).");
    }
}
