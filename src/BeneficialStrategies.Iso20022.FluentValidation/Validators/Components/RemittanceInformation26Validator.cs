// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RemittanceInformation26"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 36b7291f-b8fd-4d08-957c-47b12fd4de39
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Information supplied to enable the matching/reconciliation of an entry with the items that the
/// payment is intended to settle.
/// <list type="table">
///   <item><term>Unstructured</term><description>Max140Text collection — optional (0..n), fully struct-enforced</description></item>
///   <item><term>Structured</term><description>StructuredRemittanceInformation22 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Structured</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class RemittanceInformation26Validator : AbstractValidator<RemittanceInformation26>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public RemittanceInformation26Validator(IValidator<StructuredRemittanceInformation22> structuredValidator)
    {
        RuleForEach(x => x.Structured).SetValidator(structuredValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public RemittanceInformation26Validator()
        : this(new StructuredRemittanceInformation22Validator()) { }
}
