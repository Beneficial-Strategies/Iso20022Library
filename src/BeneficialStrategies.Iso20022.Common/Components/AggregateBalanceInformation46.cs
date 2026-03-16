// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aggregate Balance Information46.
/// </summary>
[IsoId("_W2ghr4S2Ee-Pv9KR9bv9IA")]
[DisplayName("Aggregate Balance Information46")]
public partial record AggregateBalanceInformation46
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
    /// Balance At Safekeeping Place.
    /// </summary>
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public ValueList<AggregateBalancePerSafekeepingPlace43> BalanceAtSafekeepingPlace { get; init; } = [];

    /// <summary>
    /// Balance Breakdown.
    /// </summary>
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation20> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Corporate Action Option Type.
    /// </summary>
    [DisplayName("Corporate Action Option Type")]
    [IsoXmlTag("CorpActnOptnTp")]
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; } 

    /// <summary>
    /// Days Accrued.
    /// </summary>
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    public IsoNumber? DaysAccrued { get; init; } 

    /// <summary>
    /// Financial Instrument Attributes.
    /// </summary>
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; } 

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 

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
    /// Investment Funds Financial Instrument Attributes.
    /// </summary>
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; init; } 

    /// <summary>
    /// Not Available Balance.
    /// </summary>
    [DisplayName("Not Available Balance")]
    [IsoXmlTag("NotAvlblBal")]
    public BalanceQuantity14Choice_? NotAvailableBalance { get; init; } 

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
    public SafeKeepingPlace5? SafekeepingPlace { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Valuation Haircut Details.
    /// </summary>
    [DisplayName("Valuation Haircut Details")]
    [IsoXmlTag("ValtnHrcutDtls")]
    public BasicCollateralValuation1Details? ValuationHaircutDetails { get; init; } 

    
    #nullable disable
    
}
