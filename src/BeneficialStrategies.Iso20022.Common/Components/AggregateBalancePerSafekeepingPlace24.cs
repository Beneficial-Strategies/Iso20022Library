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
[IsoId("_-ZTyEU96EeSn2-3swbRbzg")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public record AggregateBalancePerSafekeepingPlace24
{
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_-01QeU96EeSn2-3swbRbzg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormat3Choice_ SafekeepingPlace { get; init; }

    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_-01QgU96EeSn2-3swbRbzg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [IsoId("_rZL6oE97EeSn2-3swbRbzg")]
    [DisplayName("Pledgee")]
    [IsoXmlTag("Pldgee")]
    public PledgeeFormat1Choice_? Pledgee { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_-01QiU96EeSn2-3swbRbzg")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance1 AggregateBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [IsoId("_-01QkU96EeSn2-3swbRbzg")]
    [DisplayName("Available Balance")]
    [IsoXmlTag("AvlblBal")]
    public BalanceQuantity5Choice_? AvailableBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [IsoId("_-01QmU96EeSn2-3swbRbzg")]
    [DisplayName("Not Available Balance")]
    [IsoXmlTag("NotAvlblBal")]
    public BalanceQuantity5Choice_? NotAvailableBalance { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_-01QoU96EeSn2-3swbRbzg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation5> PriceDetails { get; init; } = [];

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_-01QqU96EeSn2-3swbRbzg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms14> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_-01QsU96EeSn2-3swbRbzg")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_-01QuU96EeSn2-3swbRbzg")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_-01QwU96EeSn2-3swbRbzg")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_-01QyU96EeSn2-3swbRbzg")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown23> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_urm4ME98EeSn2-3swbRbzg")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType12Choice_? ExposureType { get; init; }

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_-01Q0U96EeSn2-3swbRbzg")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation11> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_-01Q2U96EeSn2-3swbRbzg")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation11> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_-01Q4U96EeSn2-3swbRbzg")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? HoldingAdditionalDetails { get; init; }
}
