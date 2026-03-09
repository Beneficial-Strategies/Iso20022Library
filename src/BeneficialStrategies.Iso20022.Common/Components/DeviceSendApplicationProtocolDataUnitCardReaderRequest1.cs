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
/// Content of the Card Reader Application Protocol Data Unit Request message.
/// </summary>
[IsoId("_m22qMN7BEeiwsev40qZGEQ")]
[DisplayName("Device Send Application Protocol Data Unit Card Reader Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceSendApplicationProtocolDataUnitCardReaderRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceSendApplicationProtocolDataUnitCardReaderRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1( System.Byte[] reqClass,System.Byte[] reqInstruction,System.Byte[] reqParameter1,System.Byte[] reqParameter2 )
    {
        Class = reqClass;
        Instruction = reqInstruction;
        Parameter1 = reqParameter1;
        Parameter2 = reqParameter2;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Class field of the Application Protocol Data Unit command (CLA).
    /// </summary>
    [IsoId("_sVzmMN7BEeiwsev40qZGEQ")]
    [DisplayName("Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clss")]
    #endif
    [IsoXmlTag("Clss")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin1Max256Binary Class { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Class { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Class { get; init; } 
    #else
    public System.Byte[] Class { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction field of the Application Protocol Data Unit command (INS).
    /// </summary>
    [IsoId("_u3PoMN7BEeiwsev40qZGEQ")]
    [DisplayName("Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instr")]
    #endif
    [IsoXmlTag("Instr")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin1Max256Binary Instruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Instruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Instruction { get; init; } 
    #else
    public System.Byte[] Instruction { get; set; } 
    #endif
    
    /// <summary>
    /// Parameter 1 field of the Application Protocol Data Unit command
    /// </summary>
    [IsoId("_xNyBwN7BEeiwsev40qZGEQ")]
    [DisplayName("Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Param1")]
    #endif
    [IsoXmlTag("Param1")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin1Max256Binary Parameter1 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Parameter1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Parameter1 { get; init; } 
    #else
    public System.Byte[] Parameter1 { get; set; } 
    #endif
    
    /// <summary>
    /// Parameter 2 field of the Application Protocol Data Unit command
    /// </summary>
    [IsoId("_0qCoEe15Eei-V5h0ja04AA")]
    [DisplayName("Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Param2")]
    #endif
    [IsoXmlTag("Param2")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin1Max256Binary Parameter2 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Parameter2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Parameter2 { get; init; } 
    #else
    public System.Byte[] Parameter2 { get; set; } 
    #endif
    
    /// <summary>
    /// Data field of the Application Protocol Data Unit command to send including the length.
    /// </summary>
    [IsoId("_APE2sN7CEeiwsev40qZGEQ")]
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
    /// Expected length of the data field of the Application Protocol Data Unit response to the command.
    /// </summary>
    [IsoId("_DORLsN7CEeiwsev40qZGEQ")]
    [DisplayName("Expected Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdLngth")]
    #endif
    [IsoXmlTag("XpctdLngth")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin1Max256Binary? ExpectedLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ExpectedLength { get; init; } 
    #else
    public System.Byte[]? ExpectedLength { get; set; } 
    #endif
    
    
    #nullable disable
    
}
