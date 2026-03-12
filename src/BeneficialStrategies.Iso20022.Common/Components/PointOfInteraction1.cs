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
[IsoId("_TGSgUwEcEeCQm6a_G2yO_w_-296140444")]
[DisplayName("Point Of Interaction")]
public partial record PointOfInteraction1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_TGSgVAEcEeCQm6a_G2yO_w_-207441180")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; } 
    
    /// <summary>
    /// Common name assigned by the acquirer to the POI system.
    /// </summary>
    [IsoId("_TGSgVQEcEeCQm6a_G2yO_w_-1099975138")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SystemName { get; init; } 
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_TGSgVgEcEeCQm6a_G2yO_w_1185035300")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GroupIdentification { get; init; } 
    
    /// <summary>
    /// Capabilities of the POI performing the transaction.
    /// </summary>
    [IsoId("_TGSgVwEcEeCQm6a_G2yO_w_-1178938770")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities1? Capabilities { get; init; } 
    
    /// <summary>
    /// Data related to a component of the POI performing the transaction.
    /// </summary>
    [IsoId("_TGSgWAEcEeCQm6a_G2yO_w_-844354331")]
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public PointOfInteractionComponent1? Component { get; init; } 
    
    
    #nullable disable
    
}
