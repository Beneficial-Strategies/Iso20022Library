// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the content of the input notification message.
/// </summary>
[IsoId("_g2_5IbZeEfCUZfsQO4rYeA")]
[DisplayName("Device Input Notification7")]
public record DeviceInputNotification7
{
    /// <summary>
    /// Message main identifier.
    /// </summary>
    [IsoId("_g4DpFbZeEfCUZfsQO4rYeA")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    [IsoId("_g4DpG7ZeEfCUZfsQO4rYeA")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage12 OutputContent { get; init; }
}
