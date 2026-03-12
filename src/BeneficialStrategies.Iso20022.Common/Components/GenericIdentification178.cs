// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification expressed as a proprietary type and narrative description.
/// </summary>
[IsoId("_ZXt_c08DEeqsYJJSZey7Rw")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification178
{
    #nullable enable
    
    /// <summary>
    /// Identification of the lot, according to a data source scheme. Used to indicate which processing to apply to the corresponding market value amount.
    /// </summary>
    [IsoId("_ZXt_dU8DEeqsYJJSZey7Rw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_ZXt_dE8DEeqsYJJSZey7Rw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
