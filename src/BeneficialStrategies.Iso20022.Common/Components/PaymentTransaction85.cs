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
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_tPtmEYlrEeePr-EGJjGYzQ")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction85
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_teu5hYlrEeePr-EGJjGYzQ")]
    [DisplayName("Cancellation Status Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlStsId")]
    #endif
    [IsoXmlTag("CxlStsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationStatusIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationStatusIdentification { get; init; } 
    #else
    public System.String? CancellationStatusIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_teu5h4lrEeePr-EGJjGYzQ")]
    [DisplayName("Resolved Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RslvdCase")]
    #endif
    [IsoXmlTag("RslvdCase")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case4? ResolvedCase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case4? ResolvedCase { get; init; } 
    #else
    public Case4? ResolvedCase { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_teu5iYlrEeePr-EGJjGYzQ")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation29? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_teu5i4lrEeePr-EGJjGYzQ")]
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
    [IsoId("_teu5jYlrEeePr-EGJjGYzQ")]
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
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_teu5j4lrEeePr-EGJjGYzQ")]
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
    [IsoId("_teu5kYlrEeePr-EGJjGYzQ")]
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
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    [IsoId("_teu5k4lrEeePr-EGJjGYzQ")]
    [DisplayName("Transaction Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCxlSts")]
    #endif
    [IsoXmlTag("TxCxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; } 
    #else
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_teu5lYlrEeePr-EGJjGYzQ")]
    [DisplayName("Cancellation Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlStsRsnInf")]
    #endif
    [IsoXmlTag("CxlStsRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationStatusReason3? CancellationStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatusReason3? CancellationStatusReasonInformation { get; init; } 
    #else
    public CancellationStatusReason3? CancellationStatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of a return or a reversal transaction that is initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    [IsoId("_teu5l4lrEeePr-EGJjGYzQ")]
    [DisplayName("Resolution Related Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltnRltdInf")]
    #endif
    [IsoXmlTag("RsltnRltdInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResolutionInformation2? ResolutionRelatedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResolutionInformation2? ResolutionRelatedInformation { get; init; } 
    #else
    public ResolutionInformation2? ResolutionRelatedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    [IsoId("_teu5mYlrEeePr-EGJjGYzQ")]
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
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_teu5m4lrEeePr-EGJjGYzQ")]
    [DisplayName("Original Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlIntrBkSttlmDt")]
    #endif
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OriginalInterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OriginalInterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? OriginalInterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party who assigns the case.|Usage: This is also the agent that instructs the next party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_teu5nYlrEeePr-EGJjGYzQ")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party35Choice_? Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party35Choice_? Assigner { get; init; } 
    #else
    public Party35Choice_? Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the agent that is instructed by the previous party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_teu5n4lrEeePr-EGJjGYzQ")]
    [DisplayName("Assignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgne")]
    #endif
    [IsoXmlTag("Assgne")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party35Choice_? Assignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party35Choice_? Assignee { get; init; } 
    #else
    public Party35Choice_? Assignee { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_teu5oYlrEeePr-EGJjGYzQ")]
    [DisplayName("Original Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxRef")]
    #endif
    [IsoXmlTag("OrgnlTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; } 
    #else
    public OriginalTransactionReference27? OriginalTransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
