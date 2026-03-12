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
[IsoId("_cdRpTZKQEeWHWpTQn1FFVg")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification84
{
    #nullable enable
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_cdRpUZKQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax34Text)]
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax34Text Identification { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_cdRpU5KQEeWHWpTQn1FFVg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText Issuer { get; init; } 
    
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_cdRpVZKQEeWHWpTQn1FFVg")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    
    
    #nullable disable
    
}
