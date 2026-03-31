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
[IsoId("_89qrcUAlEeWE6OHCSJh8BQ")]
[DisplayName("Document Number")]
public record DocumentNumber13
{
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_9PiekUAlEeWE6OHCSJh8BQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber5Choice_ Number { get; init; }
}
