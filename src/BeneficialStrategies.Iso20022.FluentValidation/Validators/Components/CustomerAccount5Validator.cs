// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CustomerAccount5"/> per the ISO 20022 specification.
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
///   <item><term>Identification</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..&#8734;</description></item>
/// </list>
/// </remarks>
public class CustomerAccount5Validator : AbstractValidator<CustomerAccount5>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="CustomerAccount5"/>.
    /// </summary>
    public CustomerAccount5Validator()
    {
        RuleFor(x => x.Identification)
            .NotEmpty()
            .WithMessage("CustomerAccount5.Identification must contain at least one element (1..∞).");
    }
}
