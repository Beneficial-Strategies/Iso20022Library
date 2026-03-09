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
/// Reference and status information concerning the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_PsXQU9p-Ed-ak6NoX_4Aeg_-1190214356")]
[DisplayName("Payment Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransactionInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransactionInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransactionInformation2( CurrencyAndAmount reqReturnedInterbankSettlementAmount )
    {
        ReturnedInterbankSettlementAmount = reqReturnedInterbankSettlementAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the returned transaction.
    /// </summary>
    [IsoId("_PsXQVNp-Ed-ak6NoX_4Aeg_-1190213875")]
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
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_PsXQVdp-Ed-ak6NoX_4Aeg_-2131644084")]
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
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    [IsoId("_PsXQVtp-Ed-ak6NoX_4Aeg_-1551043273")]
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
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_PsXQV9p-Ed-ak6NoX_4Aeg_-1190213970")]
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
    /// Original identification of a transaction, as assigned by the first instructing agent and passed on, unchanged, throughout the entire interbank chain.
    /// </summary>
    [IsoId("_PsXQWNp-Ed-ak6NoX_4Aeg_511775997")]
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
    /// Original amount of money as moved between the instructing agent and the instructed agent in the original transaction.
    /// </summary>
    [IsoId("_PshBUNp-Ed-ak6NoX_4Aeg_-1190213840")]
    [DisplayName("Original Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlIntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    #else
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Returned amount of money moved between the instructing agent and the instructed agent in the return transaction.
    /// </summary>
    [IsoId("_PshBUdp-Ed-ak6NoX_4Aeg_-1190213331")]
    [DisplayName("Returned Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrdIntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    #else
    public CurrencyAndAmount ReturnedInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_PshBUtp-Ed-ak6NoX_4Aeg_-1190213763")]
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
    [IsoId("_PshBU9p-Ed-ak6NoX_4Aeg_1617271903")]
    [DisplayName("Returned Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrdInstdAmt")]
    #endif
    [IsoXmlTag("RtrdInstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? ReturnedInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? ReturnedInstructedAmount { get; init; } 
    #else
    public CurrencyAndAmount? ReturnedInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// The factor used for conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_PshBVNp-Ed-ak6NoX_4Aeg_-1190213443")]
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
    [IsoId("_PshBVdp-Ed-ak6NoX_4Aeg_-1190213720")]
    [DisplayName("Compensation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CompstnAmt")]
    #endif
    [IsoXmlTag("CompstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? CompensationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? CompensationAmount { get; init; } 
    #else
    public CurrencyAndAmount? CompensationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_PshBVtp-Ed-ak6NoX_4Aeg_-1190213408")]
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
    /// Transaction charges to be paid by the charge bearer for the return transaction.
    /// </summary>
    [IsoId("_PshBV9p-Ed-ak6NoX_4Aeg_-2132608256")]
    [DisplayName("Charges Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsInf")]
    #endif
    [IsoXmlTag("ChrgsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesInformation1? ChargesInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesInformation1? ChargesInformation { get; init; } 
    #else
    public ChargesInformation1? ChargesInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PshBWNp-Ed-ak6NoX_4Aeg_-710385882")]
    [DisplayName("Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgt")]
    #endif
    [IsoXmlTag("InstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PshBWdp-Ed-ak6NoX_4Aeg_-710387311")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the return reason.
    /// </summary>
    [IsoId("_PsqLQNp-Ed-ak6NoX_4Aeg_-1111192957")]
    [DisplayName("Return Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrRsnInf")]
    #endif
    [IsoXmlTag("RtrRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReturnReasonInformation1? ReturnReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnReasonInformation1? ReturnReasonInformation { get; init; } 
    #else
    public ReturnReasonInformation1? ReturnReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    [IsoId("_PsqLQdp-Ed-ak6NoX_4Aeg_-405283210")]
    [DisplayName("Original Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxRef")]
    #endif
    [IsoXmlTag("OrgnlTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    #else
    public OriginalTransactionReference1? OriginalTransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
