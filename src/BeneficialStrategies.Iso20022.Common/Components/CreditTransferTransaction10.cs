// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction10"/>
[IsoId("_S7HGMTikEeKpHbBQ3XWFBw")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction10
{
    /// <inheritdoc cref="ICreditTransferTransaction10.PaymentIdentification"/>
    [IsoId("_TGVe2TikEeKpHbBQ3XWFBw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.PaymentTypeInformation"/>
    [IsoId("_TGVe3TikEeKpHbBQ3XWFBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.Amount"/>
    [IsoId("_TGVe5TikEeKpHbBQ3XWFBw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType3Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.ChargeBearer"/>
    [IsoId("_TGVe6TikEeKpHbBQ3XWFBw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.ChequeInstruction"/>
    [IsoId("_TGVe8TikEeKpHbBQ3XWFBw")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque7? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.UltimateDebtor"/>
    [IsoId("_TGVe-TikEeKpHbBQ3XWFBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.IntermediaryAgent1"/>
    [IsoId("_TGVfATikEeKpHbBQ3XWFBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.IntermediaryAgent2"/>
    [IsoId("_TGVfBTikEeKpHbBQ3XWFBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.IntermediaryAgent3"/>
    [IsoId("_TGVfCTikEeKpHbBQ3XWFBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.CreditorAgent"/>
    [IsoId("_TGVfDTikEeKpHbBQ3XWFBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.Creditor"/>
    [IsoId("_TGVfFTikEeKpHbBQ3XWFBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.CreditorAccount"/>
    [IsoId("_TGVfGTikEeKpHbBQ3XWFBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.UltimateCreditor"/>
    [IsoId("_TGVfITikEeKpHbBQ3XWFBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.InstructionForCreditorAgent"/>
    [IsoId("_TGVfJTikEeKpHbBQ3XWFBw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction10.Purpose"/>
    [IsoId("_TGVfKTikEeKpHbBQ3XWFBw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.RegulatoryReporting"/>
    [IsoId("_TGVfLTikEeKpHbBQ3XWFBw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction10.Tax"/>
    [IsoId("_TGVfMTikEeKpHbBQ3XWFBw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.RelatedRemittanceInformation"/>
    [IsoId("_TGVfNTikEeKpHbBQ3XWFBw")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction10.RemittanceInformation"/>
    [IsoId("_TGVfOTikEeKpHbBQ3XWFBw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction10.SupplementaryData"/>
    [IsoId("_8q-2kDikEeKpHbBQ3XWFBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
