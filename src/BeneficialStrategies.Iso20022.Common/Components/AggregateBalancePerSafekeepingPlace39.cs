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
[IsoId("_hXcvnyp6EeyR9JrVGfaMKw")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public record AggregateBalancePerSafekeepingPlace39
{
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_husxZyp6EeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafeKeepingPlace3 SafekeepingPlace { get; init; }

    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_husxbyp6EeyR9JrVGfaMKw")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Entity to which the financial instruments are pledged.
    /// </summary>
    [IsoId("_husxdyp6EeyR9JrVGfaMKw")]
    [DisplayName("Pledgee")]
    [IsoXmlTag("Pldgee")]
    public Pledgee3? Pledgee { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_husxeSp6EeyR9JrVGfaMKw")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance17 AggregateBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [IsoId("_husxgSp6EeyR9JrVGfaMKw")]
    [DisplayName("Available Balance")]
    [IsoXmlTag("AvlblBal")]
    public Balance18? AvailableBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [IsoId("_husxiSp6EeyR9JrVGfaMKw")]
    [DisplayName("Not Available Balance")]
    [IsoXmlTag("NotAvlblBal")]
    public BalanceQuantity14Choice_? NotAvailableBalance { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_husxkSp6EeyR9JrVGfaMKw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation20> PriceDetails { get; init; } = [];

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_husxmSp6EeyR9JrVGfaMKw")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms34> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_husxoSp6EeyR9JrVGfaMKw")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_husxqSp6EeyR9JrVGfaMKw")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_husxsSp6EeyR9JrVGfaMKw")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_husxuSp6EeyR9JrVGfaMKw")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown57> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_husxwSp6EeyR9JrVGfaMKw")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType22Choice_? ExposureType { get; init; }

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_husxwyp6EeyR9JrVGfaMKw")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation20> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_husxyyp6EeyR9JrVGfaMKw")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation20> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_husx0yp6EeyR9JrVGfaMKw")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? HoldingAdditionalDetails { get; init; }
}
