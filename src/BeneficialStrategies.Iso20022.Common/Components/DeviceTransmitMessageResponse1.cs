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
/// Content of the Transmit Response message.
/// </summary>
[IsoId("_EFdOMN7JEeiwsev40qZGEQ")]
[DisplayName("Device Transmit Message Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceTransmitMessageResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Content of a transmitted message.
    /// </summary>
    [IsoId("_LIz8MN7JEeiwsev40qZGEQ")]
    [DisplayName("Received Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdMsg")]
    #endif
    [IsoXmlTag("RcvdMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? ReceivedMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ReceivedMessage { get; init; } 
    #else
    public System.Byte[]? ReceivedMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
