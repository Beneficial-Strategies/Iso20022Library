// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the financial institution sending the request.
/// </summary>
[IsoId("_Su5UAQEcEeCQm6a_G2yO_w_1332252059")]
[DisplayName("Requestor Details")]
public partial record RequestorDetails1
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the request was created.
    /// </summary>
    [IsoId("_Su5UAgEcEeCQm6a_G2yO_w_-991672194")]
    [DisplayName("Date Time Stamp")]
    [IsoXmlTag("DtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTimeStamp { get; init; } 
    
    /// <summary>
    /// Identification of the requester.
    /// </summary>
    [IsoId("_Su5UAwEcEeCQm6a_G2yO_w_1407581183")]
    [DisplayName("Requestor")]
    [IsoXmlTag("Rqstr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier Requestor { get; init; } 
    
    
    #nullable disable
    
}
