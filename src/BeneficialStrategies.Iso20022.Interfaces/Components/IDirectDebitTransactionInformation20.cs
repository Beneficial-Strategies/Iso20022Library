// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual direct debit transaction(s) included in the message.
/// </summary>
[IsoId("_2m_GYTq4EeWZFYSPlduMhw")]
public interface IDirectDebitTransactionInformation20 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_2utfGzq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification3 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_2utfHTq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation25? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_2utfHzq4EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    ActiveCurrencyAndAmount InterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_2utfITq4EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_2utfIzq4EeWZFYSPlduMhw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_2utfJTq4EeWZFYSPlduMhw")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_2utfJzq4EeWZFYSPlduMhw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_2utfKTq4EeWZFYSPlduMhw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_2utfKzq4EeWZFYSPlduMhw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges2> ChargesInformation { get; }

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("_2utfLTq4EeWZFYSPlduMhw")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    ISODate? RequestedCollectionDate { get; }

    /// <summary>
    /// Provides information specific to the direct debit mandate.
    /// </summary>
    [IsoId("_2utfLzq4EeWZFYSPlduMhw")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    IDirectDebitTransaction8? DirectDebitTransaction { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_2utfMTq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification43 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_2utfMzq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount24? CreditorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_2utfNTq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_2utfNzq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount24? CreditorAgentAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_2utfOTq4EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification43? UltimateCreditor { get; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the creditor or a party that initiates the direct debit on behalf of the creditor.
    /// </summary>
    [IsoId("_2utfOzq4EeWZFYSPlduMhw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification43? InitiatingParty { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_2utfPTq4EeWZFYSPlduMhw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_2utfPzq4EeWZFYSPlduMhw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_2utfQTq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_2utfQzq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount24? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_2utfRTq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_2utfRzq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount24? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the debtor agent.
    /// </summary>
    [IsoId("_2utfSTq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_2utfSzq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount24? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2utfTTq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification43 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_2utfTzq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount24 DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_2utfUTq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5 DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_2utfUzq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount24? DebtorAgentAccount { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2utfVTq4EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification43? UltimateDebtor { get; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_2utfVzq4EeWZFYSPlduMhw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_2utfWTq4EeWZFYSPlduMhw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting3> RegulatoryReporting { get; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_2utfWzq4EeWZFYSPlduMhw")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation4> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_2utfXTq4EeWZFYSPlduMhw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation11? RemittanceInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2utfXzq4EeWZFYSPlduMhw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
