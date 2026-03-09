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
[IsoId("_3zPtGQf9EeSaceXTzyiZRg")]
[DisplayName("Investment Fund Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundTransaction4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentFundTransaction4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentFundTransaction4( TransactionType1Choice_ reqEventType,System.String reqSettledTransactionIndicator,System.String reqRegisteredTransactionIndicator,FinancialInstrumentQuantity1 reqUnitsQuantity,CreditDebitCode reqCreditDebit,DateAndDateTimeChoice_ reqTradeDateTime,System.String reqCumDividendIndicator,System.String reqPartiallyExecutedIndicator )
    {
        EventType = reqEventType;
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
    /// Underlying transaction or corporate action.
    /// </summary>
    [IsoId("_1FreEAf-EeSaceXTzyiZRg")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionType1Choice_ EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionType1Choice_ EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionType1Choice_ EventType { get; init; } 
    #else
    public TransactionType1Choice_ EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Status of an investment fund transaction.
    /// </summary>
    [IsoId("_4OBkkQf9EeSaceXTzyiZRg")]
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
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_4OBkkwf9EeSaceXTzyiZRg")]
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
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_4OBklQf9EeSaceXTzyiZRg")]
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
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_4OBklwf9EeSaceXTzyiZRg")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientReference { get; init; } 
    #else
    public System.String? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_4OBkmQf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBkmwf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBknQf9EeSaceXTzyiZRg")]
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
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("_4OBknwf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBkoQf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBkowf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBkpQf9EeSaceXTzyiZRg")]
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
    /// Direction of the transaction being reported, is, securities are received (credited) or delivered (debited).
    /// </summary>
    [IsoId("_4OBkpwf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBkqQf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBkqwf9EeSaceXTzyiZRg")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the debtor expects the amount of money to be available to the creditor.
    /// </summary>
    [IsoId("_4OBkrQf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBkrwf9EeSaceXTzyiZRg")]
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
    /// Indicates whether the dividend is included, that is, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_4OBksQf9EeSaceXTzyiZRg")]
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
    /// Indicates whether the order has been partially executed, that is, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_4OBkswf9EeSaceXTzyiZRg")]
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
    [IsoId("_4OBktQf9EeSaceXTzyiZRg")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice20? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice20? PriceDetails { get; init; } 
    #else
    public UnitPrice20? PriceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
