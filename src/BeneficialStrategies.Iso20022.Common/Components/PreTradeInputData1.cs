// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pre-trade input related data.
/// </summary>
/// <remarks>
/// Constraints (not separately modeled as properties — enforced by validators):
/// BuySellIndicatorGuideline: When EmptyBookIndicator is true, then BuySellIndicator is optional.
/// PriceGuideline: When EmptyBookIndicator is true, then Price is optional.
/// QuantityGuideline: When EmptyBookIndicator is true, then Quantity is optional.
/// </remarks>
[IsoId("_zMIJAGF9EfC07JR6e2JJ-w")]
[DisplayName("Pre Trade Input Data1")]
public record PreTradeInputData1
{
    /// <summary>
    /// Code used to identify the financial instrument.
    /// </summary>
    [IsoId("_HXufoGF-EfC07JR6e2JJ-w")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public required IsoISINOct2015Identifier ISIN { get; init; }

    /// <summary>
    /// Indicates whether there are any orders in the book on the bid and/or offer side.
    /// Usage: If this element is not present, it is considered to be false.
    /// </summary>
    [IsoId("_XEv7sI18EfCPs6j8AP0CcQ")]
    [DisplayName("Empty Book Indicator")]
    [IsoXmlTag("MptyBookInd")]
    public IsoTrueFalseIndicator? EmptyBookIndicator { get; init; }

    /// <summary>
    /// Side of the order or quote.
    /// </summary>
    [IsoId("_Ssta4GF-EfC07JR6e2JJ-w")]
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public Side6Code? BuySellIndicator { get; init; }

    /// <summary>
    /// Traded price of the transaction excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_DAuNsGF_EfChAd75JYbucA")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public SecuritiesTransactionPrice26Choice_? Price { get; init; }

    /// <summary>
    /// Quantity to be executed, when there is a partial or full execution.
    /// </summary>
    [IsoId("_YgWYAGF_EfChAd75JYbucA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity25Choice_? Quantity { get; init; }

    /// <summary>
    /// Identification of the trading venue.
    /// </summary>
    [IsoId("_jME64GF_EfChAd75JYbucA")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public required IsoMICIdentifier TradingVenue { get; init; }

    /// <summary>
    /// Date and time when the information was published by the trading venue.
    /// </summary>
    [IsoId("__LEPAKUPEfCmoeslmyBN5Q")]
    [DisplayName("Publication Date Time")]
    [IsoXmlTag("PblctnDtTm")]
    public required IsoISODateTime PublicationDateTime { get; init; }

    /// <summary>
    /// Last update of the date and time when the data was updated.
    /// </summary>
    [IsoId("_YsjFMKUQEfCmoeslmyBN5Q")]
    [DisplayName("Update Date Time")]
    [IsoXmlTag("UpdDtTm")]
    public required IsoISODateTime UpdateDateTime { get; init; }

    /// <summary>
    /// Status in which the instrument that is traded is in.
    /// </summary>
    [IsoId("_s1rngGGBEfCFsvrouDJO7g")]
    [DisplayName("Trading System")]
    [IsoXmlTag("TradgSys")]
    public required TradingSystemData2 TradingSystem { get; init; }
}
