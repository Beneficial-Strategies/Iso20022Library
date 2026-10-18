// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction36"/>
[IsoId("_2hFaDXL-EeidQ_AAdEzxQA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction36
{
    /// <inheritdoc cref="ICreditTransferTransaction36.PaymentIdentification"/>
    [IsoId("_2rEcg3L-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification7 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.PaymentTypeInformation"/>
    [IsoId("_2rEchXL-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.InterbankSettlementAmount"/>
    [IsoId("_2rEch3L-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.InterbankSettlementDate"/>
    [IsoId("_2rEciXL-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.SettlementPriority"/>
    [IsoId("_2rEci3L-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.SettlementTimeIndication"/>
    [IsoId("_2rEcjXL-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.SettlementTimeRequest"/>
    [IsoId("_2rEcj3L-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.PreviousInstructingAgent1"/>
    [IsoId("_2rEckXL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.PreviousInstructingAgent1Account"/>
    [IsoId("_2rEck3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount38? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.PreviousInstructingAgent2"/>
    [IsoId("_2rEclXL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.PreviousInstructingAgent2Account"/>
    [IsoId("_2rEcl3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount38? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.PreviousInstructingAgent3"/>
    [IsoId("_2rEcmXL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.PreviousInstructingAgent3Account"/>
    [IsoId("_2rEcm3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount38? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.InstructingAgent"/>
    [IsoId("_2rEcnXL-EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.InstructedAgent"/>
    [IsoId("_2rEcn3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.IntermediaryAgent1"/>
    [IsoId("_2rEcoXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.IntermediaryAgent1Account"/>
    [IsoId("_2rEco3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.IntermediaryAgent2"/>
    [IsoId("_2rEcpXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.IntermediaryAgent2Account"/>
    [IsoId("_2rEcp3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.IntermediaryAgent3"/>
    [IsoId("_2rEcqXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.IntermediaryAgent3Account"/>
    [IsoId("_2rEcq3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.UltimateDebtor"/>
    [IsoId("_2rEcrXL-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification6? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.Debtor"/>
    [IsoId("_2rEcr3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification6 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.DebtorAccount"/>
    [IsoId("_2rEcsXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.DebtorAgent"/>
    [IsoId("_2rEcs3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.DebtorAgentAccount"/>
    [IsoId("_2rEctXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.CreditorAgent"/>
    [IsoId("_2rEct3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.CreditorAgentAccount"/>
    [IsoId("_2rEcuXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.Creditor"/>
    [IsoId("_2rEcu3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification6 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.CreditorAccount"/>
    [IsoId("_2rEcvXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.UltimateCreditor"/>
    [IsoId("_2rEcv3L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification6? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.InstructionForCreditorAgent"/>
    [IsoId("_2rEcwXL-EeidQ_AAdEzxQA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction36.InstructionForNextAgent"/>
    [IsoId("_2rEcw3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction36.Purpose"/>
    [IsoId("_osQ6sXRoEeiH1ZOt2UD8vQ")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.RemittanceInformation"/>
    [IsoId("_2rEcxXL-EeidQ_AAdEzxQA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_2rEcx3L-EeidQ_AAdEzxQA")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction37? UnderlyingCustomerCreditTransfer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction36.SupplementaryData"/>
    [IsoId("_2rEcyXL-EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
