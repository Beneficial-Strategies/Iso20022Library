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
[IsoId("_77KiXdLCEeiN28wlpBQScw")]
[DisplayName("Aggregate Balance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateBalanceInformation35
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AggregateBalanceInformation35 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AggregateBalanceInformation35( SecurityIdentification19 reqFinancialInstrumentIdentification,Balance6 reqAggregateBalance )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        AggregateBalance = reqAggregateBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_8MIWK9LCEeiN28wlpBQScw")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising a financial instrument other than a investment funds.
    /// </summary>
    [IsoId("_8MIWM9LCEeiN28wlpBQScw")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_8MIWO9LCEeiN28wlpBQScw")]
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
    /// Elements used to calculate the valuation haircut.
    /// </summary>
    [IsoId("_8MIWPdLCEeiN28wlpBQScw")]
    [DisplayName("Valuation Haircut Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnHrcutDtls")]
    #endif
    [IsoXmlTag("ValtnHrcutDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BasicCollateralValuation1Details? ValuationHaircutDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BasicCollateralValuation1Details? ValuationHaircutDetails { get; init; } 
    #else
    public BasicCollateralValuation1Details? ValuationHaircutDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_8MIWRdLCEeiN28wlpBQScw")]
    [DisplayName("Aggregate Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AggtBal")]
    #endif
    [IsoXmlTag("AggtBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Balance6 AggregateBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Balance6 AggregateBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance6 AggregateBalance { get; init; } 
    #else
    public Balance6 AggregateBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [IsoId("_8MIWTdLCEeiN28wlpBQScw")]
    [DisplayName("Available Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblBal")]
    #endif
    [IsoXmlTag("AvlblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Balance8? AvailableBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance8? AvailableBalance { get; init; } 
    #else
    public Balance8? AvailableBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [IsoId("_8MIWVdLCEeiN28wlpBQScw")]
    [DisplayName("Not Available Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotAvlblBal")]
    #endif
    [IsoXmlTag("NotAvlblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceQuantity8Choice_? NotAvailableBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceQuantity8Choice_? NotAvailableBalance { get; init; } 
    #else
    public BalanceQuantity8Choice_? NotAvailableBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_8MIWXdLCEeiN28wlpBQScw")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace3? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_8MIWZdLCEeiN28wlpBQScw")]
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
    [IsoId("_8MIWbdLCEeiN28wlpBQScw")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation20? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation20? PriceDetails { get; init; } 
    #else
    public PriceInformation20? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_8MIWddLCEeiN28wlpBQScw")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms34? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms34? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms34? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_8MIWfdLCEeiN28wlpBQScw")]
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
    [IsoId("_8MIWhdLCEeiN28wlpBQScw")]
    [DisplayName("Account Base Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBaseCcyAmts")]
    #endif
    [IsoXmlTag("AcctBaseCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_8MIWjdLCEeiN28wlpBQScw")]
    [DisplayName("Instrument Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmCcyAmts")]
    #endif
    [IsoXmlTag("InstrmCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_8MIWldLCEeiN28wlpBQScw")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown54? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown54? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown54? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_8MIWndLCEeiN28wlpBQScw")]
    [DisplayName("Balance Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalBrkdwn")]
    #endif
    [IsoXmlTag("BalBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubBalanceInformation18? BalanceBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceInformation18? BalanceBreakdown { get; init; } 
    #else
    public SubBalanceInformation18? BalanceBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_8MIWpdLCEeiN28wlpBQScw")]
    [DisplayName("Additional Balance Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBalBrkdwn")]
    #endif
    [IsoXmlTag("AddtlBalBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation18? AdditionalBalanceBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation18? AdditionalBalanceBreakdown { get; init; } 
    #else
    public AdditionalBalanceInformation18? AdditionalBalanceBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    [IsoId("_8MIWrdLCEeiN28wlpBQScw")]
    [DisplayName("Balance At Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalAtSfkpgPlc")]
    #endif
    [IsoXmlTag("BalAtSfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalancePerSafekeepingPlace32? BalanceAtSafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalancePerSafekeepingPlace32? BalanceAtSafekeepingPlace { get; init; } 
    #else
    public AggregateBalancePerSafekeepingPlace32? BalanceAtSafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_8MIWtdLCEeiN28wlpBQScw")]
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
    [IsoId("_8MIWvdLCEeiN28wlpBQScw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
