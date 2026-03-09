// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall position, in a single security, held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_R85vk9p-Ed-ak6NoX_4Aeg_1140452433")]
[DisplayName("Aggregate Balance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateBalanceInformation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AggregateBalanceInformation8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AggregateBalanceInformation8( SecurityIdentification11 reqFinancialInstrumentIdentification,Balance1 reqAggregateBalance,BalanceAmounts1 reqAccountBaseCurrencyAmounts )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        AggregateBalance = reqAggregateBalance;
        AccountBaseCurrencyAmounts = reqAccountBaseCurrencyAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_R85vlNp-Ed-ak6NoX_4Aeg_1148763203")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification11 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_R85vldp-Ed-ak6NoX_4Aeg_648871890")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes8? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes8? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes8? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_R85vltp-Ed-ak6NoX_4Aeg_-1626621742")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndsFinInstrmAttrbts")]
    #endif
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the swap contract.
    /// </summary>
    [IsoId("_R85vl9p-Ed-ak6NoX_4Aeg_648872106")]
    [DisplayName("Additional Derivative Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlDerivAttrbts")]
    #endif
    [IsoXmlTag("AddtlDerivAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeBasicAttributes1? AdditionalDerivativeAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeBasicAttributes1? AdditionalDerivativeAttributes { get; init; } 
    #else
    public DerivativeBasicAttributes1? AdditionalDerivativeAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_R85vmNp-Ed-ak6NoX_4Aeg_-1656993155")]
    [DisplayName("Aggregate Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AggtBal")]
    #endif
    [IsoXmlTag("AggtBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Balance1 AggregateBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Balance1 AggregateBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance1 AggregateBalance { get; init; } 
    #else
    public Balance1 AggregateBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_R85vmdp-Ed-ak6NoX_4Aeg_1592953385")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_R9DgkNp-Ed-ak6NoX_4Aeg_1148760805")]
    [DisplayName("Corporate Action Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnOptnTp")]
    #endif
    [IsoXmlTag("CorpActnOptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; } 
    #else
    public CorporateActionOption5Code? CorporateActionOptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_R9Dgkdp-Ed-ak6NoX_4Aeg_1148763047")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation5> PriceDetails { get; init; } = new ValueList<PriceInformation5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R9Dgkdp-Ed-ak6NoX_4Aeg_1148763047
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_R9Dgktp-Ed-ak6NoX_4Aeg_1148763082")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms1? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms1? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms1? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_R9Dgk9p-Ed-ak6NoX_4Aeg_1148760753")]
    [DisplayName("Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DaysAcrd")]
    #endif
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DaysAccrued { get; init; } 
    #else
    public System.UInt64? DaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_R9DglNp-Ed-ak6NoX_4Aeg_1148761565")]
    [DisplayName("Account Base Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBaseCcyAmts")]
    #endif
    [IsoXmlTag("AcctBaseCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceAmounts1 AccountBaseCurrencyAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceAmounts1 AccountBaseCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts1 AccountBaseCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts1 AccountBaseCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_R9Dgldp-Ed-ak6NoX_4Aeg_1148761282")]
    [DisplayName("Instrument Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmCcyAmts")]
    #endif
    [IsoXmlTag("InstrmCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts1? InstrumentCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts1? InstrumentCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts1? InstrumentCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts provided in another currency than the base currency of the account.
    /// </summary>
    [IsoId("_R9Dgltp-Ed-ak6NoX_4Aeg_1148761187")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnRptgCcyAmts")]
    #endif
    [IsoXmlTag("AltrnRptgCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts1? AlternateReportingCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts1? AlternateReportingCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts1? AlternateReportingCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_R9Dgl9p-Ed-ak6NoX_4Aeg_1148763141")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown4? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown4? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown4? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_R9DgmNp-Ed-ak6NoX_4Aeg_1148762745")]
    [DisplayName("Balance Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalBrkdwn")]
    #endif
    [IsoXmlTag("BalBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubBalanceInformation6? BalanceBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceInformation6? BalanceBreakdown { get; init; } 
    #else
    public SubBalanceInformation6? BalanceBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_R9Dgmdp-Ed-ak6NoX_4Aeg_1148762787")]
    [DisplayName("Additional Balance Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBalBrkdwn")]
    #endif
    [IsoXmlTag("AddtlBalBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation6? AdditionalBalanceBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation6? AdditionalBalanceBreakdown { get; init; } 
    #else
    public AdditionalBalanceInformation6? AdditionalBalanceBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    [IsoId("_R9NRkNp-Ed-ak6NoX_4Aeg_40789848")]
    [DisplayName("Balance At Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalAtSfkpgPlc")]
    #endif
    [IsoXmlTag("BalAtSfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalancePerSafekeepingPlace7? BalanceAtSafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalancePerSafekeepingPlace7? BalanceAtSafekeepingPlace { get; init; } 
    #else
    public AggregateBalancePerSafekeepingPlace7? BalanceAtSafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_R9NRkdp-Ed-ak6NoX_4Aeg_1148760883")]
    [DisplayName("Holding Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgAddtlDtls")]
    #endif
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? HoldingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HoldingAdditionalDetails { get; init; } 
    #else
    public System.String? HoldingAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_R9NRktp-Ed-ak6NoX_4Aeg_-209736665")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension2? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension2? Extension { get; init; } 
    #else
    public Extension2? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
