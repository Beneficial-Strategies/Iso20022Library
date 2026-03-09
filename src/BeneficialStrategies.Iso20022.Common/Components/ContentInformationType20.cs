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
/// General cryptographic message syntax (CMS) containing encrypted data.
/// </summary>
[IsoId("_fP-osaQuEeeWXKXf3KjtmQ")]
[DisplayName("Content Information Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContentInformationType20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContentInformationType20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContentInformationType20( MACData1 reqMACData,System.String reqMAC )
    {
        MACData = reqMACData;
        MAC = reqMAC;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// ISO 8583:87 bit 53 or 110
    /// ISO 8583:93 bit 53 or 111
    /// ISO 8583:2003 bit 53 or 50
    /// </summary>
    [IsoId("_fblbwaQuEeeWXKXf3KjtmQ")]
    [DisplayName("MAC Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MACData")]
    #endif
    [IsoXmlTag("MACData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MACData1 MACData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MACData1 MACData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MACData1 MACData { get; init; } 
    #else
    public MACData1 MACData { get; set; } 
    #endif
    
    /// <summary>
    /// Message Authentication Code data.
    /// Binary, length of 8
    /// ISO 8583 bit 64 or bit 128
    /// </summary>
    [IsoId("_fblbw6QuEeeWXKXf3KjtmQ")]
    [DisplayName("MAC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MAC")]
    #endif
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max8HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax8HexBinaryText MAC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MAC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MAC { get; init; } 
    #else
    public System.String MAC { get; set; } 
    #endif
    
    
    #nullable disable
    
}
