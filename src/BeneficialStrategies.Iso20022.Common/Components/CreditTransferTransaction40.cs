// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction40"/>
[IsoId("_PEiqV8QAEemsic1bQcEtLA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction40
{
    /// <inheritdoc cref="ICreditTransferTransaction40.PaymentIdentification"/>
    [IsoId("_PRQQk8QAEemsic1bQcEtLA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.PaymentTypeInformation"/>
    [IsoId("_PRQQlcQAEemsic1bQcEtLA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.Amount"/>
    [IsoId("_PRQQl8QAEemsic1bQcEtLA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.ExchangeRateInformation"/>
    [IsoId("_PRQQmcQAEemsic1bQcEtLA")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.ChargeBearer"/>
    [IsoId("_PRQQm8QAEemsic1bQcEtLA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.MandateRelatedInformation"/>
    [IsoId("_aQpB4cl0Eem0vqvvoqYsqQ")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.ChequeInstruction"/>
    [IsoId("_PRQQncQAEemsic1bQcEtLA")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque11? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.UltimateDebtor"/>
    [IsoId("_PRQQn8QAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.IntermediaryAgent1"/>
    [IsoId("_PRQQocQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.IntermediaryAgent1Account"/>
    [IsoId("_PRQQo8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.IntermediaryAgent2"/>
    [IsoId("_PRQQpcQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.IntermediaryAgent2Account"/>
    [IsoId("_PRQQp8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.IntermediaryAgent3"/>
    [IsoId("_PRQQqcQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.IntermediaryAgent3Account"/>
    [IsoId("_PRQQq8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.CreditorAgent"/>
    [IsoId("_PRQQrcQAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.CreditorAgentAccount"/>
    [IsoId("_PRQQr8QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.Creditor"/>
    [IsoId("_PRQQscQAEemsic1bQcEtLA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification135? Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.CreditorAccount"/>
    [IsoId("_PRQQs8QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.UltimateCreditor"/>
    [IsoId("_PRQQtcQAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.InstructionForCreditorAgent"/>
    [IsoId("_PRQQt8QAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction40.InstructionForDebtorAgent"/>
    [IsoId("_PRQQucQAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.Purpose"/>
    [IsoId("_PRQQu8QAEemsic1bQcEtLA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.RegulatoryReporting"/>
    [IsoId("_PRQQvcQAEemsic1bQcEtLA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction40.Tax"/>
    [IsoId("_PRQQv8QAEemsic1bQcEtLA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.RelatedRemittanceInformation"/>
    [IsoId("_PRQQwcQAEemsic1bQcEtLA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction40.RemittanceInformation"/>
    [IsoId("_PRQQw8QAEemsic1bQcEtLA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction40.SupplementaryData"/>
    [IsoId("_PRQQxcQAEemsic1bQcEtLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
