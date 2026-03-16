// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Enrolment Status3.
/// </summary>
[IsoId("_w_CtQTEyEe6g-ffJsqGiSA")]
[DisplayName("Enrolment Status3")]
public record EnrolmentStatus3
{
    /// <summary>
    /// Effective Enrolment Date.
    /// </summary>
    [DisplayName("Effective Enrolment Date")]
    [IsoXmlTag("FctvEnrlmntDt")]
    public DateAndDateTime2Choice_? EffectiveEnrolmentDate { get; init; }

    /// <summary>
    /// Original Business Instruction.
    /// </summary>
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Original Enrolment Reference.
    /// </summary>
    [DisplayName("Original Enrolment Reference")]
    [IsoXmlTag("OrgnlEnrlmntRef")]
    public OriginalEnrolment3Choice_? OriginalEnrolmentReference { get; init; }

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ServiceStatus1Choice_ Status { get; init; }

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public CreditorEnrolmentStatusReason3? StatusReason { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
