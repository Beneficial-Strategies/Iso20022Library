// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Card Reader Application Protocol Data Unit Response message.
/// </summary>
[IsoId("_W5rM4N6iEeiwsev40qZGEQ")]
[DisplayName("Device Send Application Protocol Data Unit Card Reader Response")]
public record DeviceSendApplicationProtocolDataUnitCardReaderResponse1
{
    /// <summary>
    /// Class field of the Application Protocol Data Unit command (CLA).
    /// </summary>
    [IsoId("_yAfMsN6jEeiwsev40qZGEQ")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public IsoMin1Max256Binary? Data { get; init; }

    /// <summary>
    /// Status of a smartcard response to a command (SW1-SW2). Reference: ISO 7816-4.
    /// </summary>
    [IsoId("_BQhBMN6kEeiwsev40qZGEQ")]
    [DisplayName("Card Status")]
    [IsoXmlTag("CardSts")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public required IsoMin1Max256Binary CardStatus { get; init; }
}
