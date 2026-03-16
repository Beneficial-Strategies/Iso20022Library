// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Instruction16.
/// </summary>
[IsoId("_x_3RFTEyEe6g-ffJsqGiSA")]
[DisplayName("Settlement Instruction16")]
public record SettlementInstruction16
{
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
}
