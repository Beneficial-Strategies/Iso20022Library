// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_RX0UYcQAEemsic1bQcEtLA")]
public interface ICreditTransferTransaction45 : IIsoComponent
{
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_RksS3cQAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification135? UltimateDebtor { get; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_RksS38QAEemsic1bQcEtLA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification135? InitiatingParty { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_RksS4cQAEemsic1bQcEtLA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification135 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_RksS48QAEemsic1bQcEtLA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount38? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_RksS5cQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification6 DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_RksS58QAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount38? DebtorAgentAccount { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_RksS6cQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_RksS68QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount38? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_RksS7cQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_RksS78QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount38? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_RksS8cQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_RksS88QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount38? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_RksS9cQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_RksS98QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount38? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_RksS-cQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_RksS-8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount38? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_RksS_cQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_RksS_8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount38? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_RksTAcQAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification6 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_RksTA8QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount38? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_RksTBcQAEemsic1bQcEtLA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification135 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_RksTB8QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount38? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_RksTCcQAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification135? UltimateCreditor { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_RksTC8QAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent3> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent.
    /// </summary>
    [IsoId("_RksTDcQAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    IEnumerable<IInstructionForNextAgent1> InstructionForNextAgent { get; }

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_RksTD8QAEemsic1bQcEtLA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    ITaxInformation8? Tax { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_RksTEcQAEemsic1bQcEtLA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation16? RemittanceInformation { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_RksTE8QAEemsic1bQcEtLA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; }
}
