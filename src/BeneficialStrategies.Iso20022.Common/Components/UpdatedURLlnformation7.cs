// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Updated UR Llnformation7.
/// </summary>
[IsoId("_U_vEJXSdEe6VWZz2tTgENw")]
[DisplayName("Updated UR Llnformation7")]
public partial record UpdatedURLlnformation7
{
    #nullable enable

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISO2ALanguageCode Language { get; init; } 

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public required IsoRestrictedFINZMax2048Text URLAddress { get; init; } 

    
    #nullable disable
    
}
