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
[IsoId("_UVy5kNp-Ed-ak6NoX_4Aeg_-49973351")]
[DisplayName("Rejection Reason")]
public record RejectionReason6
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    [IsoId("_UVy5kdp-Ed-ak6NoX_4Aeg_-1173856121")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RejectionReason2Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UVy5ktp-Ed-ak6NoX_4Aeg_1194869738")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
