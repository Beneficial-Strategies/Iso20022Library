// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_UWPlhdp-Ed-ak6NoX_4Aeg_1328386787")]
[DisplayName("Acknowledgement Reason")]
public record AcknowledgementReason2
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_UWPlhtp-Ed-ak6NoX_4Aeg_1506505459")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AcknowledgementReason3Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UWPlh9p-Ed-ak6NoX_4Aeg_331314434")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
