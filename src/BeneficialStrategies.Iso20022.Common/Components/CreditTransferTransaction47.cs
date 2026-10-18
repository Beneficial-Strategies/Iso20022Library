// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction47"/>
[IsoId("_r6YgIQbHEeqF8ePC1fs2Gg")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction47
{
    /// <inheritdoc cref="ICreditTransferTransaction47.CreditIdentification"/>
    [IsoId("_sNsdywbHEeqF8ePC1fs2Gg")]
    [DisplayName("Credit Identification")]
    [IsoXmlTag("CdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CreditIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.BatchBooking"/>
    [IsoId("_sNsdzQbHEeqF8ePC1fs2Gg")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.PaymentTypeInformation"/>
    [IsoId("_sNsdzwbHEeqF8ePC1fs2Gg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.TotalInterbankSettlementAmount"/>
    [IsoId("_sNsd0QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.InterbankSettlementDate"/>
    [IsoId("_sNsd0wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.SettlementTimeIndication"/>
    [IsoId("_sNsd1QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.InstructingAgent"/>
    [IsoId("_sNsd1wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.InstructedAgent"/>
    [IsoId("_sNsd2QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.IntermediaryAgent1"/>
    [IsoId("_sNsd2wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.IntermediaryAgent1Account"/>
    [IsoId("_sNsd3QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.IntermediaryAgent2"/>
    [IsoId("_sNsd3wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.IntermediaryAgent2Account"/>
    [IsoId("_sNsd4QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.IntermediaryAgent3"/>
    [IsoId("_sNsd4wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.IntermediaryAgent3Account"/>
    [IsoId("_sNsd5QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.CreditorAgent"/>
    [IsoId("_sNsd5wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.CreditorAgentAccount"/>
    [IsoId("_sNsd6QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.Creditor"/>
    [IsoId("_sNsd6wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification6 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.CreditorAccount"/>
    [IsoId("_sNsd7QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.UltimateCreditor"/>
    [IsoId("_sNsd7wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification6? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction47.InstructionForCreditorAgent"/>
    [IsoId("_sNsd8QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction47.DirectDebitTransactionInformation"/>
    [IsoId("_sNsd8wbHEeqF8ePC1fs2Gg")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation26> DirectDebitTransactionInformation { get; init; } =
        [];

    // ID for the above is _sNsd8wbHEeqF8ePC1fs2Gg

    /// <inheritdoc cref="ICreditTransferTransaction47.SupplementaryData"/>
    [IsoId("_sNsd9QbHEeqF8ePC1fs2Gg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
