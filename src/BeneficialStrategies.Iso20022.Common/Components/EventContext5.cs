// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the context when the event occured.
/// </summary>
[IsoId("_dckHYXJcEe299ZbWCkdR_w")]
[DisplayName("Event Context")]
public partial record EventContext5
{
    #nullable enable
    
    /// <summary>
    /// Reference to the service and functions related to the event.
    /// </summary>
    [IsoId("_djufUXJcEe299ZbWCkdR_w")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required RetailerService1Code ServiceType { get; init; } 
    
    /// <summary>
    /// Identification of the Point Of Interaction.
    /// </summary>
    [IsoId("_djufU3JcEe299ZbWCkdR_w")]
    [DisplayName("Component Identification")]
    [IsoXmlTag("CmpntId")]
    public PointOfInteractionComponent14? ComponentIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the Sale System.
    /// </summary>
    [IsoId("_djufVXJcEe299ZbWCkdR_w")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; } 
    
    
    #nullable disable
    
}
