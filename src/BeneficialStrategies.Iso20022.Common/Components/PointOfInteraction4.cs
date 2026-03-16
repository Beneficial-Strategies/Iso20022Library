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
[IsoId("_aCHc4WiwEeS87LmvcA55sg")]
[DisplayName("Point Of Interaction")]
public record PointOfInteraction4
{
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_aP298WiwEeS87LmvcA55sg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; }

    /// <summary>
    /// Common name assigned by the acquirer to the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_aP2982iwEeS87LmvcA55sg")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SystemName { get; init; }

    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI (Point Of Interaction) terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_aP299WiwEeS87LmvcA55sg")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GroupIdentification { get; init; }

    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_aP2992iwEeS87LmvcA55sg")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities3? Capabilities { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_aP29-WiwEeS87LmvcA55sg")]
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public ValueList<PointOfInteractionComponent5> Component { get; init; } = [];
}
