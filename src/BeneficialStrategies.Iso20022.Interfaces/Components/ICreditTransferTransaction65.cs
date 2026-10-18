// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit Transfer Transaction65.
/// </summary>
[IsoId("_9qIHszEsEe6GxLzpkVnWYg")]
public interface ICreditTransferTransaction65 : IIsoComponent
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    IAmountType4Choice Amount { get; }

    /// <summary>
    /// Charge Bearer.
    /// </summary>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Cheque Instruction.
    /// </summary>
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    ICheque19? ChequeInstruction { get; }

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification272 Creditor { get; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 CreditorAgent { get; }

    /// <summary>
    /// Creditor Agent Account.
    /// </summary>
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Enclosed File.
    /// </summary>
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    IEnumerable<IDocument15> EnclosedFile { get; }

    /// <summary>
    /// Instruction For Creditor Agent.
    /// </summary>
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent3> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Intermediary Agent1.
    /// </summary>
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; }

    /// <summary>
    /// Intermediary Agent2.
    /// </summary>
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; }

    /// <summary>
    /// Intermediary Agent3.
    /// </summary>
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; }

    /// <summary>
    /// Mandate Related Information.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    ICreditTransferMandateData1? MandateRelatedInformation { get; }

    /// <summary>
    /// Payment Condition.
    /// </summary>
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    IPaymentCondition2? PaymentCondition { get; }

    /// <summary>
    /// Payment Identification.
    /// </summary>
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification6 PaymentIdentification { get; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation29? PaymentTypeInformation { get; }

    /// <summary>
    /// Purpose.
    /// </summary>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Regulatory Reporting.
    /// </summary>
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting3> RegulatoryReporting { get; }

    /// <summary>
    /// Related Remittance Information.
    /// </summary>
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation8> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Remittance Information.
    /// </summary>
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation22? RemittanceInformation { get; }

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    IDateAndDateTime2Choice? RequestedExecutionDate { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    ITaxData1? Tax { get; }

    /// <summary>
    /// Ultimate Creditor.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification272? UltimateCreditor { get; }

    /// <summary>
    /// Ultimate Debtor.
    /// </summary>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification272? UltimateDebtor { get; }
}
