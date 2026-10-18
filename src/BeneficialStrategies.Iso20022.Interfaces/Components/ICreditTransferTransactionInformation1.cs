// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_PxIbqtp-Ed-ak6NoX_4Aeg_565576791")]
public interface ICreditTransferTransactionInformation1 : IIsoComponent
{
    /// <summary>
    /// Set of elements to reference a payment instruction.
    /// </summary>
    [IsoId("_PxIbq9p-Ed-ak6NoX_4Aeg_566501928")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification1 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_PxSMkNp-Ed-ak6NoX_4Aeg_-191624599")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation1? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PxSMkdp-Ed-ak6NoX_4Aeg_566501270")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    IAmountType2Choice Amount { get; }

    /// <summary>
    /// Further detailed information on the exchange rate specified in the payment transaction.
    /// </summary>
    [IsoId("_PxSMktp-Ed-ak6NoX_4Aeg_1916719833")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    IExchangeRateInformation1? ExchangeRateInformation { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_PxSMk9p-Ed-ak6NoX_4Aeg_565576809")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Information related to the issuance of a cheque.
    /// </summary>
    [IsoId("_PxSMlNp-Ed-ak6NoX_4Aeg_566501400")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    ICheque5? ChequeInstruction { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PxSMldp-Ed-ak6NoX_4Aeg_-2045887143")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification8? UltimateDebtor { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the debtor agent and the intermediary agent 2.
    /// </summary>
    [IsoId("_PxSMltp-Ed-ak6NoX_4Aeg_-2048656805")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PxSMl9p-Ed-ak6NoX_4Aeg_-2061587448")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount7? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_PxSMmNp-Ed-ak6NoX_4Aeg_-2046810648")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PxSMmdp-Ed-ak6NoX_4Aeg_-2059740000")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount7? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    [IsoId("_PxbWgNp-Ed-ak6NoX_4Aeg_-2046812015")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PxbWgdp-Ed-ak6NoX_4Aeg_-2059741896")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount7? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PxbWgtp-Ed-ak6NoX_4Aeg_-2047735100")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification3? CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_PxbWg9p-Ed-ak6NoX_4Aeg_-2060665461")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount7? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_PxbWhNp-Ed-ak6NoX_4Aeg_-2045889081")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification8? Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_PxbWhdp-Ed-ak6NoX_4Aeg_-2058816435")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount7? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_PxbWhtp-Ed-ak6NoX_4Aeg_-2046810042")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification8? UltimateCreditor { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_PxbWh9p-Ed-ak6NoX_4Aeg_566500867")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent1> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent. ||Usage: The instruction can relate to a level of service, can be an instruction to be executed by the debtor&apos;s agent, or can be information required by the debtor&apos;s agent to process the instruction.
    /// </summary>
    [IsoId("_PxbWiNp-Ed-ak6NoX_4Aeg_233236695")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    IsoMax140Text? InstructionForDebtorAgent { get; }

    /// <summary>
    /// Underlying reason for the payment transaction, eg, a charity payment, or a commercial agreement between the creditor and the debtor. ||Usage: purpose is used by the end-customers, ie originating party, initiating party, debtor, creditor, final party, to provide information concerning the nature of the payment transaction. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_PxlHgNp-Ed-ak6NoX_4Aeg_565577025")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose1Choice? Purpose { get; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_PxlHgdp-Ed-ak6NoX_4Aeg_566502408")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting2> RegulatoryReporting { get; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_PxlHgtp-Ed-ak6NoX_4Aeg_-138019399")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    ITaxInformation2? Tax { get; }

    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_PxlHg9p-Ed-ak6NoX_4Aeg_-2057894791")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation1> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_PxlHhNp-Ed-ak6NoX_4Aeg_566502331")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation1? RemittanceInformation { get; }
}
