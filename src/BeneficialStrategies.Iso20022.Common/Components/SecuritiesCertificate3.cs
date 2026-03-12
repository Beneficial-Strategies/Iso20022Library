// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical representation of a security.
/// </summary>
[IsoId("_A0iQxdokEeC60axPepSq7g_90527686")]
[DisplayName("Securities Certificate")]
public partial record SecuritiesCertificate3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_A0rasNokEeC60axPepSq7g_-201430052")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_A0rasdokEeC60axPepSq7g_-906544667")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_A0rastokEeC60axPepSq7g_-1903617020")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; } 
    
    
    #nullable disable
    
}
