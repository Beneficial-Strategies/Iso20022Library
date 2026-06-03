// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument cleared by a central counterparty, with cleared gross notional amount.
/// </summary>
[IsoId("_AAMeAdDzEfCCRJ-TKQa7sQ")]
[DisplayName("Cleared Product3")]
public record ClearedProduct3
{
    /// <summary>
    /// Exchange or trading venue where product is traded.
    /// </summary>
    [IsoId("_AHfY0dDzEfCCRJ-TKQa7sQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [MinLength(1)]
    public SimpleValueList<IsoMICIdentifier> TradingVenue { get; init; } = [];

    /// <summary>
    /// CCP's unique identification for product cleared.
    /// </summary>
    [IsoId("_AHfY09DzEfCCRJ-TKQa7sQ")]
    [DisplayName("CCP Product Identification")]
    [IsoXmlTag("CCPPdctId")]
    public required GenericIdentification168 CCPProductIdentification { get; init; }

    /// <summary>
    /// Standard unique identification of product cleared.
    /// </summary>
    [IsoId("_AHfY1dDzEfCCRJ-TKQa7sQ")]
    [DisplayName("Universal Product Identification")]
    [IsoXmlTag("UvrslPdctId")]
    public GenericIdentification168? UniversalProductIdentification { get; init; }

    /// <summary>
    /// Choice between the major categories of financial instruments.
    /// </summary>
    [IsoId("_AHfY19DzEfCCRJ-TKQa7sQ")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public required Product1Choice_ Product { get; init; }

    /// <summary>
    /// Measure of the current stock of a financial instrument that has been traded on an exchange or cleared via a central counterparty.
    /// </summary>
    [IsoId("_AHfY2dDzEfCCRJ-TKQa7sQ")]
    [DisplayName("Open Interest")]
    [IsoXmlTag("OpnIntrst")]
    public required OpenInterest1 OpenInterest { get; init; }

    /// <summary>
    /// Number of trades cleared over the reporting period.
    /// </summary>
    [IsoId("_AHfY29DzEfCCRJ-TKQa7sQ")]
    [DisplayName("Trades Cleared")]
    [IsoXmlTag("TrdsClrd")]
    public IsoNonNegativeNumber? TradesCleared { get; init; }

    /// <summary>
    /// Gross notional amount that was cleared for that product on the report date.
    /// </summary>
    [IsoId("_AHfY3dDzEfCCRJ-TKQa7sQ")]
    [DisplayName("Cleared Gross Notional Amount")]
    [IsoXmlTag("ClrdGrssNtnlAmt")]
    public required ActiveCurrencyAnd24Amount ClearedGrossNotionalAmount { get; init; }

    /// <summary>
    /// Margin charged on portfolio containing only a fixed amount of a particular product, enabling users to understand the changing risk associated with that product.
    /// </summary>
    [IsoId("_7JW1cNDzEfCCRJ-TKQa7sQ")]
    [DisplayName("Margin Rate Portfolio")]
    [IsoXmlTag("MrgnRatePrtfl")]
    public MarginRatePortfolio1? MarginRatePortfolio { get; init; }
}
