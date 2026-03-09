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
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_P5VVUdp-Ed-ak6NoX_4Aeg_225114103")]
[DisplayName("Payment Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransactionInformation27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransactionInformation27 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransactionInformation27( ActiveCurrencyAndAmount reqReturnedInterbankSettlementAmount )
    {
        ReturnedInterbankSettlementAmount = reqReturnedInterbankSettlementAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_P5VVUtp-Ed-ak6NoX_4Aeg_225114352")]
    [DisplayName("Return Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrId")]
    #endif
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReturnIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReturnIdentification { get; init; } 
    #else
    public System.String? ReturnIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_P5VVU9p-Ed-ak6NoX_4Aeg_225115792")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation3? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P5VVVNp-Ed-ak6NoX_4Aeg_225114412")]
    [DisplayName("Original Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstrId")]
    #endif
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalInstructionIdentification { get; init; } 
    #else
    public System.String? OriginalInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_P5VVVdp-Ed-ak6NoX_4Aeg_225114473")]
    [DisplayName("Original End To End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlEndToEndId")]
    #endif
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalEndToEndIdentification { get; init; } 
    #else
    public System.String? OriginalEndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to umambiguously identify the transaction.
    /// </summary>
    [IsoId("_P5VVVtp-Ed-ak6NoX_4Aeg_225114783")]
    [DisplayName("Original Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxId")]
    #endif
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalTransactionIdentification { get; init; } 
    #else
    public System.String? OriginalTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P5VVV9p-Ed-ak6NoX_4Aeg_537745721")]
    [DisplayName("Original Clearing System Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlClrSysRef")]
    #endif
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalClearingSystemReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalClearingSystemReference { get; init; } 
    #else
    public System.String? OriginalClearingSystemReference { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_P5VVWNp-Ed-ak6NoX_4Aeg_225114813")]
    [DisplayName("Original Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlIntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent in the returned transaction.
    /// </summary>
    [IsoId("_P5VVWdp-Ed-ak6NoX_4Aeg_225115028")]
    [DisplayName("Returned Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrdIntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_P5efQNp-Ed-ak6NoX_4Aeg_225114874")]
    [DisplayName("Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDt")]
    #endif
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// </summary>
    [IsoId("_P5efQdp-Ed-ak6NoX_4Aeg_225115050")]
    [DisplayName("Returned Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrdInstdAmt")]
    #endif
    [IsoXmlTag("RtrdInstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_P5efQtp-Ed-ak6NoX_4Aeg_225114936")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_P5efQ9p-Ed-ak6NoX_4Aeg_225114905")]
    [DisplayName("Compensation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CompstnAmt")]
    #endif
    [IsoXmlTag("CompstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_P5efRNp-Ed-ak6NoX_4Aeg_225114966")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    [IsoId("_P5efRdp-Ed-ak6NoX_4Aeg_225115360")]
    [DisplayName("Charges Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsInf")]
    #endif
    [IsoXmlTag("ChrgsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesInformation5? ChargesInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesInformation5? ChargesInformation { get; init; } 
    #else
    public ChargesInformation5? ChargesInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_P5efRtp-Ed-ak6NoX_4Aeg_225115421")]
    [DisplayName("Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgt")]
    #endif
    [IsoXmlTag("InstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_P5efR9p-Ed-ak6NoX_4Aeg_225115452")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide detailed information on the return reason.
    /// </summary>
    [IsoId("_P5efSNp-Ed-ak6NoX_4Aeg_225115761")]
    [DisplayName("Return Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrRsnInf")]
    #endif
    [IsoXmlTag("RtrRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReturnReasonInformation9? ReturnReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnReasonInformation9? ReturnReasonInformation { get; init; } 
    #else
    public ReturnReasonInformation9? ReturnReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P5efSdp-Ed-ak6NoX_4Aeg_225115329")]
    [DisplayName("Original Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxRef")]
    #endif
    [IsoXmlTag("OrgnlTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; } 
    #else
    public OriginalTransactionReference13? OriginalTransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
