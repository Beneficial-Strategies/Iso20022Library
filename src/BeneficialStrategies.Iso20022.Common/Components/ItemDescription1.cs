// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Language, title and textual description in the specified language of an item.
/// </summary>
[IsoId("_22xaAPM8EeqRfth943bvEA")]
[DisplayName("Item Description")]
public partial record ItemDescription1
{
    #nullable enable
    
    /// <summary>
    /// Language used to provide a description of the item and specified in the ISO 639-1 language code standard.
    /// </summary>
    [IsoId("_slMcgfM8EeqRfth943bvEA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISO2ALanguageCode Language { get; init; } 
    
    /// <summary>
    /// Abbreviated description of the item.
    /// </summary>
    [IsoId("_VNTTkfM9EeqRfth943bvEA")]
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Title { get; init; } 
    
    /// <summary>
    /// Free textual description of the item in the specified language.
    /// </summary>
    [IsoId("_sWfcsfM9EeqRfth943bvEA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? Description { get; init; } 
    
    
    #nullable disable
    
}
