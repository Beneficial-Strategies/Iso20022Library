// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction9"/>
[IsoId("_7h-8oGcJEeKAGeP1fbluEg")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction9
{
    /// <inheritdoc cref="ICreditTransferTransaction9.CreditIdentification"/>
    [IsoId("_grK1Z2cKEeKAGeP1fbluEg")]
    [DisplayName("Credit Identification")]
    [IsoXmlTag("CdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CreditIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.BatchBooking"/>
    [IsoId("_ntdMZ2cKEeKAGeP1fbluEg")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.PaymentTypeInformation"/>
    [IsoId("_7h_jWWcJEeKAGeP1fbluEg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.TotalInterbankSettlementAmount"/>
    [IsoId("_7iBYkWcJEeKAGeP1fbluEg")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.InterbankSettlementDate"/>
    [IsoId("_sl4692cKEeKAGeP1fbluEg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.InstructingAgent"/>
    [IsoId("_IeYmc3zxEeKpJYN-DrBsZQ")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.InstructedAgent"/>
    [IsoId("_IeYmenzxEeKpJYN-DrBsZQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.IntermediaryAgent1"/>
    [IsoId("_7iAKaGcJEeKAGeP1fbluEg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.IntermediaryAgent1Account"/>
    [IsoId("_7iBYjGcJEeKAGeP1fbluEg")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.IntermediaryAgent2"/>
    [IsoId("_7iBYlmcJEeKAGeP1fbluEg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.IntermediaryAgent2Account"/>
    [IsoId("_7iAKcmcJEeKAGeP1fbluEg")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.IntermediaryAgent3"/>
    [IsoId("_7iAxjWcJEeKAGeP1fbluEg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.IntermediaryAgent3Account"/>
    [IsoId("_7iBYqmcJEeKAGeP1fbluEg")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.CreditorAgent"/>
    [IsoId("_7iAKY2cJEeKAGeP1fbluEg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.CreditorAgentAccount"/>
    [IsoId("_7iAKd2cJEeKAGeP1fbluEg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.Creditor"/>
    [IsoId("_7iAxfmcJEeKAGeP1fbluEg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification5 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.CreditorAccount"/>
    [IsoId("_7h_jVGcJEeKAGeP1fbluEg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.UltimateCreditor"/>
    [IsoId("_7iBYm2cJEeKAGeP1fbluEg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction9.InstructionForCreditorAgent"/>
    [IsoId("_7iAxiGcJEeKAGeP1fbluEg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction9.DirectDebitTransactionInformation"/>
    [IsoId("_7iAKfGcJEeKAGeP1fbluEg")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation15> DirectDebitTransactionInformation { get; init; } =
        [];

    // ID for the above is _7iAKfGcJEeKAGeP1fbluEg

    /// <inheritdoc cref="ICreditTransferTransaction9.SupplementaryData"/>
    [IsoId("_7iBYgmcJEeKAGeP1fbluEg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
