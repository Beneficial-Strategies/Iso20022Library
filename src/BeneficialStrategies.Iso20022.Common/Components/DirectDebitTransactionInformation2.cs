// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics that apply to the the direct debit transaction(s).
/// </summary>
[IsoId("_PvWS4dp-Ed-ak6NoX_4Aeg_-1849559594")]
[DisplayName("Direct Debit Transaction Information")]
public record DirectDebitTransactionInformation2
{
    /// <summary>
    /// Set of elements to reference a payment instruction.
    /// </summary>
    [IsoId("_PvWS4tp-Ed-ak6NoX_4Aeg_-1847649155")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification2 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_PvWS49p-Ed-ak6NoX_4Aeg_-1846726795")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation4? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_PvWS5Np-Ed-ak6NoX_4Aeg_-1849559007")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_PvWS5dp-Ed-ak6NoX_4Aeg_-1848635881")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PvWS5tp-Ed-ak6NoX_4Aeg_-1849559067")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public CurrencyAndAmount? InstructedAmount { get; init; }

    /// <summary>
    /// The factor used for conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_Pvfc0Np-Ed-ak6NoX_4Aeg_-1848635952")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_Pvfc0dp-Ed-ak6NoX_4Aeg_-1849559327")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <summary>
    /// Provides information on the charges related to the payment transaction.
    /// </summary>
    [IsoId("_Pvfc0tp-Ed-ak6NoX_4Aeg_-1847648800")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation1> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Date at which the creditor requests the amount of money to be collected from the debtor.
    /// </summary>
    [IsoId("_Pvfc09p-Ed-ak6NoX_4Aeg_-1849559439")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <summary>
    /// Set of elements providing information specific to the direct debit mandate.
    /// </summary>
    [IsoId("_Pvfc1Np-Ed-ak6NoX_4Aeg_-1847715279")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction1? DirectDebitTransaction { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_Pvfc1dp-Ed-ak6NoX_4Aeg_-1846727614")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification8 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_Pvfc1tp-Ed-ak6NoX_4Aeg_-1847649730")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Pvfc19p-Ed-ak6NoX_4Aeg_-1846728284")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_Pvfc2Np-Ed-ak6NoX_4Aeg_-1847650669")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_Pvfc2dp-Ed-ak6NoX_4Aeg_-1846727666")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that initiates the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or a party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    [IsoId("_PvpN0Np-Ed-ak6NoX_4Aeg_-1846727319")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PvpN0dp-Ed-ak6NoX_4Aeg_-1846728112")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PvpN0tp-Ed-ak6NoX_4Aeg_-1846728224")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the creditor agent and the intermediary agent 2.
    /// </summary>
    [IsoId("_PvpN09p-Ed-ak6NoX_4Aeg_-1846728621")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PvpN1Np-Ed-ak6NoX_4Aeg_-1847650721")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount7? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_PvpN1dp-Ed-ak6NoX_4Aeg_-1846727751")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PvpN1tp-Ed-ak6NoX_4Aeg_-1847650266")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount7? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the debtor agent.
    /// </summary>
    [IsoId("_PvpN19p-Ed-ak6NoX_4Aeg_-1846727804")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PvpN2Np-Ed-ak6NoX_4Aeg_-1847650318")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount7? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PvpN2dp-Ed-ak6NoX_4Aeg_-1846727258")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification8 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_Pvy-0Np-Ed-ak6NoX_4Aeg_-1846728716")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount7 DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Pvy-0dp-Ed-ak6NoX_4Aeg_-1846728561")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Pvy-0tp-Ed-ak6NoX_4Aeg_-1847650378")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Pvy-09p-Ed-ak6NoX_4Aeg_-1846727181")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.||Usage: Purpose is used by the end-customers, i.e. initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_Pvy-1Np-Ed-ak6NoX_4Aeg_-1846726873")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose1Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_Pvy-1dp-Ed-ak6NoX_4Aeg_-1847649198")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting2> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_Pvy-1tp-Ed-ak6NoX_4Aeg_-1847649387")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_Pvy-19p-Ed-ak6NoX_4Aeg_-1847649430")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation1? RemittanceInformation { get; init; }
}
