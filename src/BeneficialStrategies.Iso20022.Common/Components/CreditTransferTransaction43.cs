// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_QynVkcQAEemsic1bQcEtLA")]
[DisplayName("Credit Transfer Transaction")]
public record CreditTransferTransaction43
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_Q-f1ncQAEemsic1bQcEtLA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_Q-f1n8QAEemsic1bQcEtLA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_Q-f1ocQAEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_Q-f1o8QAEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_Q-f1pcQAEemsic1bQcEtLA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_Q-f1p8QAEemsic1bQcEtLA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_Q-f1qcQAEemsic1bQcEtLA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_Q-f1q8QAEemsic1bQcEtLA")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [IsoId("_Q-f1rcQAEemsic1bQcEtLA")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_Q-f1r8QAEemsic1bQcEtLA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_Q-f1scQAEemsic1bQcEtLA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_Q-f1s8QAEemsic1bQcEtLA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_Q-f1tcQAEemsic1bQcEtLA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_nnbHEQbQEeqF8ePC1fs2Gg")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_Q-f1t8QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Q-f1ucQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount38? PreviousInstructingAgent1Account { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_Q-f1u8QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Q-f1vcQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount38? PreviousInstructingAgent2Account { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_Q-f1v8QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Q-f1wcQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount38? PreviousInstructingAgent3Account { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Q-f1w8QAEemsic1bQcEtLA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Q-f1xcQAEemsic1bQcEtLA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_Q-f1x8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Q-f1ycQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_Q-f1y8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Q-f1zcQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_Q-f1z8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Q-f10cQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Q-f108QAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_Q-f11cQAEemsic1bQcEtLA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Q-f118QAEemsic1bQcEtLA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_Q-f12cQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Q-f128QAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Q-f13cQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Q-f138QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_Q-f14cQAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_Q-f148QAEemsic1bQcEtLA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_Q-f15cQAEemsic1bQcEtLA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_Q-f158QAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_Q-f16cQAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_Q-f168QAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_Q-f17cQAEemsic1bQcEtLA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_Q-f178QAEemsic1bQcEtLA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_Q-f18cQAEemsic1bQcEtLA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_Q-f188QAEemsic1bQcEtLA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_Q-f19cQAEemsic1bQcEtLA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Q-f198QAEemsic1bQcEtLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
