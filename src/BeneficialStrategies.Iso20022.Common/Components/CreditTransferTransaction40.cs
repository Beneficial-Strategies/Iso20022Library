// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_PEiqV8QAEemsic1bQcEtLA")]
[DisplayName("Credit Transfer Transaction")]
public record CreditTransferTransaction40
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_PRQQk8QAEemsic1bQcEtLA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_PRQQlcQAEemsic1bQcEtLA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PRQQl8QAEemsic1bQcEtLA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_PRQQmcQAEemsic1bQcEtLA")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_PRQQm8QAEemsic1bQcEtLA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_aQpB4cl0Eem0vqvvoqYsqQ")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Set of elements needed to issue a cheque.
    /// </summary>
    [IsoId("_PRQQncQAEemsic1bQcEtLA")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque11? ChequeInstruction { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PRQQn8QAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_PRQQocQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PRQQo8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_PRQQpcQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PRQQp8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_PRQQqcQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PRQQq8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PRQQrcQAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_PRQQr8QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_PRQQscQAEemsic1bQcEtLA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification135? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_PRQQs8QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_PRQQtcQAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_PRQQt8QAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// </summary>
    [IsoId("_PRQQucQAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_PRQQu8QAEemsic1bQcEtLA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_PRQQvcQAEemsic1bQcEtLA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_PRQQv8QAEemsic1bQcEtLA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_PRQQwcQAEemsic1bQcEtLA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_PRQQw8QAEemsic1bQcEtLA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_PRQQxcQAEemsic1bQcEtLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
