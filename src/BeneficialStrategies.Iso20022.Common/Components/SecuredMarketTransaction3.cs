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
/// Provides the details of each individual secured market transaction.
/// </summary>
[IsoId("_hAas9aidEeWHO_l3hf2rlA")]
[DisplayName("Secured Market Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuredMarketTransaction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuredMarketTransaction3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuredMarketTransaction3( TransactionOperationType1Code reqReportedTransactionStatus,System.String reqProprietaryTransactionIdentification,CounterpartyIdentification2Choice_ reqCounterpartyIdentification,DateAndDateTimeChoice_ reqTradeDate,System.DateOnly reqSettlementDate,System.DateOnly reqMaturityDate,MoneyMarketTransactionType1Code reqTransactionType,ActiveCurrencyAndAmount reqTransactionNominalAmount,InterestRateType1Code reqRateType,Collateral14 reqCollateral )
    {
        ReportedTransactionStatus = reqReportedTransactionStatus;
        ProprietaryTransactionIdentification = reqProprietaryTransactionIdentification;
        CounterpartyIdentification = reqCounterpartyIdentification;
        TradeDate = reqTradeDate;
        SettlementDate = reqSettlementDate;
        MaturityDate = reqMaturityDate;
        TransactionType = reqTransactionType;
        TransactionNominalAmount = reqTransactionNominalAmount;
        RateType = reqRateType;
        Collateral = reqCollateral;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
    /// </summary>
    [IsoId("_hc-tJaidEeWHO_l3hf2rlA")]
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
    /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
    /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
    /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
    /// </summary>
    [IsoId("_hc-tJ6idEeWHO_l3hf2rlA")]
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
    [IsoId("_hc-tKaidEeWHO_l3hf2rlA")]
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
    [IsoId("_hc-tK6idEeWHO_l3hf2rlA")]
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
    /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
    /// </summary>
    [IsoId("_hc-tLaidEeWHO_l3hf2rlA")]
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
    [IsoId("_hc-tL6idEeWHO_l3hf2rlA")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
    #else
    public CounterpartyIdentification2Choice_ CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the tri-party agent, when the transaction has been performed via tri-party agent.
    /// </summary>
    [IsoId("_hc-tMaidEeWHO_l3hf2rlA")]
    [DisplayName("Triparty Agent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtId")]
    #endif
    [IsoXmlTag("TrptyAgtId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? TripartyAgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentIdentification { get; init; } 
    #else
    public System.String? TripartyAgentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time on which the parties entered into the reported transaction.
    /// Usage: when time is available, it must be reported.
    /// It is to be reported with only the date when the time of the transaction is not available. 
    /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
    /// </summary>
    [IsoId("_hc-tM6idEeWHO_l3hf2rlA")]
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
    /// Date on which the amount of money is initially exchanged versus the asset as contractually agreed.
    /// Usage:
    /// In the case of open basis repurchase transactions, this is the date on which the rollover settles (even if no exchange of an amount of money takes place).
    /// In the case of a settlement failure in which settlement takes place on a date different than initially agreed, no transactional amendment needs to be reported.
    /// </summary>
    [IsoId("_hc-tNaidEeWHO_l3hf2rlA")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SettlementDate { get; init; } 
    #else
    public System.DateOnly SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the repurchase will be executed, that is the date on which the amount of money is due to be returned or received versus the asset pledged or received as collateral.
    /// </summary>
    [IsoId("_hc-tN6idEeWHO_l3hf2rlA")]
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
    /// Defines whether the transaction is a cash borrowing or cash lending transaction.
    /// </summary>
    [IsoId("_hc-tOaidEeWHO_l3hf2rlA")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MoneyMarketTransactionType1Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MoneyMarketTransactionType1Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyMarketTransactionType1Code TransactionType { get; init; } 
    #else
    public MoneyMarketTransactionType1Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money initially borrowed or lent to be reported as an absolute value.
    /// </summary>
    [IsoId("_hc-tPaidEeWHO_l3hf2rlA")]
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
    /// Specifies whether the transaction interest rate of the repurchase agreements is either fixed or floating (variable rate).
    /// </summary>
    [IsoId("_hc-tP6idEeWHO_l3hf2rlA")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestRateType1Code RateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestRateType1Code RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateType1Code RateType { get; init; } 
    #else
    public InterestRateType1Code RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate expressed in accordance with the local money market convention at which the repurchase agreement has been concluded and at which the cash lent is remunerated.
    /// Usage:
    /// When the remuneration for securities lending transactions is represented by a fee amount, the fee amount will be translated into a deal rate per annum based on the ratio between the fee amount and the transaction nominal amount times number of days based on relevant money market convention divided by the number of days between the settlement date and the maturity of the transaction. 
    /// Only actual values, as opposed to estimated or default values, will be reported for this variable.
    /// This value can be either positive or negative irrespective of whether the cash is borrowed or lent. It represents the contractually agreed remuneration rate on the transaction nominal amount regardless of the transaction sign (that whether the transaction type is reported as borrowed or lent).
    /// </summary>
    [IsoId("_hc-tQaidEeWHO_l3hf2rlA")]
    [DisplayName("Deal Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealRate")]
    #endif
    [IsoXmlTag("DealRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? DealRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? DealRate { get; init; } 
    #else
    public Rate2? DealRate { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase agreement in which the periodic interest payments are calculated on the basis of the value (that is, fixing of an underlying reference rate such as Euribor) on predefined dates (that is, fixing dates) and which has a maturity of no more than one year.
    /// </summary>
    [IsoId("_hc-tQ6idEeWHO_l3hf2rlA")]
    [DisplayName("Floating Rate Repurchase Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRateRpAgrmt")]
    #endif
    [IsoXmlTag("FltgRateRpAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FloatingRateNote2? FloatingRateRepurchaseAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FloatingRateNote2? FloatingRateRepurchaseAgreement { get; init; } 
    #else
    public FloatingRateNote2? FloatingRateRepurchaseAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is arranged via a third party broker or not.
    /// </summary>
    [IsoId("_hc-tRaidEeWHO_l3hf2rlA")]
    [DisplayName("Brokered Deal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrdDeal")]
    #endif
    [IsoXmlTag("BrkrdDeal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BrokeredDeal1Code? BrokeredDeal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BrokeredDeal1Code? BrokeredDeal { get; init; } 
    #else
    public BrokeredDeal1Code? BrokeredDeal { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the asset class pledged as collateral.
    /// </summary>
    [IsoId("_hc-tR6idEeWHO_l3hf2rlA")]
    [DisplayName("Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Coll")]
    #endif
    [IsoXmlTag("Coll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Collateral14 Collateral { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Collateral14 Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Collateral14 Collateral { get; init; } 
    #else
    public Collateral14 Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_hc-tSaidEeWHO_l3hf2rlA")]
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
