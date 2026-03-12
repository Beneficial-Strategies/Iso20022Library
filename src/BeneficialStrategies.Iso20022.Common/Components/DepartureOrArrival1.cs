// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains departure or arrival information.
/// </summary>
[IsoId("_vgLY5PPoEeihCvvpsmGI2w")]
[DisplayName("Departure Or Arrival")]
public partial record DepartureOrArrival1
{
    #nullable enable
    
    /// <summary>
    /// Departure or arrival location (for example, city, airport code, station id, etc). 
    /// </summary>
    [IsoId("_vgLY5_PoEeihCvvpsmGI2w")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Location { get; init; } 
    
    /// <summary>
    /// Specific explanation of the location or directions. 
    /// </summary>
    [IsoId("_e_szsfPpEeihCvvpsmGI2w")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; } 
    
    /// <summary>
    /// Departure or arrival date.
    /// </summary>
    [IsoId("_vgLY5vPoEeihCvvpsmGI2w")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Departure or arrival time. 
    /// </summary>
    [IsoId("_vgLY5fPoEeihCvvpsmGI2w")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; } 
    
    
    #nullable disable
    
}
