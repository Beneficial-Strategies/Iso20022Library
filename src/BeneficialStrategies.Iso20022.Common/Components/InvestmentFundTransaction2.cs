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
/// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
/// </summary>
[IsoId("_VGOQ-tp-Ed-ak6NoX_4Aeg_-1833771297")]
[DisplayName("Investment Fund Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentFundTransaction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentFundTransaction2( TransactionType1CodeChoice_ reqTransactionType,CorporateActionEventType1CodeChoice_ reqCorporateActionEventType,System.String reqSettledTransactionIndicator,System.String reqRegisteredTransactionIndicator,FinancialInstrumentQuantity1 reqUnitsQuantity,CreditDebitCode reqCreditDebit,DateAndDateTimeChoice_ reqTradeDateTime,System.String reqCumDividendIndicator,System.String reqPartiallyExecutedIndicator )
    {
        TransactionType = reqTransactionType;
        CorporateActionEventType = reqCorporateActionEventType;
        SettledTransactionIndicator = reqSettledTransactionIndicator;
        RegisteredTransactionIndicator = reqRegisteredTransactionIndicator;
        UnitsQuantity = reqUnitsQuantity;
        CreditDebit = reqCreditDebit;
        TradeDateTime = reqTradeDateTime;
        CumDividendIndicator = reqCumDividendIndicator;
        PartiallyExecutedIndicator = reqPartiallyExecutedIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of investment fund transaction.
    /// </summary>
    [IsoId("_VGOQ-9p-Ed-ak6NoX_4Aeg_-697839942")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionType1CodeChoice_ TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionType1CodeChoice_ TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionType1CodeChoice_ TransactionType { get; init; } 
    #else
    public TransactionType1CodeChoice_ TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_VGOQ_Np-Ed-ak6NoX_4Aeg_-1862767787")]
    [DisplayName("Corporate Action Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtTp")]
    #endif
    [IsoXmlTag("CorpActnEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventType1CodeChoice_ CorporateActionEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventType1CodeChoice_ CorporateActionEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType1CodeChoice_ CorporateActionEventType { get; init; } 
    #else
    public CorporateActionEventType1CodeChoice_ CorporateActionEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Status of an investment fund transaction.
    /// </summary>
    [IsoId("_VGOQ_dp-Ed-ak6NoX_4Aeg_-690455186")]
    [DisplayName("Booking Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookgSts")]
    #endif
    [IsoXmlTag("BookgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionStatus1Code? BookingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus1Code? BookingStatus { get; init; } 
    #else
    public TransactionStatus1Code? BookingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_VGOQ_tp-Ed-ak6NoX_4Aeg_-690455126")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for an order, as assigned by the sell-side. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_VGOQ_9p-Ed-ak6NoX_4Aeg_-690455056")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OrderReference { get; init; } 
    #else
    public System.String? OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VGXa4Np-Ed-ak6NoX_4Aeg_-690454779")]
    [DisplayName("Deal Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealRef")]
    #endif
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DealReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DealReference { get; init; } 
    #else
    public System.String? DealReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_VGXa4dp-Ed-ak6NoX_4Aeg_1094293937")]
    [DisplayName("Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegId")]
    #endif
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegIdentification { get; init; } 
    #else
    public System.String? LegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_VGXa4tp-Ed-ak6NoX_4Aeg_-1320347699")]
    [DisplayName("Leg Execution Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegExctnId")]
    #endif
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LegExecutionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegExecutionIdentification { get; init; } 
    #else
    public System.String? LegExecutionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VGXa49p-Ed-ak6NoX_4Aeg_1044421350")]
    [DisplayName("Order Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDtTm")]
    #endif
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OrderDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OrderDateTime { get; init; } 
    #else
    public System.DateTime? OrderDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash payment with respect to the executed order is settled.
    /// </summary>
    [IsoId("_VGXa5Np-Ed-ak6NoX_4Aeg_1044421410")]
    [DisplayName("Settled Transaction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttldTxInd")]
    #endif
    [IsoXmlTag("SttldTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SettledTransactionIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SettledTransactionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SettledTransactionIndicator { get; init; } 
    #else
    public System.String SettledTransactionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the executed order has a registered status on the books of the transfer agent.
    /// </summary>
    [IsoId("_VGXa5dp-Ed-ak6NoX_4Aeg_25813824")]
    [DisplayName("Registered Transaction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdTxInd")]
    #endif
    [IsoXmlTag("RegdTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator RegisteredTransactionIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegisteredTransactionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegisteredTransactionIndicator { get; init; } 
    #else
    public System.String RegisteredTransactionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Number of investment funds units.
    /// </summary>
    [IsoId("_VGXa5tp-Ed-ak6NoX_4Aeg_1272027096")]
    [DisplayName("Units Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsQty")]
    #endif
    [IsoXmlTag("UnitsQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1 UnitsQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1 UnitsQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1 UnitsQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1 UnitsQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Direction of the transaction being reported, ie, securities are received (credited) or delivered (debited).
    /// </summary>
    [IsoId("_VGXa59p-Ed-ak6NoX_4Aeg_-1179141618")]
    [DisplayName("Credit Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbt")]
    #endif
    [IsoXmlTag("CdtDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebit { get; init; } 
    #else
    public CreditDebitCode CreditDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction being reported is a reversal of previously reported transaction.
    /// </summary>
    [IsoId("_VGXa6Np-Ed-ak6NoX_4Aeg_-1585678185")]
    [DisplayName("Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvsl")]
    #endif
    [IsoXmlTag("Rvsl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalCode? Reversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalCode? Reversal { get; init; } 
    #else
    public ReversalCode? Reversal { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_VGXa6dp-Ed-ak6NoX_4Aeg_1272027390")]
    [DisplayName("Gross Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssSttlmAmt")]
    #endif
    [IsoXmlTag("GrssSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GrossSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GrossSettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GrossSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the debtor expects the amount of money to be available to the creditor.
    /// </summary>
    [IsoId("_VGhL4Np-Ed-ak6NoX_4Aeg_1272027468")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_VGhL4dp-Ed-ak6NoX_4Aeg_1272027793")]
    [DisplayName("Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtTm")]
    #endif
    [IsoXmlTag("TradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ TradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_VGhL4tp-Ed-ak6NoX_4Aeg_1272027853")]
    [DisplayName("Cum Dividend Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CumDvddInd")]
    #endif
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CumDividendIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CumDividendIndicator { get; init; } 
    #else
    public System.String CumDividendIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_VGhL49p-Ed-ak6NoX_4Aeg_1272027948")]
    [DisplayName("Partially Executed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlyExctdInd")]
    #endif
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PartiallyExecutedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PartiallyExecutedIndicator { get; init; } 
    #else
    public System.String PartiallyExecutedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_VGhL5Np-Ed-ak6NoX_4Aeg_-1538101759")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice1? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice1? PriceDetails { get; init; } 
    #else
    public UnitPrice1? PriceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
