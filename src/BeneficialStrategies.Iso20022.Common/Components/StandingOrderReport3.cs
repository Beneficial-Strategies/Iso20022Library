// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Standing Order Report3.
/// </summary>
[IsoId("_z1rjNTEyEe6g-ffJsqGiSA")]
[DisplayName("Standing Order Report3")]
public record StandingOrderReport3
{
    /// <summary>
    /// Standing Order Identification.
    /// </summary>
    [DisplayName("Standing Order Identification")]
    [IsoXmlTag("StgOrdrId")]
    public required StandingOrderIdentification8 StandingOrderIdentification { get; init; }

    /// <summary>
    /// Standing Order Or Error.
    /// </summary>
    [DisplayName("Standing Order Or Error")]
    [IsoXmlTag("StgOrdrOrErr")]
    public required StandingOrderOrError10Choice_ StandingOrderOrError { get; init; }
}
