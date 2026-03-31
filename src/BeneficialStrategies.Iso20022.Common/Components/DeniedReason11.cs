// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the request or instruction was denied.
/// </summary>
[IsoId("_t0nF4Ts8EeWRTLSN0i0tng")]
[DisplayName("Denied Reason")]
public record DeniedReason11
{
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    [IsoId("_uWhgETs8EeWRTLSN0i0tng")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DeniedReason16Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_uWhgGTs8EeWRTLSN0i0tng")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
