// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation10"/>
[IsoId("_P4b9eNp-Ed-ak6NoX_4Aeg_1928918849")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation10
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation10.PaymentIdentification"/>
    [IsoId("_P4b9edp-Ed-ak6NoX_4Aeg_1929840262")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.PaymentTypeInformation"/>
    [IsoId("_P4b9etp-Ed-ak6NoX_4Aeg_1929840499")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation22? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.InterbankSettlementAmount"/>
    [IsoId("_P4b9e9p-Ed-ak6NoX_4Aeg_1928919211")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.InterbankSettlementDate"/>
    [IsoId("_P4b9fNp-Ed-ak6NoX_4Aeg_1928919303")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.InstructedAmount"/>
    [IsoId("_P4b9fdp-Ed-ak6NoX_4Aeg_1928919189")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.ExchangeRate"/>
    [IsoId("_P4lHYNp-Ed-ak6NoX_4Aeg_1928919273")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.ChargeBearer"/>
    [IsoId("_P4lHYdp-Ed-ak6NoX_4Aeg_1928918911")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.ChargesInformation"/>
    [IsoId("_P4lHYtp-Ed-ak6NoX_4Aeg_1929840777")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation5> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.RequestedCollectionDate"/>
    [IsoId("_P4lHY9p-Ed-ak6NoX_4Aeg_1928918880")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.DirectDebitTransaction"/>
    [IsoId("_P4lHZNp-Ed-ak6NoX_4Aeg_1928919626")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction6? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.Creditor"/>
    [IsoId("_P4lHZdp-Ed-ak6NoX_4Aeg_1929840930")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification32 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.CreditorAccount"/>
    [IsoId("_P4lHZtp-Ed-ak6NoX_4Aeg_1928919736")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.CreditorAgent"/>
    [IsoId("_P4lHZ9p-Ed-ak6NoX_4Aeg_1929841416")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.CreditorAgentAccount"/>
    [IsoId("_P4lHaNp-Ed-ak6NoX_4Aeg_1928920167")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.UltimateCreditor"/>
    [IsoId("_P4lHadp-Ed-ak6NoX_4Aeg_1929841209")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.InitiatingParty"/>
    [IsoId("_P4u4YNp-Ed-ak6NoX_4Aeg_1929840869")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.InstructingAgent"/>
    [IsoId("_P4u4Ydp-Ed-ak6NoX_4Aeg_1929840323")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.InstructedAgent"/>
    [IsoId("_P4u4Ytp-Ed-ak6NoX_4Aeg_1929841355")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.IntermediaryAgent1"/>
    [IsoId("_P4u4Y9p-Ed-ak6NoX_4Aeg_1929840354")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.IntermediaryAgent1Account"/>
    [IsoId("_P4u4ZNp-Ed-ak6NoX_4Aeg_1928919705")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount16? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.IntermediaryAgent2"/>
    [IsoId("_P4u4Zdp-Ed-ak6NoX_4Aeg_1929841324")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.IntermediaryAgent2Account"/>
    [IsoId("_P4u4Ztp-Ed-ak6NoX_4Aeg_1928919767")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount16? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.IntermediaryAgent3"/>
    [IsoId("_P4u4Z9p-Ed-ak6NoX_4Aeg_1929840407")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.IntermediaryAgent3Account"/>
    [IsoId("_P4u4aNp-Ed-ak6NoX_4Aeg_1928919828")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount16? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.Debtor"/>
    [IsoId("_P4u4adp-Ed-ak6NoX_4Aeg_1929840838")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.DebtorAccount"/>
    [IsoId("_P44pYNp-Ed-ak6NoX_4Aeg_1928919644")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount16 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.DebtorAgent"/>
    [IsoId("_P44pYdp-Ed-ak6NoX_4Aeg_1929841478")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.DebtorAgentAccount"/>
    [IsoId("_P44pYtp-Ed-ak6NoX_4Aeg_1928920137")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.UltimateDebtor"/>
    [IsoId("_P44pY9p-Ed-ak6NoX_4Aeg_1929841270")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.Purpose"/>
    [IsoId("_P44pZNp-Ed-ak6NoX_4Aeg_1928920198")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.RegulatoryReporting"/>
    [IsoId("_P44pZdp-Ed-ak6NoX_4Aeg_1929840231")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.RelatedRemittanceInformation"/>
    [IsoId("_P44pZtp-Ed-ak6NoX_4Aeg_1929840468")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation10.RemittanceInformation"/>
    [IsoId("_P44pZ9p-Ed-ak6NoX_4Aeg_1928919859")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }
}
