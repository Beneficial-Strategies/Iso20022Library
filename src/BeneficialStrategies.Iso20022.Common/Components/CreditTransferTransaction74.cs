// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction74"/>
[IsoId("93934465-b451-4b8f-9290-2b4ac7d51d84")]
[DisplayName("Credit Transfer Transaction74")]
public partial record CreditTransferTransaction74
{
    /// <inheritdoc cref="ICreditTransferTransaction74.PaymentIdentification"/>
    [IsoId("93934465-0001-0001-0001-b4514b8f9290")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.PaymentTypeInformation"/>
    [IsoId("93934465-0002-0002-0002-b4514b8f9290")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.Amount"/>
    [IsoId("93934465-0003-0003-0003-b4514b8f9290")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.ChargeBearer"/>
    [IsoId("93934465-0004-0004-0004-b4514b8f9290")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.PreviousInstructingAgent1"/>
    [IsoId("93934465-0005-0005-0005-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.PreviousInstructingAgent1Account"/>
    [IsoId("93934465-0006-0006-0006-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.PreviousInstructingAgent2"/>
    [IsoId("93934465-0007-0007-0007-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.PreviousInstructingAgent2Account"/>
    [IsoId("93934465-0008-0008-0008-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.PreviousInstructingAgent3"/>
    [IsoId("93934465-0009-0009-0009-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.PreviousInstructingAgent3Account"/>
    [IsoId("93934465-0010-0010-0010-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.IntermediaryAgent1"/>
    [IsoId("93934465-0011-0011-0011-b4514b8f9290")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.IntermediaryAgent1Account"/>
    [IsoId("93934465-0012-0012-0012-b4514b8f9290")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.IntermediaryAgent2"/>
    [IsoId("93934465-0013-0013-0013-b4514b8f9290")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.IntermediaryAgent2Account"/>
    [IsoId("93934465-0014-0014-0014-b4514b8f9290")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.IntermediaryAgent3"/>
    [IsoId("93934465-0015-0015-0015-b4514b8f9290")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.IntermediaryAgent3Account"/>
    [IsoId("93934465-0016-0016-0016-b4514b8f9290")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.CreditorAgent"/>
    [IsoId("93934465-0017-0017-0017-b4514b8f9290")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.CreditorAgentAccount"/>
    [IsoId("93934465-0018-0018-0018-b4514b8f9290")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.Creditor"/>
    [IsoId("93934465-0019-0019-0019-b4514b8f9290")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.CreditorAccount"/>
    [IsoId("93934465-0020-0020-0020-b4514b8f9290")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.UltimateCreditor"/>
    [IsoId("93934465-0021-0021-0021-b4514b8f9290")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction74.InstructionForCreditorAgent"/>
    [IsoId("93934465-0022-0022-0022-b4514b8f9290")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction74.RegulatoryReporting"/>
    [IsoId("93934465-0023-0023-0023-b4514b8f9290")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction74.RelatedRemittanceInformation"/>
    [IsoId("93934465-0024-0024-0024-b4514b8f9290")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation8> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction74.EnclosedFile"/>
    [IsoId("93934465-0025-0025-0025-b4514b8f9290")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document15> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction74.SupplementaryData"/>
    [IsoId("93934465-0026-0026-0026-b4514b8f9290")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
