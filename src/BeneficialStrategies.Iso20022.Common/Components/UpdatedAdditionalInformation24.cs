// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Updated Additional Information24.
/// </summary>
[IsoId("_U_8eo3SdEe6VWZz2tTgENw")]
[DisplayName("Updated Additional Information24")]
public record UpdatedAdditionalInformation24
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public required IsoRestrictedFINXMax350Text AdditionalInformation { get; init; }

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISO2ALanguageCode Language { get; init; }
}
