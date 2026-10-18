// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation30"/>
[IsoId("_OdEZHxlWEe2Do_UtrNmb2g")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation30
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation30.PaymentIdentification"/>
    [IsoId("_OmlheRlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.PaymentTypeInformation"/>
    [IsoId("_OmlhexlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.InterbankSettlementAmount"/>
    [IsoId("_OmlhfRlWEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.InterbankSettlementDate"/>
    [IsoId("_OmlhfxlWEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.SettlementPriority"/>
    [IsoId("_OmlhgRlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.SettlementTimeIndication"/>
    [IsoId("_OmlhgxlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.InstructedAmount"/>
    [IsoId("_OmlhhRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.ExchangeRate"/>
    [IsoId("_OmlhhxlWEe2Do_UtrNmb2g")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.ChargeBearer"/>
    [IsoId("_OmlhiRlWEe2Do_UtrNmb2g")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.ChargesInformation"/>
    [IsoId("_OmlhixlWEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges12> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.RequestedCollectionDate"/>
    [IsoId("_OmlhjRlWEe2Do_UtrNmb2g")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.DirectDebitTransaction"/>
    [IsoId("_OmlhjxlWEe2Do_UtrNmb2g")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction11? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.Creditor"/>
    [IsoId("_OmlhkRlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.CreditorAccount"/>
    [IsoId("_OmlhkxlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.CreditorAgent"/>
    [IsoId("_OmlhlRlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.CreditorAgentAccount"/>
    [IsoId("_OmlhlxlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.UltimateCreditor"/>
    [IsoId("_OmlhmRlWEe2Do_UtrNmb2g")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.InitiatingParty"/>
    [IsoId("_OmlhmxlWEe2Do_UtrNmb2g")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.InstructingAgent"/>
    [IsoId("_OmlhnRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.InstructedAgent"/>
    [IsoId("_OmlhnxlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.IntermediaryAgent1"/>
    [IsoId("_OmlhoRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.IntermediaryAgent1Account"/>
    [IsoId("_OmlhoxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.IntermediaryAgent2"/>
    [IsoId("_OmlhpRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.IntermediaryAgent2Account"/>
    [IsoId("_OmlhpxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.IntermediaryAgent3"/>
    [IsoId("_OmlhqRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.IntermediaryAgent3Account"/>
    [IsoId("_OmlhqxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.Debtor"/>
    [IsoId("_OmlhrRlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.DebtorAccount"/>
    [IsoId("_OmlhrxlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount40 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.DebtorAgent"/>
    [IsoId("_OmlhsRlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.DebtorAgentAccount"/>
    [IsoId("_OmlhsxlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.UltimateDebtor"/>
    [IsoId("_OmlhtRlWEe2Do_UtrNmb2g")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.Purpose"/>
    [IsoId("_OmlhtxlWEe2Do_UtrNmb2g")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.RegulatoryReporting"/>
    [IsoId("_OmlhuRlWEe2Do_UtrNmb2g")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.RelatedRemittanceInformation"/>
    [IsoId("_OmlhuxlWEe2Do_UtrNmb2g")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.RemittanceInformation"/>
    [IsoId("_OmlhvRlWEe2Do_UtrNmb2g")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation30.SupplementaryData"/>
    [IsoId("_OmlhvxlWEe2Do_UtrNmb2g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
