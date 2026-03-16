// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed description of an error that caused the message to be corrected/amended. Transmitted for further analysis.
/// </summary>
[IsoId("_fOv6QFW5EeeiG_nL4vgKnQ")]
[DisplayName("Detailed Error")]
public record DetailedError1
{
    /// <summary>
    /// Type of error corrected or amendment brought to the message.
    /// </summary>
    [IsoId("_31-HoFW5EeeiG_nL4vgKnQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Detailed description of the error or amendment.
    /// </summary>
    [IsoId("_-4ERYFW5EeeiG_nL4vgKnQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public required IsoMax500Text Description { get; init; }

    /// <summary>
    /// Contains the modified value.
    /// </summary>
    [IsoId("__lVpEGdsEem-ycRQGen_YA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Value { get; init; }
}
