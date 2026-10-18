// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation35"/>
[IsoId("a6fc8316-6307-4582-89c4-560440222204")]
[DisplayName("Direct Debit Transaction Information35")]
public partial record DirectDebitTransactionInformation35
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation35.PaymentIdentification"/>
    [IsoId("c41569b1-068f-4a2c-baad-8ece9c0df925")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.PaymentTypeInformation"/>
    [IsoId("81b68ed2-620e-46e6-bd06-391f9dedbbd3")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.InterbankSettlementAmount"/>
    [IsoId("35b1fa23-6b75-4bfd-95e4-de9d63efa919")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.InterbankSettlementDate"/>
    [IsoId("d20bfd82-b557-4a7c-8b8a-20b59acabd7d")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.SettlementPriority"/>
    [IsoId("786ffec6-c553-40b3-9074-3fb775a21333")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.SettlementTimeIndication"/>
    [IsoId("3c4ac84d-43b7-4630-b047-ea6ea1897285")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.InstructedAmount"/>
    [IsoId("1f622d67-2b68-4cac-9407-e6aabb5d5c72")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.ExchangeRate"/>
    [IsoId("ef45b852-b2dc-46e2-bd6e-2816361729d3")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.ChargeBearer"/>
    [IsoId("d58dff4c-199f-45ed-a495-dff0d0a385af")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.ChargesInformation"/>
    [IsoId("83f499ae-fc36-4303-843e-abc10c8d62d7")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.RequestedCollectionDate"/>
    [IsoId("7ae95e44-1194-4af6-825f-4a2f4d2e2d00")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.DirectDebitTransaction"/>
    [IsoId("4fb4e0ef-67f3-4ac4-a858-25b819a67212")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction12? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.Creditor"/>
    [IsoId("c731dbec-9ef5-4f26-bf60-d41dd764e1b7")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.CreditorAccount"/>
    [IsoId("407e5f0b-3e82-460b-9755-5916e3b5d142")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.CreditorAgent"/>
    [IsoId("ca7b722b-1b72-43e1-8bbd-fc49ca4b7fea")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.CreditorAgentAccount"/>
    [IsoId("2fe14c5c-ac74-4305-86c4-6c4189091c0a")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.UltimateCreditor"/>
    [IsoId("be9e306c-b830-460f-82a4-0f23c00a55de")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.InitiatingParty"/>
    [IsoId("8fdc83ac-eb22-4e7f-91ed-22eb1402ef1a")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification272? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.InstructingAgent"/>
    [IsoId("58190664-d086-43bf-9dfa-df4d9c2c490f")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.InstructedAgent"/>
    [IsoId("1038f34d-0c61-4e63-b103-bc5de3d6481c")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.IntermediaryAgent1"/>
    [IsoId("b7bc8a68-9213-4294-86ab-429e499ac74f")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.IntermediaryAgent1Account"/>
    [IsoId("1390241a-ec8e-4818-a148-f5a5929d0e69")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.IntermediaryAgent2"/>
    [IsoId("3adcf606-f91b-41d9-8d9d-19f645cc1324")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.IntermediaryAgent2Account"/>
    [IsoId("28172d89-cbf7-406a-95bd-050655a9b6ca")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.IntermediaryAgent3"/>
    [IsoId("970e7593-ee5e-4589-90a1-34096f7360f9")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.IntermediaryAgent3Account"/>
    [IsoId("0fd6089a-ab1e-48ec-8401-76a5c52cd331")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.Debtor"/>
    [IsoId("82a63aae-d6fc-4604-afba-bc0a65af1389")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.DebtorAccount"/>
    [IsoId("4f1b0d0e-29b0-4cf1-a411-d66cf99d9204")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount40 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.DebtorAgent"/>
    [IsoId("da45a11d-4a7a-40c9-a894-0e1dfc6b01c8")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.DebtorAgentAccount"/>
    [IsoId("a86f1ebb-c24b-42b9-8468-75667b75d659")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.UltimateDebtor"/>
    [IsoId("0a60fd1d-ce25-4407-a1a1-1d6984047e8f")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.Purpose"/>
    [IsoId("71c50c41-5078-4f08-964e-ccccc425559b")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.RegulatoryReporting"/>
    [IsoId("39ded4a0-08b6-4aa9-9929-e57171a527bc")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.RelatedRemittanceInformation"/>
    [IsoId("7e5b7c39-859e-44d8-a733-84d1ca59b677")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation8> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.RemittanceInformation"/>
    [IsoId("d153e855-4a0a-4034-a042-1f951073e173")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation35.SupplementaryData"/>
    [IsoId("e280f2eb-fb24-4e64-86f6-3caf8b8e37df")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
