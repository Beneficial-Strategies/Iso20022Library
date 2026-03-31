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
[IsoId("_ciB2zTi8Eeydid5dcNPKvg")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public record AggregateBalancePerSafekeepingPlace40
{
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_ciB21Ti8Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafeKeepingPlace4 SafekeepingPlace { get; init; }

    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_ciB23Ti8Eeydid5dcNPKvg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification4Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [IsoId("_ciB25Ti8Eeydid5dcNPKvg")]
    [DisplayName("Pledgee")]
    [IsoXmlTag("Pldgee")]
    public Pledgee4? Pledgee { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_ciB25zi8Eeydid5dcNPKvg")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance22 AggregateBalance { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_ciB27zi8Eeydid5dcNPKvg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation22> PriceDetails { get; init; } = [];

    // ID for the above is _ciB27zi8Eeydid5dcNPKvg

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_ciB29zi8Eeydid5dcNPKvg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms35> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_ciB2_zi8Eeydid5dcNPKvg")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_ciB3Bzi8Eeydid5dcNPKvg")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public required BalanceAmounts5 AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_ciB3Dzi8Eeydid5dcNPKvg")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts5? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in a currency other than the base currency of the account.
    /// </summary>
    [IsoId("_ciB3Fzi8Eeydid5dcNPKvg")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts5? AlternateReportingCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_ciB3Hzi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown70> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_ciB3Jzi8Eeydid5dcNPKvg")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType24Choice_? ExposureType { get; init; }

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_ciB3KTi8Eeydid5dcNPKvg")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation23> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_ciB3MTi8Eeydid5dcNPKvg")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation23> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_ciB3OTi8Eeydid5dcNPKvg")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? HoldingAdditionalDetails { get; init; }
}
