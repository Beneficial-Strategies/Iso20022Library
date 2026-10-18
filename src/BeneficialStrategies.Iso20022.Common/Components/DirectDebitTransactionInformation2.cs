// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation2"/>
[IsoId("_PvWS4dp-Ed-ak6NoX_4Aeg_-1849559594")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation2
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation2.PaymentIdentification"/>
    [IsoId("_PvWS4tp-Ed-ak6NoX_4Aeg_-1847649155")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification2 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.PaymentTypeInformation"/>
    [IsoId("_PvWS49p-Ed-ak6NoX_4Aeg_-1846726795")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation4? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.InterbankSettlementAmount"/>
    [IsoId("_PvWS5Np-Ed-ak6NoX_4Aeg_-1849559007")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.InterbankSettlementDate"/>
    [IsoId("_PvWS5dp-Ed-ak6NoX_4Aeg_-1848635881")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.InstructedAmount"/>
    [IsoId("_PvWS5tp-Ed-ak6NoX_4Aeg_-1849559067")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public CurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.ExchangeRate"/>
    [IsoId("_Pvfc0Np-Ed-ak6NoX_4Aeg_-1848635952")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.ChargeBearer"/>
    [IsoId("_Pvfc0dp-Ed-ak6NoX_4Aeg_-1849559327")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.ChargesInformation"/>
    [IsoId("_Pvfc0tp-Ed-ak6NoX_4Aeg_-1847648800")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation1> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.RequestedCollectionDate"/>
    [IsoId("_Pvfc09p-Ed-ak6NoX_4Aeg_-1849559439")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.DirectDebitTransaction"/>
    [IsoId("_Pvfc1Np-Ed-ak6NoX_4Aeg_-1847715279")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction1? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.Creditor"/>
    [IsoId("_Pvfc1dp-Ed-ak6NoX_4Aeg_-1846727614")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification8 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.CreditorAccount"/>
    [IsoId("_Pvfc1tp-Ed-ak6NoX_4Aeg_-1847649730")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.CreditorAgent"/>
    [IsoId("_Pvfc19p-Ed-ak6NoX_4Aeg_-1846728284")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.CreditorAgentAccount"/>
    [IsoId("_Pvfc2Np-Ed-ak6NoX_4Aeg_-1847650669")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.UltimateCreditor"/>
    [IsoId("_Pvfc2dp-Ed-ak6NoX_4Aeg_-1846727666")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.InitiatingParty"/>
    [IsoId("_PvpN0Np-Ed-ak6NoX_4Aeg_-1846727319")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.InstructingAgent"/>
    [IsoId("_PvpN0dp-Ed-ak6NoX_4Aeg_-1846728112")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.InstructedAgent"/>
    [IsoId("_PvpN0tp-Ed-ak6NoX_4Aeg_-1846728224")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.IntermediaryAgent1"/>
    [IsoId("_PvpN09p-Ed-ak6NoX_4Aeg_-1846728621")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.IntermediaryAgent1Account"/>
    [IsoId("_PvpN1Np-Ed-ak6NoX_4Aeg_-1847650721")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount7? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.IntermediaryAgent2"/>
    [IsoId("_PvpN1dp-Ed-ak6NoX_4Aeg_-1846727751")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.IntermediaryAgent2Account"/>
    [IsoId("_PvpN1tp-Ed-ak6NoX_4Aeg_-1847650266")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount7? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.IntermediaryAgent3"/>
    [IsoId("_PvpN19p-Ed-ak6NoX_4Aeg_-1846727804")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.IntermediaryAgent3Account"/>
    [IsoId("_PvpN2Np-Ed-ak6NoX_4Aeg_-1847650318")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount7? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.Debtor"/>
    [IsoId("_PvpN2dp-Ed-ak6NoX_4Aeg_-1846727258")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.DebtorAccount"/>
    [IsoId("_Pvy-0Np-Ed-ak6NoX_4Aeg_-1846728716")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount7 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.DebtorAgent"/>
    [IsoId("_Pvy-0dp-Ed-ak6NoX_4Aeg_-1846728561")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.DebtorAgentAccount"/>
    [IsoId("_Pvy-0tp-Ed-ak6NoX_4Aeg_-1847650378")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.UltimateDebtor"/>
    [IsoId("_Pvy-09p-Ed-ak6NoX_4Aeg_-1846727181")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.Purpose"/>
    [IsoId("_Pvy-1Np-Ed-ak6NoX_4Aeg_-1846726873")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose1Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.RegulatoryReporting"/>
    [IsoId("_Pvy-1dp-Ed-ak6NoX_4Aeg_-1847649198")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting2> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.RelatedRemittanceInformation"/>
    [IsoId("_Pvy-1tp-Ed-ak6NoX_4Aeg_-1847649387")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation2.RemittanceInformation"/>
    [IsoId("_Pvy-19p-Ed-ak6NoX_4Aeg_-1847649430")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation1? RemittanceInformation { get; init; }
}
