// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point of interaction (POI) performing the transaction.
/// </summary>
[IsoId("_y7NhQAyUEeK5P9Ihqok3VA")]
[DisplayName("Point Of Interaction")]
public record PointOfInteraction2
{
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_zIHU0QyUEeK5P9Ihqok3VA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; }

    /// <summary>
    /// Common name assigned by the acquirer to the POI system.
    /// </summary>
    [IsoId("_zIHU1QyUEeK5P9Ihqok3VA")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SystemName { get; init; }

    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_zIH74AyUEeK5P9Ihqok3VA")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GroupIdentification { get; init; }

    /// <summary>
    /// Capabilities of the POI performing the transaction.
    /// </summary>
    [IsoId("_zIH75AyUEeK5P9Ihqok3VA")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities1? Capabilities { get; init; }

    /// <summary>
    /// Data related to a component of the POI performing the transaction.
    /// </summary>
    [IsoId("_zIH76AyUEeK5P9Ihqok3VA")]
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public PointOfInteractionComponent3? Component { get; init; }
}
