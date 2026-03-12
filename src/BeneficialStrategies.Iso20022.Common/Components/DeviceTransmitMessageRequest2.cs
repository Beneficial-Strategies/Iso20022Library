// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Request message to transmit.
/// </summary>
[IsoId("_Hi8mMQ0sEeqUVL7sB4m7NA")]
[DisplayName("Device Transmit Message Request")]
public partial record DeviceTransmitMessageRequest2
{
    #nullable enable
    
    /// <summary>
    /// Transport address.
    /// </summary>
    [IsoId("_H1Mz0Q0sEeqUVL7sB4m7NA")]
    [DisplayName("Destination Address")]
    [IsoXmlTag("DstnAdr")]
    public required NetworkParameters7 DestinationAddress { get; init; } 
    
    /// <summary>
    /// Maximum time in seconds of transmission.
    /// </summary>
    [IsoId("_H1Mz0w0sEeqUVL7sB4m7NA")]
    [DisplayName("Maximum Transmission Time")]
    [IsoXmlTag("MaxTrnsmssnTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber MaximumTransmissionTime { get; init; } 
    
    /// <summary>
    /// Defines the timeout to receive an answer.
    /// </summary>
    [IsoId("_H1Mz1Q0sEeqUVL7sB4m7NA")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumWaitingTime { get; init; } 
    
    /// <summary>
    /// Content of the message to be transmitted.
    /// </summary>
    [IsoId("_H1Mz1w0sEeqUVL7sB4m7NA")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public required IsoMax100KBinary MessageToSend { get; init; } 
    
    
    #nullable disable
    
}
