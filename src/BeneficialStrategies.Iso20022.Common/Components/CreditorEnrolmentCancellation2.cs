// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the creditor enrolment to be cancelled.
/// </summary>
[IsoId("_UedfLeH7Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Cancellation")]
public record CreditorEnrolmentCancellation2
{
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_Ufpx8eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_Ufpx8-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public CreditorEnrolmentCancellationReason2? CancellationReason { get; init; }

    /// <summary>
    /// Provides the original creditor enrolment data.
    /// </summary>
    [IsoId("_Ufpx9eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment")]
    [IsoXmlTag("OrgnlEnrlmnt")]
    public required OriginalEnrolment2Choice_ OriginalEnrolment { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ufpx9-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
