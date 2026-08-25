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
[IsoId("d64d5a68-1284-4122-abcc-66b60f276023")]
[DisplayName("Credit Transfer Transaction73")]
public record CreditTransferTransaction73
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("d64d5a68-0001-0001-0001-12844122abcc")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("d64d5a68-0002-0002-0002-12844122abcc")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("d64d5a68-0003-0003-0003-12844122abcc")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("d64d5a68-0004-0004-0004-12844122abcc")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("d64d5a68-0005-0005-0005-12844122abcc")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Information concerning the settlement of the instruction.
    /// </summary>
    [IsoId("d64d5a68-0006-0006-0006-12844122abcc")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <summary>
    /// Point in time at which the payment order from the instructing agent must be complied with by the instructed agent.
    /// </summary>
    [IsoId("d64d5a68-0007-0007-0007-12844122abcc")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <summary>
    /// Series of additional date and time data that can be applied to the payment.
    /// </summary>
    [DisplayName("Additional Date Time")]
    [IsoXmlTag("AddtlDtTm")]
    public AdditionalDateTime1? AdditionalDateTime { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    /// <remarks>
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </remarks>
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("d64d5a68-0008-0008-0008-12844122abcc")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("d64d5a68-0009-0009-0009-12844122abcc")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Exchange rate as agreed between the two parties.
    /// </summary>
    [IsoId("d64d5a68-0010-0010-0010-12844122abcc")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Agreed exchange rate between two currencies.
    /// </summary>
    [IsoId("d64d5a68-0011-0011-0011-12844122abcc")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public CurrencyExchange26? AgreedRate { get; init; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Cryptographic key identifying terms agreed by agents within the payment chain pre-settlement. This key can also be used post-settlement to confirm the payment has been credited as intended.
    /// </summary>
    [DisplayName("Payment Signature")]
    [IsoXmlTag("PmtSgntr")]
    public CryptographicKey1Choice_? PaymentSignature { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 1).
    /// </summary>
    [IsoId("d64d5a68-0012-0012-0012-12844122abcc")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 1.
    /// </summary>
    [IsoId("d64d5a68-0013-0013-0013-12844122abcc")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 2).
    /// </summary>
    [IsoId("d64d5a68-0014-0014-0014-12844122abcc")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 2.
    /// </summary>
    [IsoId("d64d5a68-0015-0015-0015-12844122abcc")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 3).
    /// </summary>
    [IsoId("d64d5a68-0016-0016-0016-12844122abcc")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 3.
    /// </summary>
    [IsoId("d64d5a68-0017-0017-0017-12844122abcc")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 1).
    /// </summary>
    [IsoId("d64d5a68-0018-0018-0018-12844122abcc")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1.
    /// </summary>
    [IsoId("d64d5a68-0019-0019-0019-12844122abcc")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 2).
    /// </summary>
    [IsoId("d64d5a68-0020-0020-0020-12844122abcc")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2.
    /// </summary>
    [IsoId("d64d5a68-0021-0021-0021-12844122abcc")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 3).
    /// </summary>
    [IsoId("d64d5a68-0022-0022-0022-12844122abcc")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3.
    /// </summary>
    [IsoId("d64d5a68-0023-0023-0023-12844122abcc")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("d64d5a68-0024-0024-0024-12844122abcc")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made.
    /// </summary>
    [IsoId("d64d5a68-0025-0025-0025-12844122abcc")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("d64d5a68-0026-0026-0026-12844122abcc")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent.
    /// </summary>
    [IsoId("d64d5a68-0027-0027-0027-12844122abcc")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("d64d5a68-0028-0028-0028-12844122abcc")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that initiates the payment.
    /// </summary>
    /// <remarks>
    /// Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </remarks>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification272? InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("d64d5a68-0029-0029-0029-12844122abcc")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent.
    /// </summary>
    [IsoId("d64d5a68-0030-0030-0030-12844122abcc")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("d64d5a68-0031-0031-0031-12844122abcc")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted.
    /// </summary>
    [IsoId("d64d5a68-0032-0032-0032-12844122abcc")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("d64d5a68-0033-0033-0033-12844122abcc")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction.
    /// </summary>
    [IsoId("d64d5a68-0034-0034-0034-12844122abcc")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction to the next agent.
    /// </summary>
    [IsoId("d64d5a68-0035-0035-0035-12844122abcc")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("d64d5a68-0036-0036-0036-12844122abcc")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information provided for regulatory and statutory requirements.
    /// </summary>
    [IsoId("d64d5a68-0037-0037-0037-12844122abcc")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Tax information.
    /// </summary>
    [IsoId("d64d5a68-0038-0038-0038-12844122abcc")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxData1? Tax { get; init; }

    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("d64d5a68-0039-0039-0039-12844122abcc")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation8> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("d64d5a68-0040-0040-0040-12844122abcc")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation22? RemittanceInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("d64d5a68-0041-0041-0041-12844122abcc")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
