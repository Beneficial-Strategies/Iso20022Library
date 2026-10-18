// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction53"/>
[IsoId("_dYYgIdcZEeqRFcf2R4bPBw")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction53
{
    /// <inheritdoc cref="ICreditTransferTransaction53.CreditIdentification"/>
    [IsoId("_dZxnWdcZEeqRFcf2R4bPBw")]
    [DisplayName("Credit Identification")]
    [IsoXmlTag("CdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CreditIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.BatchBooking"/>
    [IsoId("_dZxnW9cZEeqRFcf2R4bPBw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.PaymentTypeInformation"/>
    [IsoId("_dZxnXdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.TotalInterbankSettlementAmount"/>
    [IsoId("_dZxnX9cZEeqRFcf2R4bPBw")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.InterbankSettlementDate"/>
    [IsoId("_dZxnYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.SettlementTimeIndication"/>
    [IsoId("_dZxnY9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.InstructingAgent"/>
    [IsoId("_dZxnZdcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.InstructedAgent"/>
    [IsoId("_dZxnZ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.IntermediaryAgent1"/>
    [IsoId("_dZxnadcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.IntermediaryAgent1Account"/>
    [IsoId("_dZxna9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.IntermediaryAgent2"/>
    [IsoId("_dZxnbdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.IntermediaryAgent2Account"/>
    [IsoId("_dZxnb9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.IntermediaryAgent3"/>
    [IsoId("_dZxncdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.IntermediaryAgent3Account"/>
    [IsoId("_dZxnc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.CreditorAgent"/>
    [IsoId("_dZxnddcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.CreditorAgentAccount"/>
    [IsoId("_dZxnd9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.Creditor"/>
    [IsoId("_dZxnedcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification6 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.CreditorAccount"/>
    [IsoId("_dZxne9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.UltimateCreditor"/>
    [IsoId("_dZxnfdcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification6? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction53.InstructionForCreditorAgent"/>
    [IsoId("_dZxnf9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction53.DirectDebitTransactionInformation"/>
    [IsoId("_dZxngdcZEeqRFcf2R4bPBw")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation27> DirectDebitTransactionInformation { get; init; } =
        [];

    // ID for the above is _dZxngdcZEeqRFcf2R4bPBw

    /// <inheritdoc cref="ICreditTransferTransaction53.SupplementaryData"/>
    [IsoId("_dZxng9cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
