// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the status being requested.
/// </summary>
[IsoId("_8RszjZNLEeWGlc8L7oPDIg")]
[DisplayName("Document Number")]
public record DocumentNumber15
{
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_8RszkZNLEeWGlc8L7oPDIg")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber6Choice_ Number { get; init; }

    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_8RszmZNLEeWGlc8L7oPDIg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<Identification24> References { get; init; } = [];
    // ID for the above is _8RszmZNLEeWGlc8L7oPDIg
}
