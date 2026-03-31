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
[IsoId("_yJDK7QarEe2phaVG0lYKTw")]
[DisplayName("Rejection Reason")]
public record RejectionReason67
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected status.
    /// </summary>
    [IsoId("_yZlhQAarEe2phaVG0lYKTw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RejectionReason52Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_yZlhSAarEe2phaVG0lYKTw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
