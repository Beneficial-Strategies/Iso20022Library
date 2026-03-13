// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the requested modifications.
/// </summary>
[IsoId("_PgTKQdp-Ed-ak6NoX_4Aeg_-1564522942")]
[DisplayName("Requested Modification")]
public partial record RequestedModification
{
    #nullable enable
    
    /// <summary>
    /// Reference relating to a linked payment instruction or agreement which is meaningful to both parties (eg, the content of field 21 in a cover instruction).
    /// </summary>
    [IsoId("_PgTKQtp-Ed-ak6NoX_4Aeg_242959100")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; } 
    
    /// <summary>
    /// SWIFT defined service level applies to the payment instruction.
    /// </summary>
    [IsoId("_PgTKQ9p-Ed-ak6NoX_4Aeg_243879184")]
    [DisplayName("Bank Operation Code")]
    [IsoXmlTag("BkOprCd")]
    public SWIFTServiceLevel2Code? BankOperationCode { get; init; } 
    
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.
    /// </summary>
    [IsoId("_PgTKRNp-Ed-ak6NoX_4Aeg_243879226")]
    [DisplayName("Instruction Code")]
    [IsoXmlTag("InstrCd")]
    public Instruction1Code? InstructionCode { get; init; } 
    
    /// <summary>
    /// Date and time the debtor requests the clearing agent to process the payment instruction.
    /// </summary>
    [IsoId("_PgTKRdp-Ed-ak6NoX_4Aeg_243879322")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; } 
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_PgTKRtp-Ed-ak6NoX_4Aeg_243879382")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_PgTKR9p-Ed-ak6NoX_4Aeg_243879442")]
    [DisplayName("Interbank Settled Amount")]
    [IsoXmlTag("IntrBkSttldAmt")]
    public CurrencyAndAmount? InterbankSettledAmount { get; init; } 
    
    /// <summary>
    /// Debtor or Ordering customer of the payment instruction.
    /// </summary>
    [IsoId("_PgTKSNp-Ed-ak6NoX_4Aeg_-916615444")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification1? Debtor { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PgTKSdp-Ed-ak6NoX_4Aeg_-806718631")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount3? DebtorAccount { get; init; } 
    
    /// <summary>
    /// Party that executes a cash transfer received via a clearing agent or on request of an agreement party.
    /// </summary>
    [IsoId("_PgcUMNp-Ed-ak6NoX_4Aeg_-63282862")]
    [DisplayName("Intermediary Settlement Agent")]
    [IsoXmlTag("IntrmySttlmAgt")]
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    
    /// <summary>
    /// Party that executes a cash transfer received via a clearing agent or on request of an agreement party.
    /// </summary>
    [IsoId("_PgcUMdp-Ed-ak6NoX_4Aeg_-50353165")]
    [DisplayName("Last Settlement Agent")]
    [IsoXmlTag("LastSttlmAgt")]
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents, or the channel through which the payment instruction is to be processed. This payment scheme can point to a specific rulebook governing the rules of clearing and settlement between two parties.
    /// </summary>
    [IsoId("_PgcUMtp-Ed-ak6NoX_4Aeg_1325691224")]
    [DisplayName("Payment Scheme")]
    [IsoXmlTag("PmtSchme")]
    public PaymentSchemeChoice_? PaymentScheme { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PgcUM9p-Ed-ak6NoX_4Aeg_1857642649")]
    [DisplayName("Beneficiary Institution Account")]
    [IsoXmlTag("BnfcryInstnAcct")]
    public CashAccount3? BeneficiaryInstitutionAccount { get; init; } 
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_PgcUNNp-Ed-ak6NoX_4Aeg_-1478712318")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification1? Creditor { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PgcUNdp-Ed-ak6NoX_4Aeg_-782375854")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount3? CreditorAccount { get; init; } 
    
    /// <summary>
    /// Structured information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_PgcUNtp-Ed-ak6NoX_4Aeg_1343304553")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation3Choice_? RemittanceInformation { get; init; } 
    
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_PgcUN9p-Ed-ak6NoX_4Aeg_2142146768")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public PurposeChoice_? Purpose { get; init; } 
    
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.
    /// </summary>
    [IsoId("_PgcUONp-Ed-ak6NoX_4Aeg_-1671665889")]
    [DisplayName("Instruction For Final Agent")]
    [IsoXmlTag("InstrForFnlAgt")]
    public InstructionForFinalAgent? InstructionForFinalAgent { get; init; } 
    
    /// <summary>
    /// Party(ies) liable for a charge associated with the transfer of cash.
    /// </summary>
    [IsoId("_PgcUOdp-Ed-ak6NoX_4Aeg_1533975968")]
    [DisplayName("Details Of Charges")]
    [IsoXmlTag("DtlsOfChrgs")]
    public ChargeBearer1Code? DetailsOfCharges { get; init; } 
    
    /// <summary>
    /// Unformatted information from the sender to the receiver.
    /// </summary>
    [IsoId("_PgmFMNp-Ed-ak6NoX_4Aeg_1533975985")]
    [DisplayName("Sender To Receiver Information")]
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<System.String> SenderToReceiverInformation { get; init; } = [];
    
    
    #nullable disable
    
}
