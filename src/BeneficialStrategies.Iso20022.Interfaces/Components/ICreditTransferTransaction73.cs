// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("d64d5a68-1284-4122-abcc-66b60f276023")]
public interface ICreditTransferTransaction73 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("d64d5a68-0001-0001-0001-12844122abcc")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification13 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("d64d5a68-0002-0002-0002-12844122abcc")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("d64d5a68-0003-0003-0003-12844122abcc")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    ActiveCurrencyAndAmount InterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("d64d5a68-0004-0004-0004-12844122abcc")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("d64d5a68-0005-0005-0005-12844122abcc")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Information concerning the settlement of the instruction.
    /// </summary>
    [IsoId("d64d5a68-0006-0006-0006-12844122abcc")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Point in time at which the payment order from the instructing agent must be complied with by the instructed agent.
    /// </summary>
    [IsoId("d64d5a68-0007-0007-0007-12844122abcc")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }

    /// <summary>
    /// Series of additional date and time data that can be applied to the payment.
    /// </summary>
    [DisplayName("Additional Date Time")]
    [IsoXmlTag("AddtlDtTm")]
    IAdditionalDateTime1? AdditionalDateTime { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    /// <remarks>
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </remarks>
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; }

    /// <summary>
    /// Exchange rate as agreed between the two parties.
    /// </summary>
    [IsoId("d64d5a68-0010-0010-0010-12844122abcc")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Agreed exchange rate between two currencies.
    /// </summary>
    [IsoId("d64d5a68-0011-0011-0011-12844122abcc")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    ICurrencyExchange26? AgreedRate { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("d64d5a68-0008-0008-0008-12844122abcc")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("d64d5a68-0009-0009-0009-12844122abcc")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges16> ChargesInformation { get; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    ICreditTransferMandateData1? MandateRelatedInformation { get; }

    /// <summary>
    /// Cryptographic key identifying terms agreed by agents within the payment chain pre-settlement. This key can also be used post-settlement to confirm the payment has been credited as intended.
    /// </summary>
    [DisplayName("Payment Signature")]
    [IsoXmlTag("PmtSgntr")]
    ICryptographicKey1Choice? PaymentSignature { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 1).
    /// </summary>
    [IsoId("d64d5a68-0012-0012-0012-12844122abcc")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 1.
    /// </summary>
    [IsoId("d64d5a68-0013-0013-0013-12844122abcc")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount40? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 2).
    /// </summary>
    [IsoId("d64d5a68-0014-0014-0014-12844122abcc")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 2.
    /// </summary>
    [IsoId("d64d5a68-0015-0015-0015-12844122abcc")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount40? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 3).
    /// </summary>
    [IsoId("d64d5a68-0016-0016-0016-12844122abcc")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 3.
    /// </summary>
    [IsoId("d64d5a68-0017-0017-0017-12844122abcc")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount40? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedAgent { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 1).
    /// </summary>
    [IsoId("d64d5a68-0018-0018-0018-12844122abcc")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1.
    /// </summary>
    [IsoId("d64d5a68-0019-0019-0019-12844122abcc")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount40? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 2).
    /// </summary>
    [IsoId("d64d5a68-0020-0020-0020-12844122abcc")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2.
    /// </summary>
    [IsoId("d64d5a68-0021-0021-0021-12844122abcc")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount40? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 3).
    /// </summary>
    [IsoId("d64d5a68-0022-0022-0022-12844122abcc")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3.
    /// </summary>
    [IsoId("d64d5a68-0023-0023-0023-12844122abcc")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount40? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("d64d5a68-0028-0028-0028-12844122abcc")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification272? UltimateDebtor { get; }

    /// <summary>
    /// Party that initiates the payment.
    /// </summary>
    /// <remarks>
    /// Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </remarks>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification272? InitiatingParty { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("d64d5a68-0024-0024-0024-12844122abcc")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification272 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made.
    /// </summary>
    [IsoId("d64d5a68-0025-0025-0025-12844122abcc")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("d64d5a68-0026-0026-0026-12844122abcc")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent.
    /// </summary>
    [IsoId("d64d5a68-0027-0027-0027-12844122abcc")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount40? DebtorAgentAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("d64d5a68-0029-0029-0029-12844122abcc")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent.
    /// </summary>
    [IsoId("d64d5a68-0030-0030-0030-12844122abcc")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("d64d5a68-0031-0031-0031-12844122abcc")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification272 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted.
    /// </summary>
    [IsoId("d64d5a68-0032-0032-0032-12844122abcc")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("d64d5a68-0033-0033-0033-12844122abcc")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification272? UltimateCreditor { get; }

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction.
    /// </summary>
    [IsoId("d64d5a68-0034-0034-0034-12844122abcc")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent3> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction to the next agent.
    /// </summary>
    [IsoId("d64d5a68-0035-0035-0035-12844122abcc")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    IEnumerable<IInstructionForNextAgent1> InstructionForNextAgent { get; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("d64d5a68-0036-0036-0036-12844122abcc")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Information provided for regulatory and statutory requirements.
    /// </summary>
    [IsoId("d64d5a68-0037-0037-0037-12844122abcc")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting10> RegulatoryReporting { get; }

    /// <summary>
    /// Tax information.
    /// </summary>
    [IsoId("d64d5a68-0038-0038-0038-12844122abcc")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    ITaxData1? Tax { get; }

    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("d64d5a68-0039-0039-0039-12844122abcc")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation8> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("d64d5a68-0040-0040-0040-12844122abcc")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation26? RemittanceInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("d64d5a68-0041-0041-0041-12844122abcc")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
