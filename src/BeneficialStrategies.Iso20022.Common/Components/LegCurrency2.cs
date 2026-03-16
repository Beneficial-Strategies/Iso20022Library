// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the currency(ies) for each leg of the transaction.
/// </summary>
[IsoId("_q25Pk3hCEeu3kecHd7QKUQ")]
[DisplayName("Leg Currency")]
public record LegCurrency2
{
    /// <summary>
    /// Currency of the notional amount.
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the first leg.
    /// </summary>
    [IsoId("_rFUtEXhCEeu3kecHd7QKUQ")]
    [DisplayName("Currency First Leg")]
    [IsoXmlTag("CcyFrstLeg")]
    public ActiveOrHistoricCurrencyCode? CurrencyFirstLeg { get; init; }

    /// <summary>
    /// Other currency of the notional amount.
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    [IsoId("_rFUtE3hCEeu3kecHd7QKUQ")]
    [DisplayName("Currency Second Leg")]
    [IsoXmlTag("CcyScndLeg")]
    public ActiveOrHistoricCurrencyCode? CurrencySecondLeg { get; init; }
}
