// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction57"/>
[IsoId("_k0R48QzcEe2Wmf2RrXviyA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction57
{
    /// <inheritdoc cref="ICreditTransferTransaction57.PaymentIdentification"/>
    [IsoId("_k9-ngQzcEe2Wmf2RrXviyA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.PaymentTypeInformation"/>
    [IsoId("_k9-ngwzcEe2Wmf2RrXviyA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.PaymentCondition"/>
    [IsoId("_k9-nhQzcEe2Wmf2RrXviyA")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.RequestedExecutionDate"/>
    [IsoId("_ffVr4Q5NEe2xs7BqO31w6w")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.Amount"/>
    [IsoId("_k9-nhwzcEe2Wmf2RrXviyA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.ChargeBearer"/>
    [IsoId("_k9-niQzcEe2Wmf2RrXviyA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.MandateRelatedInformation"/>
    [IsoId("_k9-niwzcEe2Wmf2RrXviyA")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.ChequeInstruction"/>
    [IsoId("_k9-njQzcEe2Wmf2RrXviyA")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque16? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.UltimateDebtor"/>
    [IsoId("_k9-njwzcEe2Wmf2RrXviyA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.IntermediaryAgent1"/>
    [IsoId("_k9-nkQzcEe2Wmf2RrXviyA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.IntermediaryAgent2"/>
    [IsoId("_k9-nkwzcEe2Wmf2RrXviyA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.IntermediaryAgent3"/>
    [IsoId("_k9-nlQzcEe2Wmf2RrXviyA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.CreditorAgent"/>
    [IsoId("_k9-nlwzcEe2Wmf2RrXviyA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.CreditorAgentAccount"/>
    [IsoId("_33rRYAzcEe2Wmf2RrXviyA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.Creditor"/>
    [IsoId("_k9-nmQzcEe2Wmf2RrXviyA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.CreditorAccount"/>
    [IsoId("_k9-nmwzcEe2Wmf2RrXviyA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.UltimateCreditor"/>
    [IsoId("_k9-nnQzcEe2Wmf2RrXviyA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.InstructionForCreditorAgent"/>
    [IsoId("_k9-nnwzcEe2Wmf2RrXviyA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction57.Purpose"/>
    [IsoId("_k9-noQzcEe2Wmf2RrXviyA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.RegulatoryReporting"/>
    [IsoId("_k9-nowzcEe2Wmf2RrXviyA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction57.Tax"/>
    [IsoId("_k9-npQzcEe2Wmf2RrXviyA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation10? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.RelatedRemittanceInformation"/>
    [IsoId("_k9-npwzcEe2Wmf2RrXviyA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction57.RemittanceInformation"/>
    [IsoId("_k9-nqQzcEe2Wmf2RrXviyA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction57.EnclosedFile"/>
    [IsoId("_k9-nqwzcEe2Wmf2RrXviyA")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction57.SupplementaryData"/>
    [IsoId("_k9-nrQzcEe2Wmf2RrXviyA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
