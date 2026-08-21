// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TrackerRecord5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1bDllzEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Specifies the agent specific tracking system information of a payment transaction.
/// <list type="table">
///   <item><term>Agent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>ChargesAmount</term><description>ActiveCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>ExchangeRateData</term><description>CurrencyExchange13 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Agent</c> and <c>ExchangeRateData</c> are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class TrackerRecord5Validator : AbstractValidator<TrackerRecord5>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TrackerRecord5Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CurrencyExchange13> exchangeRateDataValidator
    )
    {
        RuleFor(x => x.Agent).SetValidator(agentValidator!);
        When(
            x => x.ExchangeRateData is not null,
            () => RuleFor(x => x.ExchangeRateData).SetValidator(exchangeRateDataValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TrackerRecord5Validator()
        : this(new BranchAndFinancialInstitutionIdentification8Validator(), new CurrencyExchange13Validator()) { }
}
