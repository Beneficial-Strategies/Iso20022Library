// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status of a creditor enrolment.
/// </summary>
[IsoId("_UalrzeH7Eeqbls7Gk4-ckA")]
[DisplayName("Enrolment Status")]
public record EnrolmentStatus2
{
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_Ub7vk-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Provides detailed information on the status for the request.
    /// </summary>
    [IsoId("_Ub7vleH7Eeqbls7Gk4-ckA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ServiceStatus1Choice_ Status { get; init; }

    /// <summary>
    /// Specifies the reason for the status of the enrolment request.
    /// </summary>
    [IsoId("_Ub7vl-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public CreditorEnrolmentStatusReason2? StatusReason { get; init; }

    /// <summary>
    /// Provides the original creditor enrolment data.
    /// </summary>
    [IsoId("_Ub7vmeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment Reference")]
    [IsoXmlTag("OrgnlEnrlmntRef")]
    public OriginalEnrolment2Choice_? OriginalEnrolmentReference { get; init; }

    /// <summary>
    /// Actual date when the creditor enrolment was executed.
    /// </summary>
    [IsoId("_Ub7vm-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Effective Enrolment Date")]
    [IsoXmlTag("FctvEnrlmntDt")]
    public DateAndDateTime2Choice_? EffectiveEnrolmentDate { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ub7vneH7Eeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
