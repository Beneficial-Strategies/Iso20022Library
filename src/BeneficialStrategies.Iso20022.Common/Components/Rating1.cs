// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Assessment of securities credit and investment risk.
/// </summary>
[IsoId("_S1iAuNp-Ed-ak6NoX_4Aeg_-610008315")]
[DisplayName("Rating")]
public partial record Rating1
{
    #nullable enable
    
    /// <summary>
    /// Information regarding the entity that assigns the rating.
    /// </summary>
    [IsoId("_S1iAudp-Ed-ak6NoX_4Aeg_-1436888380")]
    [DisplayName("Rating Scheme")]
    [IsoXmlTag("RatgSchme")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RatingScheme { get; init; } 
    
    /// <summary>
    /// Date/time as from which the rating is valid.
    /// </summary>
    [IsoId("_S1iAutp-Ed-ak6NoX_4Aeg_-1436888328")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ValueDate { get; init; } 
    
    /// <summary>
    /// Specifies the rating, which has been assigned to a security by a rating agency.
    /// </summary>
    [IsoId("_S1iAu9p-Ed-ak6NoX_4Aeg_-1436888268")]
    [DisplayName("Value Identification")]
    [IsoXmlTag("ValId")]
    [IsoSimpleType(IsoSimpleType.RatingValueIdentifier)]
    public required IsoRatingValueIdentifier ValueIdentification { get; init; } 
    
    
    #nullable disable
    
}
