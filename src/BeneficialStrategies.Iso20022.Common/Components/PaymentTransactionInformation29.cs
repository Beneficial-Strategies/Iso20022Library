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
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[IsoId("_P3_Ridp-Ed-ak6NoX_4Aeg_-327433227")]
[DisplayName("Payment Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransactionInformation29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransactionInformation29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransactionInformation29( ActiveCurrencyAndAmount reqReversedInterbankSettlementAmount )
    {
        ReversedInterbankSettlementAmount = reqReversedInterbankSettlementAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed transaction.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_P4JCgNp-Ed-ak6NoX_4Aeg_-327433196")]
    [DisplayName("Reversal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslId")]
    #endif
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReversalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReversalIdentification { get; init; } 
    #else
    public System.String? ReversalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P4JCgdp-Ed-ak6NoX_4Aeg_-327432896")]
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
    [IsoId("_P4JCgtp-Ed-ak6NoX_4Aeg_-327432835")]
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
    [IsoId("_P4JCg9p-Ed-ak6NoX_4Aeg_-327432804")]
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
    [IsoId("_P4JChNp-Ed-ak6NoX_4Aeg_-1335418230")]
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
    [IsoId("_P4JChdp-Ed-ak6NoX_4Aeg_-327432743")]
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
    /// Amount of money moved between the instructing agent and the instructed agent in the reversed transaction.
    /// </summary>
    [IsoId("_P4JChtp-Ed-ak6NoX_4Aeg_-327432342")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvsdIntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: The InterbankSettlementDate is the interbank settlement date of the reversal message, and not of the original instruction.
    /// </summary>
    [IsoId("_P4JCh9p-Ed-ak6NoX_4Aeg_-327432464")]
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
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// </summary>
    [IsoId("_P4SMcNp-Ed-ak6NoX_4Aeg_-327432311")]
    [DisplayName("Reversed Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvsdInstdAmt")]
    #endif
    [IsoXmlTag("RvsdInstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_P4SMcdp-Ed-ak6NoX_4Aeg_-327432403")]
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
    [IsoId("_P4SMctp-Ed-ak6NoX_4Aeg_-327432433")]
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
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_P4SMc9p-Ed-ak6NoX_4Aeg_-327432372")]
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
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the reversal transaction.
    /// </summary>
    [IsoId("_P4SMdNp-Ed-ak6NoX_4Aeg_-327432187")]
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
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_P4SMddp-Ed-ak6NoX_4Aeg_-327432218")]
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
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the reversal message and not the party that received the original instruction that is being reversed.
    /// </summary>
    [IsoId("_P4SMdtp-Ed-ak6NoX_4Aeg_-327431909")]
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
    /// Set of elements used to provide detailed information on the reversal reason.
    /// </summary>
    [IsoId("_P4SMd9p-Ed-ak6NoX_4Aeg_-327431940")]
    [DisplayName("Reversal Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRsnInf")]
    #endif
    [IsoXmlTag("RvslRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalReasonInformation6? ReversalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalReasonInformation6? ReversalReasonInformation { get; init; } 
    #else
    public ReversalReasonInformation6? ReversalReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P4SMeNp-Ed-ak6NoX_4Aeg_-327432265")]
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
