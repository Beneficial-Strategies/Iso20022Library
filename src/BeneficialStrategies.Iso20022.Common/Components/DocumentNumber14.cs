// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document.
/// </summary>
[IsoId("_8QbAo5NLEeWGlc8L7oPDIg")]
[DisplayName("Document Number")]
public record DocumentNumber14
{
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_8QbApZNLEeWGlc8L7oPDIg")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber6Choice_ Number { get; init; }
}
