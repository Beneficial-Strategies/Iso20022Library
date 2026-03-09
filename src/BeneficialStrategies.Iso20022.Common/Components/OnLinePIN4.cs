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
/// Encrypted personal identification number (PIN) and related information.
/// </summary>
[IsoId("_amingWjPEeSHBr6v3XO0Mg")]
[DisplayName("On Line PIN")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OnLinePIN4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OnLinePIN4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OnLinePIN4( ContentInformationType10 reqEncryptedPINBlock,PINFormat3Code reqPINFormat )
    {
        EncryptedPINBlock = reqEncryptedPINBlock;
        PINFormat = reqPINFormat;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Encrypted PIN (Personal Identification Number).
    /// </summary>
    [IsoId("_a0GiYWjPEeSHBr6v3XO0Mg")]
    [DisplayName("Encrypted PIN Block")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdPINBlck")]
    #endif
    [IsoXmlTag("NcrptdPINBlck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType10 EncryptedPINBlock { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType10 EncryptedPINBlock { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10 EncryptedPINBlock { get; init; } 
    #else
    public ContentInformationType10 EncryptedPINBlock { get; set; } 
    #endif
    
    /// <summary>
    /// PIN (Personal Identification Number) format before encryption.
    /// </summary>
    [IsoId("_a0GiY2jPEeSHBr6v3XO0Mg")]
    [DisplayName("PIN Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINFrmt")]
    #endif
    [IsoXmlTag("PINFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PINFormat3Code PINFormat { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PINFormat3Code PINFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PINFormat3Code PINFormat { get; init; } 
    #else
    public PINFormat3Code PINFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information required to verify the PIN (Personal Identification Number).
    /// </summary>
    [IsoId("_a0GiZWjPEeSHBr6v3XO0Mg")]
    [DisplayName("Additional Input")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInpt")]
    #endif
    [IsoXmlTag("AddtlInpt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalInput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInput { get; init; } 
    #else
    public System.String? AdditionalInput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
