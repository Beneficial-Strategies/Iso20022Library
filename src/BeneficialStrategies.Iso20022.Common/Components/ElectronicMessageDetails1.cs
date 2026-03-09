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
/// Summary of electronic message details.
/// </summary>
[IsoId("_kmUEIAepEeaA3oFk37UuZA")]
[DisplayName("Electronic Message Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ElectronicMessageDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ElectronicMessageDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ElectronicMessageDetails1( System.String reqElectronicSystemInformationMessageIdentifier )
    {
        ElectronicSystemInformationMessageIdentifier = reqElectronicSystemInformationMessageIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information about separate electronic system information message.
    /// </summary>
    [IsoId("_cxD_sBa-Eea0P4Zamlsl-Q")]
    [DisplayName("Electronic System Information Message Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncSysInfMsgIdr")]
    #endif
    [IsoXmlTag("ElctrncSysInfMsgIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ElectronicSystemInformationMessageIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ElectronicSystemInformationMessageIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ElectronicSystemInformationMessageIdentifier { get; init; } 
    #else
    public System.String ElectronicSystemInformationMessageIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Information about packet of electronic system messages.
    /// </summary>
    [IsoId("_w6t1kBa-Eea0P4Zamlsl-Q")]
    [DisplayName("Electronic System Information Message Packet Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncSysInfMsgPacketIdr")]
    #endif
    [IsoXmlTag("ElctrncSysInfMsgPacketIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ElectronicSystemInformationMessagePacketIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ElectronicSystemInformationMessagePacketIdentifier { get; init; } 
    #else
    public System.String? ElectronicSystemInformationMessagePacketIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
