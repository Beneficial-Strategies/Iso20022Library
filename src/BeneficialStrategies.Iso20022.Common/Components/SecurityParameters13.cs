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
[IsoId("_iymGQS8iEeu125Ip9zFcsQ")]
[DisplayName("Security Parameters")]
public record SecurityParameters13
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_jBon0S8iEeu125Ip9zFcsQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Version of the security parameters.
    /// </summary>
    [IsoId("_jBon0y8iEeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_jBon1S8iEeu125Ip9zFcsQ")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_jBon1y8iEeu125Ip9zFcsQ")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Key to inject in the point of interaction, protected by the temporary key previously sent.
    /// </summary>
    [IsoId("_jBon2S8iEeu125Ip9zFcsQ")]
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public ValueList<CryptographicKey15> SecurityElement { get; init; } = [];
}
