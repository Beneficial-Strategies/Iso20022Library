// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to log.
/// </summary>
[IsoId("_TqzxMYO6EeSWSLYdc10LRg")]
[DisplayName("Action Message")]
public record ActionMessage3
{
    /// <summary>
    /// Destination of the information.
    /// </summary>
    [IsoId("_T37AIYO6EeSWSLYdc10LRg")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public required UserInterface3Code Destination { get; init; }

    /// <summary>
    /// Format of the content.
    /// </summary>
    [IsoId("_T37AI4O6EeSWSLYdc10LRg")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat1Code? Format { get; init; }

    /// <summary>
    /// Content of the information.
    /// </summary>
    [IsoId("_T37AJYO6EeSWSLYdc10LRg")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public required IsoMax20000Text Content { get; init; }
}
