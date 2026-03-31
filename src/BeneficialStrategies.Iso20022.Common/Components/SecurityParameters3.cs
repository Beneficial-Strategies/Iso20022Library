// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters related to the security of software application and application protocol.
/// </summary>
[IsoId("_6u86AWpyEeSMqvBfBY1c9A")]
[DisplayName("Security Parameters")]
public record SecurityParameters3
{
    /// <summary>
    /// Version of the security parameters.
    /// </summary>
    [IsoId("_H-_MsGpzEeSMqvBfBY1c9A")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_67xOAWpyEeSMqvBfBY1c9A")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_67xOA2pyEeSMqvBfBY1c9A")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Key to inject in the point of interaction, protected by the temporary key previously sent.
    /// </summary>
    [IsoId("_67xOBWpyEeSMqvBfBY1c9A")]
    [DisplayName("Symmetric Key")]
    [IsoXmlTag("SmmtrcKey")]
    public ValueList<CryptographicKey5> SymmetricKey { get; init; } = [];
}
