// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction15"/>
[IsoId("_wFG0kTEyEe6g-ffJsqGiSA")]
[Description(@"Provides further details on the settlement of the instruction.")]
[DisplayName("Settlement Instruction15")]
public partial record SettlementInstruction15
{
    /// <inheritdoc cref="ISettlementInstruction15.ClearingSystem"/>
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.InstructedReimbursementAgent"/>
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.InstructedReimbursementAgentAccount"/>
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount40? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.InstructingReimbursementAgent"/>
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.InstructingReimbursementAgentAccount"/>
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount40? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.SettlementAccount"/>
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount40? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.SettlementMethod"/>
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.ThirdReimbursementAgent"/>
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification8? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction15.ThirdReimbursementAgentAccount"/>
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount40? ThirdReimbursementAgentAccount { get; init; }
}
