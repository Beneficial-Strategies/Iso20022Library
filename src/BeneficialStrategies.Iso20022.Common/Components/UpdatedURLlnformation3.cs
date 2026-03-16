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
[IsoId("_c5XIRZKQEeWHWpTQn1FFVg")]
[DisplayName("Updated UR Llnformation")]
public record UpdatedURLlnformation3
{
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_c5XIR5KQEeWHWpTQn1FFVg")]
    [DisplayName("Update Description")]
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? UpdateDescription { get; init; }

    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_c5XISZKQEeWHWpTQn1FFVg")]
    [DisplayName("Update Date")]
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UpdateDate { get; init; }

    /// <summary>
    /// Provides the web address, that is, the address for the Universal Resource Locator (URL), to use over the www (HTTP) service where additional information may be found.
    /// </summary>
    [IsoId("_c5XIS5KQEeWHWpTQn1FFVg")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINZMax256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoRestrictedFINZMax256Text URLAddress { get; init; }
}
