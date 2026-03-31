// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input notification message.
/// </summary>
[IsoId("_cLmfgQ0cEeqUVL7sB4m7NA")]
[DisplayName("Device Input Notification")]
public record DeviceInputNotification2
{
    /// <summary>
    /// Message main identifier.
    /// </summary>
    [IsoId("_cW37YQ0cEeqUVL7sB4m7NA")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    [IsoId("_cW4icQ0cEeqUVL7sB4m7NA")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage7 OutputContent { get; init; }
}
