// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the detailed attributes of a standing order.
/// </summary>
[IsoId("_COWPVW4-EeiU9cctagi5ow")]
[DisplayName("Standing Order Report")]
public partial record StandingOrderReport1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_CZ-QgW4-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Identification")]
    [IsoXmlTag("StgOrdrId")]
    public required StandingOrderIdentification4 StandingOrderIdentification { get; init; } 
    
    /// <summary>
    /// Requested information on the standing order or business error when information has not been found.
    /// </summary>
    [IsoId("_CZ-Qg24-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Or Error")]
    [IsoXmlTag("StgOrdrOrErr")]
    public required StandingOrderOrError6Choice_ StandingOrderOrError { get; init; } 
    
    
    #nullable disable
    
}
