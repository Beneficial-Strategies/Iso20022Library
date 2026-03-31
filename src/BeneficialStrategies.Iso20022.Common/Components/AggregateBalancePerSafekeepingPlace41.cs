// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_csbI-Ti8Eeydid5dcNPKvg")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public record AggregateBalancePerSafekeepingPlace41
{
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_csbJATi8Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafeKeepingPlace4 SafekeepingPlace { get; init; }

    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_csbJCTi8Eeydid5dcNPKvg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification4Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Entity to which the financial instruments are pledged.
    /// </summary>
    [IsoId("_csbJETi8Eeydid5dcNPKvg")]
    [DisplayName("Pledgee")]
    [IsoXmlTag("Pldgee")]
    public Pledgee4? Pledgee { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_csbJEzi8Eeydid5dcNPKvg")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance22 AggregateBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [IsoId("_csbJGzi8Eeydid5dcNPKvg")]
    [DisplayName("Available Balance")]
    [IsoXmlTag("AvlblBal")]
    public Balance25? AvailableBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [IsoId("_csbJIzi8Eeydid5dcNPKvg")]
    [DisplayName("Not Available Balance")]
    [IsoXmlTag("NotAvlblBal")]
    public BalanceQuantity17Choice_? NotAvailableBalance { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_csbJKzi8Eeydid5dcNPKvg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation22> PriceDetails { get; init; } = [];

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_csbJMzi8Eeydid5dcNPKvg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms35> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_csbJOzi8Eeydid5dcNPKvg")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_csbJQzi8Eeydid5dcNPKvg")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts4? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_csbJSzi8Eeydid5dcNPKvg")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts4? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_csbJUzi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown71> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_csbJWzi8Eeydid5dcNPKvg")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType24Choice_? ExposureType { get; init; }

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_csbJXTi8Eeydid5dcNPKvg")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation24> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_csbJZTi8Eeydid5dcNPKvg")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation24> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_csbJbTi8Eeydid5dcNPKvg")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? HoldingAdditionalDetails { get; init; }
}
