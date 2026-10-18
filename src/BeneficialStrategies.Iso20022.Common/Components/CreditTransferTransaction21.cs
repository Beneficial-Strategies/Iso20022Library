// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction21"/>
[IsoId("_bW18G0_JEeSNduMozFyRUg")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction21
{
    /// <inheritdoc cref="ICreditTransferTransaction21.PaymentIdentification"/>
    [IsoId("_bmBAbU_JEeSNduMozFyRUg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.PaymentTypeInformation"/>
    [IsoId("_bmBAb0_JEeSNduMozFyRUg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.Amount"/>
    [IsoId("_bmBAcU_JEeSNduMozFyRUg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.ChargeBearer"/>
    [IsoId("_bmBAc0_JEeSNduMozFyRUg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.ChequeInstruction"/>
    [IsoId("_bmBAdU_JEeSNduMozFyRUg")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque7? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.UltimateDebtor"/>
    [IsoId("_bmBAd0_JEeSNduMozFyRUg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.IntermediaryAgent1"/>
    [IsoId("_bmBAeU_JEeSNduMozFyRUg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.IntermediaryAgent2"/>
    [IsoId("_bmBAe0_JEeSNduMozFyRUg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.IntermediaryAgent3"/>
    [IsoId("_bmBAfU_JEeSNduMozFyRUg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.CreditorAgent"/>
    [IsoId("_bmBAf0_JEeSNduMozFyRUg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.Creditor"/>
    [IsoId("_bmBAgU_JEeSNduMozFyRUg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.CreditorAccount"/>
    [IsoId("_bmBAg0_JEeSNduMozFyRUg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.UltimateCreditor"/>
    [IsoId("_bmBAhU_JEeSNduMozFyRUg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.InstructionForCreditorAgent"/>
    [IsoId("_bmBAh0_JEeSNduMozFyRUg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction21.Purpose"/>
    [IsoId("_bmBAiU_JEeSNduMozFyRUg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.RegulatoryReporting"/>
    [IsoId("_bmBAi0_JEeSNduMozFyRUg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction21.Tax"/>
    [IsoId("_bmBAjU_JEeSNduMozFyRUg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.RelatedRemittanceInformation"/>
    [IsoId("_bmBAj0_JEeSNduMozFyRUg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction21.RemittanceInformation"/>
    [IsoId("_bmBAkU_JEeSNduMozFyRUg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation10? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction21.SupplementaryData"/>
    [IsoId("_bmBAk0_JEeSNduMozFyRUg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
