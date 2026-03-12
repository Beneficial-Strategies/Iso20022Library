// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides narrative information about an event and the language in which it is specified.
/// </summary>
[IsoId("_JmgaIfM-EeqRfth943bvEA")]
[DisplayName("Language Specified Narrative")]
public partial record LanguageSpecifiedNarrative1
{
    #nullable enable
    
    /// <summary>
    /// Language used to provide additional information and using the ISO 639-1 language code standard.
    /// </summary>
    [IsoId("_O-pHAfM_EeqRfth943bvEA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISO2ALanguageCode Language { get; init; } 
    
    /// <summary>
    /// Provides additional textual information in the specified language.
    /// </summary>
    [IsoId("_IV5RYfM_EeqRfth943bvEA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    [StringLength(maximumLength: 8000 ,MinimumLength = 1)]
    public required IsoMax8000Text AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
