// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details to identify a creditor enrolment to be amended and the new amended data.
/// </summary>
[IsoId("_zv3-heH5Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Amendment")]
public record CreditorEnrolmentAmendment3
{
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_zxUwAeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_zxUwA-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public CreditorEnrolmentAmendmentReason2? AmendmentReason { get; init; }

    /// <summary>
    /// Provides the amended enrolment data.
    /// </summary>
    [IsoId("_zxUwBeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public required CreditorEnrolmentAmendment4 Amendment { get; init; }

    /// <summary>
    /// Provides the original enrolment data.
    /// </summary>
    [IsoId("_zxUwB-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment")]
    [IsoXmlTag("OrgnlEnrlmnt")]
    public required OriginalEnrolment2Choice_ OriginalEnrolment { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_zxUwCeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
