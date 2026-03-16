// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The capabilities of the display components performing the transaction.
/// </summary>
[IsoId("_OdbxQS9KEeOlZIh7PImd0A")]
[DisplayName("Display Capabilities")]
public record DisplayCapabilities2
{
    /// <summary>
    /// Type of display (for example merchant or cardholder).
    /// </summary>
    [IsoId("_Ot8ScS9KEeOlZIh7PImd0A")]
    [DisplayName("Display Type")]
    [IsoXmlTag("DispTp")]
    public required UserInterface2Code DisplayType { get; init; }

    /// <summary>
    /// Number of lines of the display component.
    /// </summary>
    [IsoId("_Ot8Scy9KEeOlZIh7PImd0A")]
    [DisplayName("Number Of Lines")]
    [IsoXmlTag("NbOfLines")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfLines { get; init; }

    /// <summary>
    /// Number of columns of the display component.
    /// </summary>
    [IsoId("_Ot8SdS9KEeOlZIh7PImd0A")]
    [DisplayName("Line Width")]
    [IsoXmlTag("LineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber LineWidth { get; init; }
}
