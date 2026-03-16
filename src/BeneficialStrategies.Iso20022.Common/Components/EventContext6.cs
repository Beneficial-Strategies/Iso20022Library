// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event Context6.
/// </summary>
[IsoId("_XNUGYZHvEe6qwqnYOGEReg")]
[DisplayName("Event Context6")]
public partial record EventContext6
{
    #nullable enable

    /// <summary>
    /// Component Identification.
    /// </summary>
    [DisplayName("Component Identification")]
    [IsoXmlTag("CmpntId")]
    public PointOfInteractionComponent15? ComponentIdentification { get; init; } 

    /// <summary>
    /// Sale Identification.
    /// </summary>
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    public IsoMax35Text? SaleIdentification { get; init; } 

    /// <summary>
    /// Service Type.
    /// </summary>
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required RetailerService1Code ServiceType { get; init; } 

    
    #nullable disable
    
}
