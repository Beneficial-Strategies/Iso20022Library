// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
[IsoId("_TWMJsTNMEeylu6lH-gut-A")]
[DisplayName("Local Data")]
public partial record LocalData9
{
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_Tc-HITNMEeylu6lH-gut-A")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; } 
    
    /// <summary>
    /// Contains generic text message in local language.
    /// </summary>
    [IsoId("_fXKBMDNMEeylu6lH-gut-A")]
    [DisplayName("Text Message")]
    [IsoXmlTag("TxtMsg")]
    [IsoSimpleType(IsoSimpleType.Max40KText)]
    [StringLength(maximumLength: 40000 ,MinimumLength = 1)]
    public required IsoMax40KText TextMessage { get; init; } 
    
    
    #nullable disable
    
}
