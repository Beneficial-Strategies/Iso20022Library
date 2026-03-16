// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aggregate Balance Per Safekeeping Place43.
/// </summary>
[IsoId("_XAfkjYS2Ee-Pv9KR9bv9IA")]
[DisplayName("Aggregate Balance Per Safekeeping Place43")]
public partial record AggregateBalancePerSafekeepingPlace43
{
    #nullable enable

    /// <summary>
    /// Account Base Currency Amounts.
    /// </summary>
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 

    /// <summary>
    /// Additional Balance Breakdown.
    /// </summary>
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation20> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Aggregate Balance.
    /// </summary>
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance17 AggregateBalance { get; init; } 

    /// <summary>
    /// Available Balance.
    /// </summary>
    [DisplayName("Available Balance")]
    [IsoXmlTag("AvlblBal")]
    public Balance18? AvailableBalance { get; init; } 

    /// <summary>
    /// Balance Breakdown.
    /// </summary>
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation20> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Days Accrued.
    /// </summary>
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    public IsoNumber? DaysAccrued { get; init; } 

    /// <summary>
    /// Exposure Type.
    /// </summary>
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType25Choice_? ExposureType { get; init; } 

    /// <summary>
    /// Foreign Exchange Details.
    /// </summary>
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms34> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Holding Additional Details.
    /// </summary>
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    public IsoMax350Text? HoldingAdditionalDetails { get; init; } 

    /// <summary>
    /// Instrument Currency Amounts.
    /// </summary>
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 

    /// <summary>
    /// Not Available Balance.
    /// </summary>
    [DisplayName("Not Available Balance")]
    [IsoXmlTag("NotAvlblBal")]
    public BalanceQuantity14Choice_? NotAvailableBalance { get; init; } 

    /// <summary>
    /// Place Of Listing.
    /// </summary>
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 

    /// <summary>
    /// Pledgee.
    /// </summary>
    [DisplayName("Pledgee")]
    [IsoXmlTag("Pldgee")]
    public Pledgee3? Pledgee { get; init; } 

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation29> PriceDetails { get; init; } = [];

    /// <summary>
    /// Quantity Breakdown.
    /// </summary>
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown57> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafeKeepingPlace5 SafekeepingPlace { get; init; } 

    
    #nullable disable
    
}
