// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creditor Enrolment Cancellation3.
/// </summary>
[IsoId("_0hm1ETEyEe6g-ffJsqGiSA")]
[DisplayName("Creditor Enrolment Cancellation3")]
public record CreditorEnrolmentCancellation3
{
    /// <summary>
    /// Cancellation Reason.
    /// </summary>
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public CreditorEnrolmentCancellationReason3? CancellationReason { get; init; }

    /// <summary>
    /// Original Business Instruction.
    /// </summary>
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Original Enrolment.
    /// </summary>
    [DisplayName("Original Enrolment")]
    [IsoXmlTag("OrgnlEnrlmnt")]
    public required OriginalEnrolment3Choice_ OriginalEnrolment { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
