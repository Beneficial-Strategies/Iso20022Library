// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the reservation details
/// </summary>
[IsoId("_tCvU1PPiEeihCvvpsmGI2w")]
[DisplayName("Reservation Details")]
public partial record ReservationDetails3
{
    #nullable enable
    
    /// <summary>
    /// Computerised reservation system used to make the reservation and purchase the ticket.
    /// </summary>
    [IsoId("_tCvU1_PiEeihCvvpsmGI2w")]
    [DisplayName("System")]
    [IsoXmlTag("Sys")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? System { get; init; } 
    
    /// <summary>
    /// Value that uniquely identifies the reservation. 
    /// </summary>
    [IsoId("_tCvU1vPiEeihCvvpsmGI2w")]
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReservationNumber { get; init; } 
    
    /// <summary>
    /// System code that identifies the original reservation system used to make the reservation and purchase the ticket. 
    /// </summary>
    [IsoId("_tCvU1fPiEeihCvvpsmGI2w")]
    [DisplayName("Original System")]
    [IsoXmlTag("OrgnlSys")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? OriginalSystem { get; init; } 
    
    /// <summary>
    /// Value that identifies the original reservation generated during the original reservation and purchase of the ticket. 
    /// </summary>
    [IsoId("_1YJEEfPjEeihCvvpsmGI2w")]
    [DisplayName("Original Reservation Number")]
    [IsoXmlTag("OrgnlRsvatnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalReservationNumber { get; init; } 
    
    
    #nullable disable
    
}
