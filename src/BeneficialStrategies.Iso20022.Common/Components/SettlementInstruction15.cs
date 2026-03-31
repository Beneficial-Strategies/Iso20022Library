// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Instruction15.
/// </summary>
[IsoId("_wFG0kTEyEe6g-ffJsqGiSA")]
[DisplayName("Settlement Instruction15")]
public record SettlementInstruction15
{
    /// <summary>
    /// Clearing System.
    /// </summary>
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <summary>
    /// Instructed Reimbursement Agent.
    /// </summary>
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedReimbursementAgent { get; init; }

    /// <summary>
    /// Instructed Reimbursement Agent Account.
    /// </summary>
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount40? InstructedReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Instructing Reimbursement Agent.
    /// </summary>
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingReimbursementAgent { get; init; }

    /// <summary>
    /// Instructing Reimbursement Agent Account.
    /// </summary>
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount40? InstructingReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Settlement Account.
    /// </summary>
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount40? SettlementAccount { get; init; }

    /// <summary>
    /// Settlement Method.
    /// </summary>
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <summary>
    /// Third Reimbursement Agent.
    /// </summary>
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification8? ThirdReimbursementAgent { get; init; }

    /// <summary>
    /// Third Reimbursement Agent Account.
    /// </summary>
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount40? ThirdReimbursementAgentAccount { get; init; }
}
