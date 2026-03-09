// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Request message to transmit.
/// </summary>
[IsoId("_Hi8mMQ0sEeqUVL7sB4m7NA")]
[DisplayName("Device Transmit Message Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceTransmitMessageRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceTransmitMessageRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceTransmitMessageRequest2( NetworkParameters7 reqDestinationAddress,System.UInt64 reqMaximumTransmissionTime,System.Byte[] reqMessageToSend )
    {
        DestinationAddress = reqDestinationAddress;
        MaximumTransmissionTime = reqMaximumTransmissionTime;
        MessageToSend = reqMessageToSend;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Transport address.
    /// </summary>
    [IsoId("_H1Mz0Q0sEeqUVL7sB4m7NA")]
    [DisplayName("Destination Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnAdr")]
    #endif
    [IsoXmlTag("DstnAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetworkParameters7 DestinationAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetworkParameters7 DestinationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters7 DestinationAddress { get; init; } 
    #else
    public NetworkParameters7 DestinationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum time in seconds of transmission.
    /// </summary>
    [IsoId("_H1Mz0w0sEeqUVL7sB4m7NA")]
    [DisplayName("Maximum Transmission Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxTrnsmssnTm")]
    #endif
    [IsoXmlTag("MaxTrnsmssnTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber MaximumTransmissionTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 MaximumTransmissionTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 MaximumTransmissionTime { get; init; } 
    #else
    public System.UInt64 MaximumTransmissionTime { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the timeout to receive an answer.
    /// </summary>
    [IsoId("_H1Mz1Q0sEeqUVL7sB4m7NA")]
    [DisplayName("Maximum Waiting Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxWtgTm")]
    #endif
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumWaitingTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumWaitingTime { get; init; } 
    #else
    public System.UInt64? MaximumWaitingTime { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the message to be transmitted.
    /// </summary>
    [IsoId("_H1Mz1w0sEeqUVL7sB4m7NA")]
    [DisplayName("Message To Send")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgToSnd")]
    #endif
    [IsoXmlTag("MsgToSnd")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax100KBinary MessageToSend { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] MessageToSend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] MessageToSend { get; init; } 
    #else
    public System.Byte[] MessageToSend { get; set; } 
    #endif
    
    
    #nullable disable
    
}
