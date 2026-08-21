// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RemittanceInformation22"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _7ql4wTEsEe6GxLzpkVnWYg
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Information supplied to enable the matching/reconciliation of an entry with the items that
/// the payment is intended to settle, such as commercial invoices in an accounts' receivable
/// system.
/// <list type="table">
///   <item><term>Structured</term><description>StructuredRemittanceInformation18 collection — optional (0..n)</description></item>
///   <item><term>Unstructured</term><description>Max140Text collection — optional (0..n), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Structured</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class RemittanceInformation22Validator : AbstractValidator<RemittanceInformation22>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public RemittanceInformation22Validator(IValidator<StructuredRemittanceInformation18> structuredValidator)
    {
        RuleForEach(x => x.Structured).SetValidator(structuredValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public RemittanceInformation22Validator()
        : this(new StructuredRemittanceInformation18Validator()) { }
}
