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
[IsoId("_FGh4YN7DEeiwsev40qZGEQ")]
[DisplayName("Device Input Notification")]
public record DeviceInputNotification1
{
    /// <summary>
    /// Message main identifier.
    /// </summary>
    [IsoId("_J-FdMN7DEeiwsev40qZGEQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    [IsoId("_Pm9xQN7DEeiwsev40qZGEQ")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage6 OutputContent { get; init; }
}
