// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example party identification or account identification.
/// </summary>
[IsoId("_XP8qYWEUEe2P-L9DBerEgA")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification185
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    [IsoId("_XQzmAWEUEe2P-L9DBerEgA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public required IsoMax100Text Identification { get; init; } 
    
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_XQzmA2EUEe2P-L9DBerEgA")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_XQzmBWEUEe2P-L9DBerEgA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
