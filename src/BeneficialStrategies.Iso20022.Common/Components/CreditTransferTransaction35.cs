// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction35"/>
[IsoId("_Vf_Uu249EeiU9cctagi5ow")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction35
{
    /// <inheritdoc cref="ICreditTransferTransaction35.PaymentIdentification"/>
    [IsoId("_VsNLrW49EeiU9cctagi5ow")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.PaymentTypeInformation"/>
    [IsoId("_VsNLr249EeiU9cctagi5ow")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.PaymentCondition"/>
    [IsoId("_-JmZkXVmEeiEU7thYTAN1w")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.Amount"/>
    [IsoId("_VsNLsW49EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.ChargeBearer"/>
    [IsoId("_VsNLs249EeiU9cctagi5ow")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.ChequeInstruction"/>
    [IsoId("_VsNLtW49EeiU9cctagi5ow")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque11? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.UltimateDebtor"/>
    [IsoId("_VsNLt249EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.IntermediaryAgent1"/>
    [IsoId("_VsNLuW49EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.IntermediaryAgent2"/>
    [IsoId("_VsNLu249EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.IntermediaryAgent3"/>
    [IsoId("_VsNLvW49EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.CreditorAgent"/>
    [IsoId("_VsNLv249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.Creditor"/>
    [IsoId("_VsNLwW49EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.CreditorAccount"/>
    [IsoId("_VsNLw249EeiU9cctagi5ow")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.UltimateCreditor"/>
    [IsoId("_VsNLxW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.InstructionForCreditorAgent"/>
    [IsoId("_VsNLx249EeiU9cctagi5ow")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction35.Purpose"/>
    [IsoId("_VsNLyW49EeiU9cctagi5ow")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.RegulatoryReporting"/>
    [IsoId("_VsNLy249EeiU9cctagi5ow")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction35.Tax"/>
    [IsoId("_VsNLzW49EeiU9cctagi5ow")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.RelatedRemittanceInformation"/>
    [IsoId("_VsNLz249EeiU9cctagi5ow")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction35.RemittanceInformation"/>
    [IsoId("_VsNL0W49EeiU9cctagi5ow")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction35.EnclosedFile"/>
    [IsoId("_EXXSUXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction35.SupplementaryData"/>
    [IsoId("_VsNL0249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
