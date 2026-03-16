// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creditor Enrolment Amendment5.
/// </summary>
[IsoId("_zaajgTEyEe6g-ffJsqGiSA")]
[DisplayName("Creditor Enrolment Amendment5")]
public partial record CreditorEnrolmentAmendment5
{
    #nullable enable

    /// <summary>
    /// Amendment.
    /// </summary>
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public required CreditorEnrolmentAmendment6 Amendment { get; init; } 

    /// <summary>
    /// Amendment Reason.
    /// </summary>
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public CreditorEnrolmentAmendmentReason3? AmendmentReason { get; init; } 

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

    
    #nullable disable
    
}
