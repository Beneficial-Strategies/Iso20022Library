// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the availability of a service.
/// </summary>
[IsoId("_bU4edtEWEeWfZsLg1wugTw")]
[DisplayName("Service Availability")]
public partial record ServiceAvailability1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the applicable business service.
    /// </summary>
    [IsoId("_bU4eetEWEeWfZsLg1wugTw")]
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessService { get; init; } 
    
    /// <summary>
    /// Status of service availability.
    /// </summary>
    [IsoId("_bU4eeNEWEeWfZsLg1wugTw")]
    [DisplayName("Availability Status")]
    [IsoXmlTag("AvlbtySts")]
    public required SystemEventType3Choice_ AvailabilityStatus { get; init; } 
    
    
    #nullable disable
    
}
