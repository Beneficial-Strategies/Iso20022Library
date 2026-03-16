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
[IsoId("_UJ2hEeH7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Amendment")]
public record DebtorActivationAmendment3
{
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_ULMk4eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_ULMk4-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public DebtorActivationAmendmentReason2? AmendmentReason { get; init; }

    /// <summary>
    /// Provides the amended enrolment data.
    /// </summary>
    [IsoId("_ULMk5eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public required DebtorActivationAmendment4 Amendment { get; init; }

    /// <summary>
    /// Provides the original activation data.
    /// </summary>
    [IsoId("_ULMk5-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation")]
    [IsoXmlTag("OrgnlActvtn")]
    public required OriginalActivation2Choice_ OriginalActivation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ULMk6eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
