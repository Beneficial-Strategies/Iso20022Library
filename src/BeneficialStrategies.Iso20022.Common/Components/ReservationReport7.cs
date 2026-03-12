// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the reservation or on a business error.
/// </summary>
[IsoId("_eJZtZdcZEeqRFcf2R4bPBw")]
[DisplayName("Reservation Report")]
public partial record ReservationReport7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the reservation on which information is requested.
    /// </summary>
    [IsoId("_eK5iMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Identification")]
    [IsoXmlTag("RsvatnId")]
    public required ReservationIdentification3 ReservationIdentification { get; init; } 
    
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_eK5iM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Or Error")]
    [IsoXmlTag("RsvatnOrErr")]
    public required ReservationOrError9Choice_ ReservationOrError { get; init; } 
    
    
    #nullable disable
    
}
