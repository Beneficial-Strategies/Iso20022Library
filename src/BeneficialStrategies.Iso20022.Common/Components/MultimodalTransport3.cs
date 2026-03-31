// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to multimodal transportation of goods.
/// </summary>
[IsoId("_StCMANp-Ed-ak6NoX_4Aeg_1369687043")]
[DisplayName("Multimodal Transport")]
public record MultimodalTransport3
{
    /// <summary>
    /// Identifies the location where the goods are take in charge for transportation.
    /// </summary>
    [IsoId("_StCMAdp-Ed-ak6NoX_4Aeg_1369687683")]
    [DisplayName("Taking In Charge")]
    [IsoXmlTag("TakngInChrg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TakingInCharge { get; init; }

    /// <summary>
    /// Identifies the location of the final destination of the goods.
    /// </summary>
    [IsoId("_StL9ANp-Ed-ak6NoX_4Aeg_1369687605")]
    [DisplayName("Place Of Final Destination")]
    [IsoXmlTag("PlcOfFnlDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PlaceOfFinalDestination { get; init; }
}
