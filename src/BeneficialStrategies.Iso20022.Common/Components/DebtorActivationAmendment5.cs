// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Debtor Activation Amendment5.
/// </summary>
[IsoId("_wa3CITEyEe6g-ffJsqGiSA")]
[DisplayName("Debtor Activation Amendment5")]
public record DebtorActivationAmendment5
{
    /// <summary>
    /// Amendment.
    /// </summary>
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public required DebtorActivationAmendment6 Amendment { get; init; }

    /// <summary>
    /// Amendment Reason.
    /// </summary>
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public DebtorActivationAmendmentReason3? AmendmentReason { get; init; }

    /// <summary>
    /// Original Activation.
    /// </summary>
    [DisplayName("Original Activation")]
    [IsoXmlTag("OrgnlActvtn")]
    public required OriginalActivation3Choice_ OriginalActivation { get; init; }

    /// <summary>
    /// Original Business Instruction.
    /// </summary>
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
