// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_Hvt08XePEfCdoODv2ypKfw")]
public interface ICreditTransferTransaction79 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_H4HjHXePEfCdoODv2ypKfw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification13 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_H4HjH3ePEfCdoODv2ypKfw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_H4HjIXePEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    ActiveCurrencyAndAmount InterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it.
    /// </summary>
    [IsoId("_H4HjI3ePEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance for settlement processing.
    /// </summary>
    [IsoId("_H4HjJXePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_H4HjJ3ePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_H4HjKXePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }

    /// <summary>
    /// Date and time on which the payment should be expired if it has not settled.
    /// </summary>
    [IsoId("_H4HjK3ePEfCdoODv2ypKfw")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    IsoISODateTime? ExpiryDateTime { get; }

    /// <summary>
    /// Cryptographic key identifying terms agreed by agents within the payment chain pre-settlement.
    /// </summary>
    [IsoId("_H4HjLXePEfCdoODv2ypKfw")]
    [DisplayName("Payment Signature")]
    [IsoXmlTag("PmtSgntr")]
    ICryptographicKey1Choice? PaymentSignature { get; }

    /// <summary>
    /// Agent between the debtor's agent and the instructing agent (previous instructing agent 1).
    /// </summary>
    [IsoId("_H4HjL3ePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 1.
    /// </summary>
    [IsoId("_H4HjMXePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount40? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the instructing agent (previous instructing agent 2).
    /// </summary>
    [IsoId("_H4HjM3ePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 2.
    /// </summary>
    [IsoId("_H4HjNXePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount40? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the instructing agent (previous instructing agent 3).
    /// </summary>
    [IsoId("_H4HjN3ePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 3.
    /// </summary>
    [IsoId("_H4HjOXePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount40? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the instruction(s).
    /// </summary>
    [IsoId("_H4HjO3ePEfCdoODv2ypKfw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain.
    /// </summary>
    [IsoId("_H4HjPXePEfCdoODv2ypKfw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedAgent { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 1).
    /// </summary>
    [IsoId("_H4HjP3ePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1.
    /// </summary>
    [IsoId("_H4HjQXePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount40? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 2).
    /// </summary>
    [IsoId("_H4HjQ3ePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2.
    /// </summary>
    [IsoId("_H4HjRXePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount40? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 3).
    /// </summary>
    [IsoId("_H4HjR3ePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3.
    /// </summary>
    [IsoId("_H4HjSXePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount40? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    [IsoId("_H4HjS3ePEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IBranchAndFinancialInstitutionIdentification8? UltimateDebtor { get; }

    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_H4HjTXePEfCdoODv2ypKfw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IBranchAndFinancialInstitutionIdentification8 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor.
    /// </summary>
    [IsoId("_H4HjT3ePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_H4HjUXePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification8? DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent.
    /// </summary>
    [IsoId("_H4HjU3ePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount40? DebtorAgentAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_H4HjVXePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8? CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent.
    /// </summary>
    [IsoId("_H4HjV3ePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_H4HjWXePEfCdoODv2ypKfw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IBranchAndFinancialInstitutionIdentification8 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor.
    /// </summary>
    [IsoId("_H4HjW3ePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Ultimate financial institution to which an amount of money is due.
    /// </summary>
    [IsoId("_H4HjXXePEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IBranchAndFinancialInstitutionIdentification8? UltimateCreditor { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, intended for the creditor agent.
    /// </summary>
    [IsoId("_H4HjX3ePEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent3> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction to the next agent.
    /// </summary>
    [IsoId("_H4HjYXePEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    IEnumerable<IInstructionForNextAgent1> InstructionForNextAgent { get; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_H4HjY3ePEfCdoODv2ypKfw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_SMXaAXePEfCdoODv2ypKfw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting10> RegulatoryReporting { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("_H4HjZXePEfCdoODv2ypKfw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation2? RemittanceInformation { get; }

    /// <summary>
    /// Provides information on the underlying allocations that make up the payment.
    /// </summary>
    [IsoId("_H4HjZ3ePEfCdoODv2ypKfw")]
    [DisplayName("Underlying Allocation")]
    [IsoXmlTag("UndrlygAllcn")]
    IEnumerable<ITransactionAllocation2> UnderlyingAllocation { get; }

    /// <summary>
    /// Provides information on the underlying customer credit transfer for which cover is provided.
    /// </summary>
    [IsoId("_H4HjaXePEfCdoODv2ypKfw")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    ICreditTransferTransaction72? UnderlyingCustomerCreditTransfer { get; }

    /// <summary>
    /// Provides information on the underlying financial institution credit transfer for which cover is provided.
    /// </summary>
    [IsoId("_H4Hja3ePEfCdoODv2ypKfw")]
    [DisplayName("Underlying Financial Institution Credit Transfer")]
    [IsoXmlTag("UndrlygFICdtTrf")]
    ICreditTransferTransaction80? UnderlyingFinancialInstitutionCreditTransfer { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_H4HjbXePEfCdoODv2ypKfw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
