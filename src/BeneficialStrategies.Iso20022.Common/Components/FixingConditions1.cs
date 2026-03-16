// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the additional information for an NDF as supplied on a fixing instruction.
/// </summary>
[IsoId("_-eNb8KZqEea16Jw8SEVrDQ")]
[DisplayName("Fixing Conditions")]
public record FixingConditions1
{
    /// <summary>
    /// The date on which the trade was executed.
    /// </summary>
    [IsoId("_Oe21EKZrEea16Jw8SEVrDQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_b4koM6ZrEea16Jw8SEVrDQ")]
    [DisplayName("Originator Reference")]
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginatorReference { get; init; }

    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_b4koNKZrEea16Jw8SEVrDQ")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; }

    /// <summary>
    /// Reference to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    [IsoId("_b4koNaZrEea16Jw8SEVrDQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; }

    /// <summary>
    /// Currency and amount bought in a foreign exchange trade.
    /// </summary>
    [IsoId("_0g_IYqZrEea16Jw8SEVrDQ")]
    [DisplayName("Trading Side Buy Amount")]
    [IsoXmlTag("TradgSdBuyAmt")]
    public required ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; }

    /// <summary>
    /// Currency and amount sold in a foreign exchange trade.
    /// </summary>
    [IsoId("_0g_IY6ZrEea16Jw8SEVrDQ")]
    [DisplayName("Trading Side Sell Amount")]
    [IsoXmlTag("TradgSdSellAmt")]
    public required ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_B_U80aZsEea16Jw8SEVrDQ")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }
}
