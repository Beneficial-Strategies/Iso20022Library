// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Updated UR Llnformation7.
/// </summary>
[IsoId("_U_vEJXSdEe6VWZz2tTgENw")]
[DisplayName("Updated UR Llnformation7")]
public record UpdatedURLlnformation7
{
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
}
