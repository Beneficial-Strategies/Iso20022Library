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
/// Contains the requested modifications.
/// </summary>
[IsoId("_PgTKQdp-Ed-ak6NoX_4Aeg_-1564522942")]
[DisplayName("Requested Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestedModification
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference relating to a linked payment instruction or agreement which is meaningful to both parties (eg, the content of field 21 in a cover instruction).
    /// </summary>
    [IsoId("_PgTKQtp-Ed-ak6NoX_4Aeg_242959100")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedReference { get; init; } 
    #else
    public System.String? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// SWIFT defined service level applies to the payment instruction.
    /// </summary>
    [IsoId("_PgTKQ9p-Ed-ak6NoX_4Aeg_243879184")]
    [DisplayName("Bank Operation Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkOprCd")]
    #endif
    [IsoXmlTag("BkOprCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SWIFTServiceLevel2Code? BankOperationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SWIFTServiceLevel2Code? BankOperationCode { get; init; } 
    #else
    public SWIFTServiceLevel2Code? BankOperationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.
    /// </summary>
    [IsoId("_PgTKRNp-Ed-ak6NoX_4Aeg_243879226")]
    [DisplayName("Instruction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrCd")]
    #endif
    [IsoXmlTag("InstrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instruction1Code? InstructionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instruction1Code? InstructionCode { get; init; } 
    #else
    public Instruction1Code? InstructionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the debtor requests the clearing agent to process the payment instruction.
    /// </summary>
    [IsoId("_PgTKRdp-Ed-ak6NoX_4Aeg_243879322")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedExecutionDate { get; init; } 
    #else
    public System.DateOnly? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_PgTKRtp-Ed-ak6NoX_4Aeg_243879382")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_PgTKR9p-Ed-ak6NoX_4Aeg_243879442")]
    [DisplayName("Interbank Settled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttldAmt")]
    #endif
    [IsoXmlTag("IntrBkSttldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? InterbankSettledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? InterbankSettledAmount { get; init; } 
    #else
    public CurrencyAndAmount? InterbankSettledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Debtor or Ordering customer of the payment instruction.
    /// </summary>
    [IsoId("_PgTKSNp-Ed-ak6NoX_4Aeg_-916615444")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1? Debtor { get; init; } 
    #else
    public PartyIdentification1? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PgTKSdp-Ed-ak6NoX_4Aeg_-806718631")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount3? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount3? DebtorAccount { get; init; } 
    #else
    public CashAccount3? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that executes a cash transfer received via a clearing agent or on request of an agreement party.
    /// </summary>
    [IsoId("_PgcUMNp-Ed-ak6NoX_4Aeg_-63282862")]
    [DisplayName("Intermediary Settlement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmySttlmAgt")]
    #endif
    [IsoXmlTag("IntrmySttlmAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party that executes a cash transfer received via a clearing agent or on request of an agreement party.
    /// </summary>
    [IsoId("_PgcUMdp-Ed-ak6NoX_4Aeg_-50353165")]
    [DisplayName("Last Settlement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastSttlmAgt")]
    #endif
    [IsoXmlTag("LastSttlmAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents, or the channel through which the payment instruction is to be processed. This payment scheme can point to a specific rulebook governing the rules of clearing and settlement between two parties.
    /// </summary>
    [IsoId("_PgcUMtp-Ed-ak6NoX_4Aeg_1325691224")]
    [DisplayName("Payment Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchme")]
    #endif
    [IsoXmlTag("PmtSchme")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentSchemeChoice_? PaymentScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentSchemeChoice_? PaymentScheme { get; init; } 
    #else
    public PaymentSchemeChoice_? PaymentScheme { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PgcUM9p-Ed-ak6NoX_4Aeg_1857642649")]
    [DisplayName("Beneficiary Institution Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryInstnAcct")]
    #endif
    [IsoXmlTag("BnfcryInstnAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount3? BeneficiaryInstitutionAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount3? BeneficiaryInstitutionAccount { get; init; } 
    #else
    public CashAccount3? BeneficiaryInstitutionAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_PgcUNNp-Ed-ak6NoX_4Aeg_-1478712318")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1? Creditor { get; init; } 
    #else
    public PartyIdentification1? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PgcUNdp-Ed-ak6NoX_4Aeg_-782375854")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount3? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount3? CreditorAccount { get; init; } 
    #else
    public CashAccount3? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Structured information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_PgcUNtp-Ed-ak6NoX_4Aeg_1343304553")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation3Choice_? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation3Choice_? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation3Choice_? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_PgcUN9p-Ed-ak6NoX_4Aeg_2142146768")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PurposeChoice_? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PurposeChoice_? Purpose { get; init; } 
    #else
    public PurposeChoice_? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.
    /// </summary>
    [IsoId("_PgcUONp-Ed-ak6NoX_4Aeg_-1671665889")]
    [DisplayName("Instruction For Final Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForFnlAgt")]
    #endif
    [IsoXmlTag("InstrForFnlAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForFinalAgent? InstructionForFinalAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForFinalAgent? InstructionForFinalAgent { get; init; } 
    #else
    public InstructionForFinalAgent? InstructionForFinalAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party(ies) liable for a charge associated with the transfer of cash.
    /// </summary>
    [IsoId("_PgcUOdp-Ed-ak6NoX_4Aeg_1533975968")]
    [DisplayName("Details Of Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtlsOfChrgs")]
    #endif
    [IsoXmlTag("DtlsOfChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearer1Code? DetailsOfCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearer1Code? DetailsOfCharges { get; init; } 
    #else
    public ChargeBearer1Code? DetailsOfCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Unformatted information from the sender to the receiver.
    /// </summary>
    [IsoId("_PgmFMNp-Ed-ak6NoX_4Aeg_1533975985")]
    [DisplayName("Sender To Receiver Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrToRcvrInf")]
    #endif
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<System.String> SenderToReceiverInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
