// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction5"/>
[IsoId("_tWehUFkyEeGeoaLUQk__nA_-202288519")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction5
{
    /// <inheritdoc cref="ICreditTransferTransaction5.PaymentIdentification"/>
    [IsoId("_tWehUVkyEeGeoaLUQk__nA_444637568")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.PaymentTypeInformation"/>
    [IsoId("_tWehUlkyEeGeoaLUQk__nA_1968882853")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.Amount"/>
    [IsoId("_tWehU1kyEeGeoaLUQk__nA_1554456981")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType3Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.ChargeBearer"/>
    [IsoId("_tWnrQFkyEeGeoaLUQk__nA_1758793417")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.ChequeInstruction"/>
    [IsoId("_tWnrQVkyEeGeoaLUQk__nA_1925813312")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque7? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.UltimateDebtor"/>
    [IsoId("_tWnrQlkyEeGeoaLUQk__nA_-954917362")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.IntermediaryAgent1"/>
    [IsoId("_tWnrQ1kyEeGeoaLUQk__nA_252072738")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.IntermediaryAgent2"/>
    [IsoId("_tWnrRFkyEeGeoaLUQk__nA_154902051")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.IntermediaryAgent3"/>
    [IsoId("_tWxcQFkyEeGeoaLUQk__nA_-480129795")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.CreditorAgent"/>
    [IsoId("_tWxcQVkyEeGeoaLUQk__nA_1298122312")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.Creditor"/>
    [IsoId("_tWxcQlkyEeGeoaLUQk__nA_-1779755305")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.CreditorAccount"/>
    [IsoId("_tWxcQ1kyEeGeoaLUQk__nA_-1018990152")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.UltimateCreditor"/>
    [IsoId("_tWxcRFkyEeGeoaLUQk__nA_811933017")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.InstructionForCreditorAgent"/>
    [IsoId("_tW7NQFkyEeGeoaLUQk__nA_90829261")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction5.Purpose"/>
    [IsoId("_tW7NQVkyEeGeoaLUQk__nA_-1988912715")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.RegulatoryReporting"/>
    [IsoId("_tW7NQlkyEeGeoaLUQk__nA_798401876")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction5.Tax"/>
    [IsoId("_tW7NQ1kyEeGeoaLUQk__nA_1876422214")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction5.RelatedRemittanceInformation"/>
    [IsoId("_tW7NRFkyEeGeoaLUQk__nA_-524592075")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction5.RemittanceInformation"/>
    [IsoId("_tXEXMFkyEeGeoaLUQk__nA_1220259184")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }
}
