// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RemittanceLocation8"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _0IULUTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Provides information on the remittance advice.
/// <list type="table">
///   <item><term>RemittanceIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>RemittanceLocationDetails</term><description>RemittanceLocationData2 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>RemittanceLocationDetails</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class RemittanceLocation8Validator : AbstractValidator<RemittanceLocation8>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public RemittanceLocation8Validator(IValidator<RemittanceLocationData2> remittanceLocationDetailsValidator)
    {
        RuleForEach(x => x.RemittanceLocationDetails).SetValidator(remittanceLocationDetailsValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public RemittanceLocation8Validator()
        : this(new RemittanceLocationData2Validator()) { }
}
