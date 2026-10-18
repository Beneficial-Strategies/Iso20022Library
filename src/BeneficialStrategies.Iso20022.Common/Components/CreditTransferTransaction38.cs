// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction38"/>
[IsoId("_4M0jG3L-EeidQ_AAdEzxQA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction38
{
    /// <inheritdoc cref="ICreditTransferTransaction38.CreditIdentification"/>
    [IsoId("_4ZCaK3L-EeidQ_AAdEzxQA")]
    [DisplayName("Credit Identification")]
    [IsoXmlTag("CdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CreditIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.BatchBooking"/>
    [IsoId("_4ZCaLXL-EeidQ_AAdEzxQA")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.PaymentTypeInformation"/>
    [IsoId("_4ZCaL3L-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.TotalInterbankSettlementAmount"/>
    [IsoId("_4ZCaMXL-EeidQ_AAdEzxQA")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.InterbankSettlementDate"/>
    [IsoId("_4ZCaM3L-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.SettlementTimeIndication"/>
    [IsoId("_7dQpoXRqEeiH1ZOt2UD8vQ")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.InstructingAgent"/>
    [IsoId("_4ZCaNXL-EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.InstructedAgent"/>
    [IsoId("_4ZCaN3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.IntermediaryAgent1"/>
    [IsoId("_4ZCaOXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.IntermediaryAgent1Account"/>
    [IsoId("_4ZCaO3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.IntermediaryAgent2"/>
    [IsoId("_4ZCaPXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.IntermediaryAgent2Account"/>
    [IsoId("_4ZCaP3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.IntermediaryAgent3"/>
    [IsoId("_4ZCaQXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.IntermediaryAgent3Account"/>
    [IsoId("_4ZCaQ3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.CreditorAgent"/>
    [IsoId("_4ZCaRXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.CreditorAgentAccount"/>
    [IsoId("_4ZCaR3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.Creditor"/>
    [IsoId("_4ZCaSXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification6 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.CreditorAccount"/>
    [IsoId("_4ZCaS3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.UltimateCreditor"/>
    [IsoId("_4ZCaTXL-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification6? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction38.InstructionForCreditorAgent"/>
    [IsoId("_4ZCaT3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction38.DirectDebitTransactionInformation"/>
    [IsoId("_4ZCaUXL-EeidQ_AAdEzxQA")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation25> DirectDebitTransactionInformation { get; init; } =
        [];

    // ID for the above is _4ZCaUXL-EeidQ_AAdEzxQA

    /// <inheritdoc cref="ICreditTransferTransaction38.SupplementaryData"/>
    [IsoId("_4ZCaU3L-EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
