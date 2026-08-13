// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SignedData3"/> per the ISO 20022 specification.
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
///   <item><term>DigestAlgorithm</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..&#8734;</description></item>
///   <item><term>Signer</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..&#8734;</description></item>
/// </list>
/// </remarks>
public sealed class SignedData3Validator : AbstractValidator<SignedData3>
{
    public SignedData3Validator()
    {
        RuleFor(x => x.DigestAlgorithm)
            .NotEmpty()
            .WithMessage("SignedData3.DigestAlgorithm must contain at least one element (1..∞).");

        RuleFor(x => x.Signer)
            .NotEmpty()
            .WithMessage("SignedData3.Signer must contain at least one element (1..∞).");
    }
}
