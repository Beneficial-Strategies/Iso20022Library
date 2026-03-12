// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the jurisdiction (country, county, state, province, city).
/// </summary>
[IsoId("_hZ8L12liEeGaMcKyqKNRfQ_-1193651870")]
[DisplayName("Jurisdiction")]
public partial record Jurisdiction1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the jurisdiction (county, state, province, city).
    /// </summary>
    [IsoId("_hZ8L2GliEeGaMcKyqKNRfQ_-1543399295")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Identification { get; init; } 
    
    /// <summary>
    /// Specifies the country.
    /// </summary>
    [IsoId("_hZ8L2WliEeGaMcKyqKNRfQ_801858830")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
