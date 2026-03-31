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
[IsoId("__pmdsTw9EeW3QqUkIQtIUA")]
[DisplayName("Denied Reason")]
public record DeniedReason12
{
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    [IsoId("_AKouITw-EeW3QqUkIQtIUA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DeniedReason17Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_AKouKTw-EeW3QqUkIQtIUA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
