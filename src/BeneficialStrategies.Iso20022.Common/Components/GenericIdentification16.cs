// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a generic identification.
/// </summary>
[IsoId("_QAyBINp-Ed-ak6NoX_4Aeg_-296354008")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification16
{
    #nullable enable
    
    /// <summary>
    /// The identifier.
    /// </summary>
    [IsoId("_QAyBIdp-Ed-ak6NoX_4Aeg_-270494440")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the identifier.
    /// </summary>
    [IsoId("_QAyBItp-Ed-ak6NoX_4Aeg_-270494439")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required PersonIdentificationType3Choice_ IdentificationType { get; init; } 
    
    /// <summary>
    /// Party that assigns the identification.
    /// </summary>
    [IsoId("_QAyBI9p-Ed-ak6NoX_4Aeg_-270494410")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
