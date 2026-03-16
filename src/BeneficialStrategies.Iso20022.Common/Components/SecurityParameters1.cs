// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point of interaction parameters related to the security of software application and application protocol.
/// </summary>
[IsoId("_fY5xUCm2EeKIjpr--01h3Q")]
[DisplayName("Security Parameters")]
public record SecurityParameters1
{
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_uKXagCm2EeKIjpr--01h3Q")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_3IMRICm2EeKIjpr--01h3Q")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Key to inject in the point of interaction, protected by the temporary key previously sent.
    /// </summary>
    [IsoId("_A04Y4Cm3EeKIjpr--01h3Q")]
    [DisplayName("Symmetric Key")]
    [IsoXmlTag("SmmtrcKey")]
    public ValueList<CryptographicKey2> SymmetricKey { get; init; } = [];
}
