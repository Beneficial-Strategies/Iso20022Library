// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Charges16"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _x7KXQTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides information on the charges related to the payment transaction.
/// <list type="table">
///   <item><term>Agent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>Amount</term><description>ActiveOrHistoricCurrencyAndAmount — required (1..1), Amounts-namespace exemption</description></item>
///   <item><term>Type</term><description>ChargeType3Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Agent</c> and <c>Type</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class Charges16Validator : AbstractValidator<Charges16>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public Charges16Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<ChargeType3Choice_> typeValidator
    )
    {
        RuleFor(x => x.Agent).SetValidator(agentValidator!);
        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public Charges16Validator()
        : this(new BranchAndFinancialInstitutionIdentification8Validator(), new ChargeType3Choice_Validator()) { }
}
