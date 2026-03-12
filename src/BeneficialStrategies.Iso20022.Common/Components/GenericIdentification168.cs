// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification using a proprietary scheme.
/// </summary>
[IsoId("_lZuBYchkEeadgvwNGwK05w")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification168
{
    #nullable enable
    
    /// <summary>
    /// Proprietary code that uniquely identifies the object or subject of interest.
    /// </summary>
    [IsoId("_liHvc8hkEeadgvwNGwK05w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Identification { get; init; } 
    
    /// <summary>
    /// Human readable full name of the identifier.
    /// </summary>
    [IsoId("_liHvdchkEeadgvwNGwK05w")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_liHvd8hkEeadgvwNGwK05w")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_liHvechkEeadgvwNGwK05w")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; } 
    
    
    #nullable disable
    
}
