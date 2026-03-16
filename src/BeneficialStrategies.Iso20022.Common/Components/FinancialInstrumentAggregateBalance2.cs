// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aggregated position held in a securities account for a specified financial instrument.
/// </summary>
[IsoId("_aA5_JqCCEeOEyO7fCl8lLA")]
[DisplayName("Financial Instrument Aggregate Balance")]
public record FinancialInstrumentAggregateBalance2
{
    /// <summary>
    /// Balance of settled transactions.
    /// </summary>
    [IsoId("_aA5_KqCCEeOEyO7fCl8lLA")]
    [DisplayName("Settled Balance")]
    [IsoXmlTag("SttldBal")]
    public FinancialInstrumentQuantity1Choice_? SettledBalance { get; init; }

    /// <summary>
    /// Balance of settled transactions and transactions pending settlement.
    /// </summary>
    [IsoId("_aA5_KaCCEeOEyO7fCl8lLA")]
    [DisplayName("Traded Balance")]
    [IsoXmlTag("TraddBal")]
    public FinancialInstrumentQuantity1Choice_? TradedBalance { get; init; }

    /// <summary>
    /// Breakdown of the balances of holdings into sub-balances.
    /// </summary>
    [IsoId("_aA5_K6CCEeOEyO7fCl8lLA")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public SubBalanceBreakdown1? BalanceBreakdown { get; init; }
}
