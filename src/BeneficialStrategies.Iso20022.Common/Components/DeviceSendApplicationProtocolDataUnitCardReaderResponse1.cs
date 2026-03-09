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
/// Content of the Card Reader Application Protocol Data Unit Response message.
/// </summary>
[IsoId("_W5rM4N6iEeiwsev40qZGEQ")]
[DisplayName("Device Send Application Protocol Data Unit Card Reader Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceSendApplicationProtocolDataUnitCardReaderResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceSendApplicationProtocolDataUnitCardReaderResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1( System.Byte[] reqCardStatus )
    {
        CardStatus = reqCardStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Class field of the Application Protocol Data Unit command (CLA).
    /// </summary>
    [IsoId("_yAfMsN6jEeiwsev40qZGEQ")]
    [DisplayName("Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Data")]
    #endif
    [IsoXmlTag("Data")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin1Max256Binary? Data { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Data { get; init; } 
    #else
    public System.Byte[]? Data { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a smartcard response to a command (SW1-SW2). Reference: ISO 7816-4.
    /// </summary>
    [IsoId("_BQhBMN6kEeiwsev40qZGEQ")]
    [DisplayName("Card Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSts")]
    #endif
    [IsoXmlTag("CardSts")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin1Max256Binary CardStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] CardStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] CardStatus { get; init; } 
    #else
    public System.Byte[] CardStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
