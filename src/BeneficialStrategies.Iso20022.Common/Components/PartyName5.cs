// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Name5.
/// </summary>
[IsoId("_LgUjYZNmEe6o4eAdwsHaow")]
[DisplayName("Party Name5")]
public partial record PartyName5
{
    #nullable enable

    /// <summary>
    /// International.
    /// </summary>
    [DisplayName("International")]
    [IsoXmlTag("Intrnl")]
    public IsoTrueFalseIndicator? International { get; init; } 

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; } 

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required IsoMax500Text Value { get; init; } 

    
    #nullable disable
    
}
