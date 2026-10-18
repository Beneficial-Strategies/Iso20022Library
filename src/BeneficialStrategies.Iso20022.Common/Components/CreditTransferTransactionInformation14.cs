// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation14"/>
[IsoId("_URK4R9p-Ed-ak6NoX_4Aeg_1780165534")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation14
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation14.PaymentIdentification"/>
    [IsoId("_URK4SNp-Ed-ak6NoX_4Aeg_2120413737")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.PaymentTypeInformation"/>
    [IsoId("_URUpQNp-Ed-ak6NoX_4Aeg_934123935")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.Amount"/>
    [IsoId("_URUpQdp-Ed-ak6NoX_4Aeg_-449403400")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType3Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.ChargeBearer"/>
    [IsoId("_URUpQtp-Ed-ak6NoX_4Aeg_587330350")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.ChequeInstruction"/>
    [IsoId("_URUpQ9p-Ed-ak6NoX_4Aeg_-634105908")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque6? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.UltimateDebtor"/>
    [IsoId("_URUpRNp-Ed-ak6NoX_4Aeg_1196817261")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.IntermediaryAgent1"/>
    [IsoId("_URUpRdp-Ed-ak6NoX_4Aeg_475713505")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.IntermediaryAgent2"/>
    [IsoId("_URUpRtp-Ed-ak6NoX_4Aeg_1618933766")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.IntermediaryAgent3"/>
    [IsoId("_URUpR9p-Ed-ak6NoX_4Aeg_-1720769241")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.CreditorAgent"/>
    [IsoId("_URUpSNp-Ed-ak6NoX_4Aeg_2064549729")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.Creditor"/>
    [IsoId("_URUpSdp-Ed-ak6NoX_4Aeg_720555856")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.CreditorAccount"/>
    [IsoId("_UReaQNp-Ed-ak6NoX_4Aeg_-1184367993")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.UltimateCreditor"/>
    [IsoId("_UReaQdp-Ed-ak6NoX_4Aeg_339877292")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.InstructionForCreditorAgent"/>
    [IsoId("_UReaQtp-Ed-ak6NoX_4Aeg_1100642445")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.Purpose"/>
    [IsoId("_UReaQ9p-Ed-ak6NoX_4Aeg_118689079")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.RegulatoryReporting"/>
    [IsoId("_UReaRNp-Ed-ak6NoX_4Aeg_1711044373")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.Tax"/>
    [IsoId("_UReaRdp-Ed-ak6NoX_4Aeg_-1376932823")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.RelatedRemittanceInformation"/>
    [IsoId("_UReaRtp-Ed-ak6NoX_4Aeg_-298912485")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation14.RemittanceInformation"/>
    [IsoId("_UReaR9p-Ed-ak6NoX_4Aeg_563003138")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation6? RemittanceInformation { get; init; }
}
