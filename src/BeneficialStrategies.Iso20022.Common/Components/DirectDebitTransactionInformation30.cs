// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual direct debit transaction(s) included in the message.
/// </summary>
[IsoId("_OdEZHxlWEe2Do_UtrNmb2g")]
[DisplayName("Direct Debit Transaction Information")]
public record DirectDebitTransactionInformation30
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_OmlheRlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_OmlhexlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_OmlhfRlWEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_OmlhfxlWEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_OmlhgRlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Provides information on the occurred settlement time of the payment transaction.
    /// </summary>
    [IsoId("_OmlhgxlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_OmlhhRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_OmlhhxlWEe2Do_UtrNmb2g")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_OmlhiRlWEe2Do_UtrNmb2g")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_OmlhixlWEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges12> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("_OmlhjRlWEe2Do_UtrNmb2g")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <summary>
    /// Provides information specific to the direct debit mandate.
    /// </summary>
    [IsoId("_OmlhjxlWEe2Do_UtrNmb2g")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction11? DirectDebitTransaction { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_OmlhkRlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_OmlhkxlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_OmlhlRlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_OmlhlxlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_OmlhmRlWEe2Do_UtrNmb2g")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the creditor or a party that initiates the direct debit on behalf of the creditor.
    /// </summary>
    [IsoId("_OmlhmxlWEe2Do_UtrNmb2g")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_OmlhnRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_OmlhnxlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_OmlhoRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_OmlhoxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_OmlhpRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_OmlhpxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the debtor agent.
    /// </summary>
    [IsoId("_OmlhqRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_OmlhqxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_OmlhrRlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_OmlhrxlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount40 DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_OmlhsRlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_OmlhsxlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_OmlhtRlWEe2Do_UtrNmb2g")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_OmlhtxlWEe2Do_UtrNmb2g")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_OmlhuRlWEe2Do_UtrNmb2g")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_OmlhuxlWEe2Do_UtrNmb2g")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_OmlhvRlWEe2Do_UtrNmb2g")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_OmlhvxlWEe2Do_UtrNmb2g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
