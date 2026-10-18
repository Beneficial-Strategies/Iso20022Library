// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction76"/>
[IsoId("c1b2745a-8979-4069-a0c7-2a93a3ff6de8")]
[DisplayName("Credit Transfer Transaction76")]
public partial record CreditTransferTransaction76
{
    /// <inheritdoc cref="ICreditTransferTransaction76.PaymentIdentification"/>
    [IsoId("c1b2745a-0001-0001-0001-89794069a0c7")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.PaymentTypeInformation"/>
    [IsoId("c1b2745a-0002-0002-0002-89794069a0c7")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.Amount"/>
    [IsoId("c1b2745a-0003-0003-0003-89794069a0c7")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.ChargeBearer"/>
    [IsoId("c1b2745a-0004-0004-0004-89794069a0c7")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.PreviousInstructingAgent1"/>
    [IsoId("c1b2745a-0005-0005-0005-89794069a0c7")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.PreviousInstructingAgent1Account"/>
    [IsoId("c1b2745a-0006-0006-0006-89794069a0c7")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.PreviousInstructingAgent2"/>
    [IsoId("c1b2745a-0007-0007-0007-89794069a0c7")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.PreviousInstructingAgent2Account"/>
    [IsoId("c1b2745a-0008-0008-0008-89794069a0c7")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.PreviousInstructingAgent3"/>
    [IsoId("c1b2745a-0009-0009-0009-89794069a0c7")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.PreviousInstructingAgent3Account"/>
    [IsoId("c1b2745a-0010-0010-0010-89794069a0c7")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.IntermediaryAgent1"/>
    [IsoId("c1b2745a-0011-0011-0011-89794069a0c7")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.IntermediaryAgent1Account"/>
    [IsoId("c1b2745a-0012-0012-0012-89794069a0c7")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.IntermediaryAgent2"/>
    [IsoId("c1b2745a-0013-0013-0013-89794069a0c7")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.IntermediaryAgent2Account"/>
    [IsoId("c1b2745a-0014-0014-0014-89794069a0c7")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.IntermediaryAgent3"/>
    [IsoId("c1b2745a-0015-0015-0015-89794069a0c7")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.IntermediaryAgent3Account"/>
    [IsoId("c1b2745a-0016-0016-0016-89794069a0c7")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.CreditorAgent"/>
    [IsoId("c1b2745a-0017-0017-0017-89794069a0c7")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.CreditorAgentAccount"/>
    [IsoId("c1b2745a-0018-0018-0018-89794069a0c7")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.Creditor"/>
    [IsoId("c1b2745a-0019-0019-0019-89794069a0c7")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification272? Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.CreditorAccount"/>
    [IsoId("c1b2745a-0020-0020-0020-89794069a0c7")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.UltimateCreditor"/>
    [IsoId("c1b2745a-0021-0021-0021-89794069a0c7")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.InstructionForDebtorAgent"/>
    [IsoId("c1b2745a-0022-0022-0022-89794069a0c7")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.InstructionForCreditorAgent"/>
    [IsoId("c1b2745a-0023-0023-0023-89794069a0c7")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction76.RegulatoryReporting"/>
    [IsoId("c1b2745a-0024-0024-0024-89794069a0c7")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction76.RelatedRemittanceInformation"/>
    [IsoId("c1b2745a-0025-0025-0025-89794069a0c7")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation8> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction76.RemittanceInformation"/>
    [IsoId("c1b2745a-0026-0026-0026-89794069a0c7")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation22? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction76.SupplementaryData"/>
    [IsoId("c1b2745a-0027-0027-0027-89794069a0c7")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
