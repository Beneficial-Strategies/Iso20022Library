// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[IsoId("_UBgzITqrEeWyoP0PbocV1Q")]
[DisplayName("Acknowledgement Reason")]
public record AcknowledgementReason10
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_UhM_wTqrEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AcknowledgementReason13Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UhM_yTqrEeWyoP0PbocV1Q")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
