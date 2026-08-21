// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TaxData1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _n7DtAd4lEeqt1ZcLzWyWFw
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Details about tax paid, or to be paid, to the government in accordance with the law, including
/// pre-defined parameters such as thresholds and type of account.
/// <list type="table">
///   <item><term>Creditor</term><description>TaxParty1 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>TaxParty2 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>TaxParty2 — optional (0..1)</description></item>
///   <item><term>AdministrationZone</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ReferenceNumber</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Method</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>TotalTaxableBaseAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>TotalTaxAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>Date</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>SequenceNumber</term><description>Number — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Record</term><description>TaxRecord3 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Creditor</c>, <c>Debtor</c>/<c>UltimateDebtor</c>, and <c>Record</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — the same <see cref="TaxParty2"/> validator instance is reused across
/// <c>Debtor</c> and <c>UltimateDebtor</c> — see the two constructors below.
/// </remarks>
public class TaxData1Validator : AbstractValidator<TaxData1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TaxData1Validator(
        IValidator<TaxParty1> creditorValidator,
        IValidator<TaxParty2> debtorValidator,
        IValidator<TaxRecord3> recordValidator
    )
    {
        When(x => x.Creditor is not null, () => RuleFor(x => x.Creditor).SetValidator(creditorValidator!));
        When(x => x.Debtor is not null, () => RuleFor(x => x.Debtor).SetValidator(debtorValidator!));
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(debtorValidator!)
        );
        RuleForEach(x => x.Record).SetValidator(recordValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TaxData1Validator()
        : this(new TaxParty1Validator(), new TaxParty2Validator(), new TaxRecord3Validator()) { }
}
