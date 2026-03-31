// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_P2y-uNp-Ed-ak6NoX_4Aeg_167029543")]
[DisplayName("Credit Transfer Transaction Information")]
public record CreditTransferTransactionInformation11
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_P2y-udp-Ed-ak6NoX_4Aeg_167031446")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_P2y-utp-Ed-ak6NoX_4Aeg_167952095")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_P2y-u9p-Ed-ak6NoX_4Aeg_167029574")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_P2y-vNp-Ed-ak6NoX_4Aeg_167029604")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_P2y-vdp-Ed-ak6NoX_4Aeg_-1033995353")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_P2y-vtp-Ed-ak6NoX_4Aeg_167951602")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_P28vsNp-Ed-ak6NoX_4Aeg_167031385")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_P28vsdp-Ed-ak6NoX_4Aeg_167030036")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [IsoId("_P28vstp-Ed-ak6NoX_4Aeg_167030067")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_P28vs9p-Ed-ak6NoX_4Aeg_167029914")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_P28vtNp-Ed-ak6NoX_4Aeg_167029944")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_P28vtdp-Ed-ak6NoX_4Aeg_167030006")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_P28vttp-Ed-ak6NoX_4Aeg_167951724")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation5> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_P28vt9p-Ed-ak6NoX_4Aeg_167952457")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? PreviousInstructingAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_P28vuNp-Ed-ak6NoX_4Aeg_167030530")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount16? PreviousInstructingAgentAccount { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_P28vudp-Ed-ak6NoX_4Aeg_167951479")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_P3F5oNp-Ed-ak6NoX_4Aeg_167952518")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_P3F5odp-Ed-ak6NoX_4Aeg_167951571")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_P3F5otp-Ed-ak6NoX_4Aeg_167030839")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount16? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_P3F5o9p-Ed-ak6NoX_4Aeg_167952610")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_P3F5pNp-Ed-ak6NoX_4Aeg_167030469")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount16? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_P3F5pdp-Ed-ak6NoX_4Aeg_167952579")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_P3F5ptp-Ed-ak6NoX_4Aeg_167030900")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount16? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P3F5p9p-Ed-ak6NoX_4Aeg_167030992")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_P3PqoNp-Ed-ak6NoX_4Aeg_167030963")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P3Pqodp-Ed-ak6NoX_4Aeg_167031053")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_P3Pqotp-Ed-ak6NoX_4Aeg_167030560")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_P3Pqo9p-Ed-ak6NoX_4Aeg_167952671")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_P3PqpNp-Ed-ak6NoX_4Aeg_167030407")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_P3Y0kNp-Ed-ak6NoX_4Aeg_167951510")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_P3Y0kdp-Ed-ak6NoX_4Aeg_167030438")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_P3Y0ktp-Ed-ak6NoX_4Aeg_167031137")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification32 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_P3Y0k9p-Ed-ak6NoX_4Aeg_167952733")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_P3Y0lNp-Ed-ak6NoX_4Aeg_167031084")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_P3Y0ldp-Ed-ak6NoX_4Aeg_167952064")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_P3Y0ltp-Ed-ak6NoX_4Aeg_167952156")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_P3Y0l9p-Ed-ak6NoX_4Aeg_167030129")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_P3Y0mNp-Ed-ak6NoX_4Aeg_167030098")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Set of elements used to provide information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_P3ilkNp-Ed-ak6NoX_4Aeg_167952003")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_P3ilkdp-Ed-ak6NoX_4Aeg_167951663")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }
}
