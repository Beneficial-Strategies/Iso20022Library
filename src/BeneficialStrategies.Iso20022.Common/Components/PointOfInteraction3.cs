// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point of interaction (POI) performing the transaction.
/// </summary>
[IsoId("_n7YRoS9SEeOlZIh7PImd0A")]
[DisplayName("Point Of Interaction")]
public partial record PointOfInteraction3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_oMCj0S9SEeOlZIh7PImd0A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; } 
    
    /// <summary>
    /// Common name assigned by the acquirer to the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_oMCj0y9SEeOlZIh7PImd0A")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SystemName { get; init; } 
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set ofPOI (Point Of Interaction) terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_oMCj1S9SEeOlZIh7PImd0A")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GroupIdentification { get; init; } 
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_oMCj1y9SEeOlZIh7PImd0A")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities2? Capabilities { get; init; } 
    
    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_oMCj2S9SEeOlZIh7PImd0A")]
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public PointOfInteractionComponent4? Component { get; init; } 
    
    
    #nullable disable
    
}
