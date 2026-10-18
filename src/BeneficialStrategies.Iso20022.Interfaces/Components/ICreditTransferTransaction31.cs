// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_AgPKEYtlEee-OJ-wXSj3YQ")]
public interface ICreditTransferTransaction31 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_ApArqYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification3 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_ApArq4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation21? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_ApArrYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    ActiveCurrencyAndAmount InterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_ApArr4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_ApArsYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_ApArs4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_ApArtYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_9rLohotkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_9rLoh4tkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount24? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_9rLoiItkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_9rLoiYtkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount24? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_9rLoiotkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_9rLoi4tkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount24? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_ApAru4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_ApArvYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_ApArv4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ApArwYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount24? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_ApArw4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ApArxYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount24? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_ApArx4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ApAryYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount24? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    [IsoId("_ApAry4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IBranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; }

    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_ApArzYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IBranchAndFinancialInstitutionIdentification5 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_ApArz4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount24? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_ApAr0YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ApAr04tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount24? DebtorAgentAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_ApAr1YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_ApAr14tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount24? CreditorAgentAccount { get; }

    /// <summary>
    /// Financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_ApAr2YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IBranchAndFinancialInstitutionIdentification5 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_ApAr24tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount24? CreditorAccount { get; }

    /// <summary>
    /// Ultimate financial institution to which an amount of money is due.
    /// </summary>
    [IsoId("_ApAr3YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IBranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_ApAr34tlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent2> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_ApAr4YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    IEnumerable<IInstructionForNextAgent1> InstructionForNextAgent { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_ApAr44tlEee-OJ-wXSj3YQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation2? RemittanceInformation { get; }

    /// <summary>
    /// Provides information on the underlying customer credit transfer for which cover is provided.
    /// </summary>
    [IsoId("_ApAr5YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    ICreditTransferTransaction32? UnderlyingCustomerCreditTransfer { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ApAr54tlEee-OJ-wXSj3YQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
