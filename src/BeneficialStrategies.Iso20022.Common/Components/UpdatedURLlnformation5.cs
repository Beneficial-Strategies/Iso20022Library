// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information with update description and date.
/// </summary>
[IsoId("_x_GL6R9REeuFz_FaCzCLgQ")]
[DisplayName("Updated UR Llnformation")]
public record UpdatedURLlnformation5
{
    /// <summary>
    /// Language used to provide additional information and using the ISO 639-1 language code standard.
    /// </summary>
    [IsoId("_x_GL6x9REeuFz_FaCzCLgQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISO2ALanguageCode Language { get; init; }

    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_x_GL7R9REeuFz_FaCzCLgQ")]
    [DisplayName("Update Description")]
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? UpdateDescription { get; init; }

    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_x_GL7x9REeuFz_FaCzCLgQ")]
    [DisplayName("Update Date")]
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UpdateDate { get; init; }

    /// <summary>
    /// Provides the web address, that is, the address for the Universal Resource Locator (URL), to use over the www (HTTP) service where additional information may be found.
    /// </summary>
    [IsoId("_x_GL8R9REeuFz_FaCzCLgQ")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINZMax2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public required IsoRestrictedFINZMax2048Text URLAddress { get; init; }
}
