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
[IsoId("_rYBqYXIUEe2OqYulmHWukQ")]
[DisplayName("Security Parameters")]
public record SecurityParameters15
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_re0O4XIUEe2OqYulmHWukQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Version of the security parameters.
    /// </summary>
    [IsoId("_re0O43IUEe2OqYulmHWukQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_re0O5XIUEe2OqYulmHWukQ")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_re0O53IUEe2OqYulmHWukQ")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Key to inject in the point of interaction, protected by the temporary key previously sent.
    /// </summary>
    [IsoId("_re0O6XIUEe2OqYulmHWukQ")]
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public ValueList<CryptographicKey17> SecurityElement { get; init; } = [];
}
