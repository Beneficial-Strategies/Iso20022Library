// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Transmit Response message.
/// </summary>
[IsoId("_EFdOMN7JEeiwsev40qZGEQ")]
[DisplayName("Device Transmit Message Response")]
public record DeviceTransmitMessageResponse1
{
    /// <summary>
    /// Content of a transmitted message.
    /// </summary>
    [IsoId("_LIz8MN7JEeiwsev40qZGEQ")]
    [DisplayName("Received Message")]
    [IsoXmlTag("RcvdMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? ReceivedMessage { get; init; }
}
