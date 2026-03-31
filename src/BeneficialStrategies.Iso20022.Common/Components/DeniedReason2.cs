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
[IsoId("_UUc1wdp-Ed-ak6NoX_4Aeg_1944988880")]
[DisplayName("Denied Reason")]
public record DeniedReason2
{
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    [IsoId("_UUc1wtp-Ed-ak6NoX_4Aeg_2123107552")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DeniedReason2Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UUc1w9p-Ed-ak6NoX_4Aeg_947916527")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
