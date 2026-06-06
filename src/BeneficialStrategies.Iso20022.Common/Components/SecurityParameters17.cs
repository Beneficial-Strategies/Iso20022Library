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
[IsoId("_WbiaUbZzEfCUZfsQO4rYeA")]
[DisplayName("Security Parameters17")]
public record SecurityParameters17
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_WcdAVbZzEfCUZfsQO4rYeA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Version of the security parameters.
    /// </summary>
    [IsoId("_WcdAW7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_WcdAYbZzEfCUZfsQO4rYeA")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_WcdAZ7ZzEfCUZfsQO4rYeA")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Key to inject in the point of interaction, protected by the temporary key previously sent.
    /// </summary>
    [IsoId("_WcdAbbZzEfCUZfsQO4rYeA")]
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public ValueList<CryptographicKey19> SecurityElement { get; init; } = [];
}
