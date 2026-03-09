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
/// Provides the details of each individual foreign exchange swap transaction.
/// </summary>
[IsoId("_r9-RMcEUEea7jLfvGi1PDw")]
[DisplayName("Foreign Exchange Swap Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeSwapTransaction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeSwapTransaction3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeSwapTransaction3( TransactionOperationType1Code reqReportedTransactionStatus,System.String reqProprietaryTransactionIdentification,CounterpartyIdentification3Choice_ reqCounterpartyIdentification,DateAndDateTimeChoice_ reqTradeDate,System.DateOnly reqSpotValueDate,System.DateOnly reqMaturityDate,SecuritiesTransactionType15Code reqTransactionType,ActiveCurrencyAndAmount reqTransactionNominalAmount,ForeignExchange1 reqForeignExchange )
    {
        ReportedTransactionStatus = reqReportedTransactionStatus;
        ProprietaryTransactionIdentification = reqProprietaryTransactionIdentification;
        CounterpartyIdentification = reqCounterpartyIdentification;
        TradeDate = reqTradeDate;
        SpotValueDate = reqSpotValueDate;
        MaturityDate = reqMaturityDate;
        TransactionType = reqTransactionType;
        TransactionNominalAmount = reqTransactionNominalAmount;
        ForeignExchange = reqForeignExchange;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
    /// </summary>
    [IsoId("_sHWPocEUEea7jLfvGi1PDw")]
    [DisplayName("Reported Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdTxSts")]
    #endif
    [IsoXmlTag("RptdTxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
    #else
    public TransactionOperationType1Code ReportedTransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the novation status for the transaction.
    /// </summary>
    [IsoId("_nIOqQcEUEea7jLfvGi1PDw")]
    [DisplayName("Novation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NvtnSts")]
    #endif
    [IsoXmlTag("NvtnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NovationStatus1Code? NovationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NovationStatus1Code? NovationStatus { get; init; } 
    #else
    public NovationStatus1Code? NovationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
    /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
    /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
    /// </summary>
    [IsoId("_sHWPo8EUEea7jLfvGi1PDw")]
    [DisplayName("Branch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrnchId")]
    #endif
    [IsoXmlTag("BrnchId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? BranchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BranchIdentification { get; init; } 
    #else
    public System.String? BranchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
    /// </summary>
    [IsoId("_sHWPpcEUEea7jLfvGi1PDw")]
    [DisplayName("Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqTxIdr")]
    #endif
    [IsoXmlTag("UnqTxIdr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UniqueTransactionIdentifier { get; init; } 
    #else
    public System.String? UniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Internal unique transaction identifier used by the reporting agent for each transaction.
    /// </summary>
    [IsoId("_sHWPp8EUEea7jLfvGi1PDw")]
    [DisplayName("Proprietary Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryTxId")]
    #endif
    [IsoXmlTag("PrtryTxId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProprietaryTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProprietaryTransactionIdentification { get; init; } 
    #else
    public System.String ProprietaryTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original proprietary transaction identifier used by the reporting agent to indicate the proprietary transaction identification of the transaction which is novated.
    /// </summary>
    [IsoId("_SXaRQcEVEea7jLfvGi1PDw")]
    [DisplayName("Related Proprietary Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPrtryTxId")]
    #endif
    [IsoXmlTag("RltdPrtryTxId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? RelatedProprietaryTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedProprietaryTransactionIdentification { get; init; } 
    #else
    public System.String? RelatedProprietaryTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
    /// </summary>
    [IsoId("_sHWPqcEUEea7jLfvGi1PDw")]
    [DisplayName("Counterparty Proprietary Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyPrtryTxId")]
    #endif
    [IsoXmlTag("CtrPtyPrtryTxId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CounterpartyProprietaryTransactionIdentification { get; init; } 
    #else
    public System.String? CounterpartyProprietaryTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    [IsoId("_sHWPq8EUEea7jLfvGi1PDw")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyIdentification3Choice_ CounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyIdentification3Choice_ CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyIdentification3Choice_ CounterpartyIdentification { get; init; } 
    #else
    public CounterpartyIdentification3Choice_ CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time on which the parties entered into the reported transaction.
    /// Usage: when time is available, it must be reported.
    /// It is to be reported with only the date when the time of the transaction is not available. 
    /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
    /// </summary>
    [IsoId("_sHWPrcEUEea7jLfvGi1PDw")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ TradeDate { get; init; } 
    #else
    public DateAndDateTimeChoice_ TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which one party sells to the other a specified amount of a specified currency against payment of an agreed amount of a specified different currency based on an agreed foreign exchange rate known as foreign exchange spot rate.
    /// </summary>
    [IsoId("_sHWPr8EUEea7jLfvGi1PDw")]
    [DisplayName("Spot Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpotValDt")]
    #endif
    [IsoXmlTag("SpotValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SpotValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SpotValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SpotValueDate { get; init; } 
    #else
    public System.DateOnly SpotValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the foreign exchange swap transaction expires and the currency sold on the value date is repurchased.
    /// </summary>
    [IsoId("_sHWPscEUEea7jLfvGi1PDw")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate MaturityDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly MaturityDate { get; init; } 
    #else
    public System.DateOnly MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Defines whether the amount of money reported under the transaction nominal amount is bought or sold on the spot value date.
    /// </summary>
    [IsoId("_sHWPs8EUEea7jLfvGi1PDw")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTransactionType15Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesTransactionType15Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionType15Code TransactionType { get; init; } 
    #else
    public SecuritiesTransactionType15Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nominal amount of the foreign exchange swap, that is the amount bought/sold on the spot value date and reported as an absolute value.
    /// </summary>
    [IsoId("_sHWPtcEUEea7jLfvGi1PDw")]
    [DisplayName("Transaction Nominal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxNmnlAmt")]
    #endif
    [IsoXmlTag("TxNmnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TransactionNominalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the foreign exchange transaction.
    /// </summary>
    [IsoId("_sHWPt8EUEea7jLfvGi1PDw")]
    [DisplayName("Foreign Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FX")]
    #endif
    [IsoXmlTag("FX")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ForeignExchange1 ForeignExchange { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ForeignExchange1 ForeignExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchange1 ForeignExchange { get; init; } 
    #else
    public ForeignExchange1 ForeignExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_sHWPucEUEea7jLfvGi1PDw")]
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
