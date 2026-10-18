// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation24"/>
[IsoId("_3MS6LXL-EeidQ_AAdEzxQA")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation24
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation24.PaymentIdentification"/>
    [IsoId("_3W3yi3L-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification7 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.PaymentTypeInformation"/>
    [IsoId("_3W3yjXL-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.InterbankSettlementAmount"/>
    [IsoId("_3W3yj3L-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.InterbankSettlementDate"/>
    [IsoId("_3W3ykXL-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.SettlementPriority"/>
    [IsoId("_3W3yk3L-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.SettlementTimeIndication"/>
    [IsoId("_38USkYjbEei-69PNFxn_Ew")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.InstructedAmount"/>
    [IsoId("_3W3ylXL-EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.ExchangeRate"/>
    [IsoId("_3W3yl3L-EeidQ_AAdEzxQA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.ChargeBearer"/>
    [IsoId("_3W3ymXL-EeidQ_AAdEzxQA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.ChargesInformation"/>
    [IsoId("_3W3ym3L-EeidQ_AAdEzxQA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.RequestedCollectionDate"/>
    [IsoId("_3W3ynXL-EeidQ_AAdEzxQA")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.DirectDebitTransaction"/>
    [IsoId("_3W3yn3L-EeidQ_AAdEzxQA")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction10? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.Creditor"/>
    [IsoId("_3W3yoXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.CreditorAccount"/>
    [IsoId("_3W3yo3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.CreditorAgent"/>
    [IsoId("_3W3ypXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.CreditorAgentAccount"/>
    [IsoId("_3W3yp3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.UltimateCreditor"/>
    [IsoId("_3W3yqXL-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.InitiatingParty"/>
    [IsoId("_3W3yq3L-EeidQ_AAdEzxQA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.InstructingAgent"/>
    [IsoId("_3W3yrXL-EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.InstructedAgent"/>
    [IsoId("_3W3yr3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.IntermediaryAgent1"/>
    [IsoId("_3W3ysXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.IntermediaryAgent1Account"/>
    [IsoId("_3W3ys3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.IntermediaryAgent2"/>
    [IsoId("_3W3ytXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.IntermediaryAgent2Account"/>
    [IsoId("_3W3yt3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.IntermediaryAgent3"/>
    [IsoId("_3W3yuXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.IntermediaryAgent3Account"/>
    [IsoId("_3W3yu3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.Debtor"/>
    [IsoId("_3W3yvXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.DebtorAccount"/>
    [IsoId("_3W3yv3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount38 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.DebtorAgent"/>
    [IsoId("_3W3ywXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.DebtorAgentAccount"/>
    [IsoId("_3W3yw3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.UltimateDebtor"/>
    [IsoId("_3W3yxXL-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.Purpose"/>
    [IsoId("_3W3yx3L-EeidQ_AAdEzxQA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.RegulatoryReporting"/>
    [IsoId("_3W3yyXL-EeidQ_AAdEzxQA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.RelatedRemittanceInformation"/>
    [IsoId("_3W3yy3L-EeidQ_AAdEzxQA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.RemittanceInformation"/>
    [IsoId("_3W3yzXL-EeidQ_AAdEzxQA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation24.SupplementaryData"/>
    [IsoId("_3W3yz3L-EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
