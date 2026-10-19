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
[IsoId("c1b2745a-8979-4069-a0c7-2a93a3ff6de8")]
[DisplayName("Credit Transfer Transaction76")]
public partial record CreditTransferTransaction76
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("92465cdb-cd16-458f-9d50-953ca23dfdb2")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("d5aace43-7038-44fe-b777-f4bec11be962")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("8a16abe3-50a6-432d-9dc4-5b3ac91914ce")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("2560feb3-98eb-4333-93f1-cca643d13591")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("7d7b0c0e-884f-4f8b-b53c-f94e4062bd7a")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("d6454bb6-3005-4781-8dae-02f0855baa56")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Set of elements needed to issue a cheque.
    /// </summary>
    [IsoId("fd4d4076-30bc-4c77-987d-9421d542bce1")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque19? ChequeInstruction { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("ff55435e-db04-48f1-8eca-b78492eccd69")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.|Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("a4eb321c-5f60-4dde-8bce-4d90cc67c8d8")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("ed7ea073-aa67-4ce4-b27d-9e432a966345")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.|Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("29f18707-cfc7-4b14-8d3d-6d1811b8e547")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("b38b6b58-3292-4db1-8d5d-87c913add402")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.|Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("4fc8d3ae-497b-4fa2-9da1-8b8cea4f5363")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("c16f42a1-96fa-4e15-96b0-fce3d235c817")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("3a6e698c-3e07-4d61-90e6-c4a83376946c")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("95390afe-93bc-4f46-a6d8-3cadbeef6e97")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("3ef4aeae-6e4f-4b08-b62f-f8c5ac1218c1")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification272? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("1bb9f7fd-a7bd-4cfd-bb7d-487e03a8b141")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("aa7124b6-2225-4553-90d5-41188066e954")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("bc60b0fd-91b0-48fa-b2da-1c0479a84937")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// </summary>
    [IsoId("ac0066e9-3069-4b56-bc27-0e5d70338156")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("0c1a6500-067b-43a2-af2f-b4c0c27e742e")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("09380866-7741-4b24-9c69-b7d72c30a4b8")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("fdb85b7a-6253-416a-a6d8-ad45e7aeb5cf")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxData1? Tax { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("19b65d0b-ae00-448e-8634-7312c00a25dd")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation8> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    [IsoId("d1bb375e-efe5-432c-b1ab-d4665a734a8c")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("2d676c9f-81d5-4a9f-a206-9665e3bbb0df")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
