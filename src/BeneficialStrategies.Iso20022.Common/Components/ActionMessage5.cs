// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message to be displayed to the cardholder or the cashier.
/// </summary>
[IsoId("_t9yQoY0lEeWzoK7sd7oTyw")]
[DisplayName("Action Message")]
public record ActionMessage5
{
    /// <summary>
    /// Format of the content.
    /// </summary>
    [IsoId("_Ic0UMI0mEeWzoK7sd7oTyw")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat1Code? Format { get; init; }

    /// <summary>
    /// Text or graphic data to be display or printed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_uJtMw40lEeWzoK7sd7oTyw")]
    [DisplayName("Message Content")]
    [IsoXmlTag("MsgCntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public required IsoMax20000Text MessageContent { get; init; }
}
