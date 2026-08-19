// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DocumentLineInformation1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Cy5dt6JpEeKmspP9k_hIRQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>Identification</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public class DocumentLineInformation1Validator : AbstractValidator<DocumentLineInformation1>
{
    public DocumentLineInformation1Validator()
    {
        // Description (Max2048Text): optional (0..1) scalar, length enforced by struct
        // constructor — no rule needed.

        // Amount (RemittanceAmount3, 0..1): no validator exists yet; nested fields unvalidated.

        // Identification: DocumentLineIdentification1, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Identification)
            .NotEmpty()
            .WithMessage("DocumentLineInformation1.Identification must contain at least one element (1..∞).");
    }
}
