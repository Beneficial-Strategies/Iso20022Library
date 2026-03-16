// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point Of Interaction14.
/// </summary>
[IsoId("_pyVCEZHhEe6qwqnYOGEReg")]
[DisplayName("Point Of Interaction14")]
public partial record PointOfInteraction14
{
    #nullable enable

    /// <summary>
    /// Capabilities.
    /// </summary>
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities9? Capabilities { get; init; } 

    /// <summary>
    /// Component.
    /// </summary>
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public ValueList<PointOfInteractionComponent15> Component { get; init; } = [];

    /// <summary>
    /// Group Identification.
    /// </summary>
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    public IsoMax35Text? GroupIdentification { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification177 Identification { get; init; } 

    /// <summary>
    /// System Name.
    /// </summary>
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    public IsoMax70Text? SystemName { get; init; } 

    /// <summary>
    /// Terminal Integration.
    /// </summary>
    [DisplayName("Terminal Integration")]
    [IsoXmlTag("TermnlIntgtn")]
    public LocationCategory3Code? TerminalIntegration { get; init; } 

    /// <summary>
    /// Time Zone.
    /// </summary>
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; } 

    
    #nullable disable
    
}
