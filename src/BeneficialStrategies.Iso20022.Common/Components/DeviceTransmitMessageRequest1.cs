// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Request message to transmit.
/// </summary>
[IsoId("_e2-0IN7CEeiwsev40qZGEQ")]
[DisplayName("Device Transmit Message Request")]
public record DeviceTransmitMessageRequest1
{
    /// <summary>
    /// Transport address.
    /// </summary>
    [IsoId("_wYXAMN7CEeiwsev40qZGEQ")]
    [DisplayName("Destination Address")]
    [IsoXmlTag("DstnAdr")]
    public required NetworkParameters5 DestinationAddress { get; init; }

    /// <summary>
    /// Maximum time in seconds of transmission.
    /// </summary>
    [IsoId("_3ja4sN7CEeiwsev40qZGEQ")]
    [DisplayName("Maximum Transmission Time")]
    [IsoXmlTag("MaxTrnsmssnTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber MaximumTransmissionTime { get; init; }

    /// <summary>
    /// Defines the timeout to receive an answer.
    /// </summary>
    [IsoId("_Xfnf0O16Eei-V5h0ja04AA")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumWaitingTime { get; init; }

    /// <summary>
    /// Content of the message to be transmitted.
    /// </summary>
    [IsoId("_-hlksN7CEeiwsev40qZGEQ")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public required IsoMax100KBinary MessageToSend { get; init; }
}
