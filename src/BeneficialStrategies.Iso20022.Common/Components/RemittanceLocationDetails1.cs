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
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_IcMu4aJxEeK9W_i6uXeloA")]
[DisplayName("Remittance Location Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceLocationDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RemittanceLocationDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RemittanceLocationDetails1( RemittanceLocationMethod2Code reqMethod )
    {
        Method = reqMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_IpKM2aJxEeK9W_i6uXeloA")]
    [DisplayName("Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtd")]
    #endif
    [IsoXmlTag("Mtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RemittanceLocationMethod2Code Method { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RemittanceLocationMethod2Code Method { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceLocationMethod2Code Method { get; init; } 
    #else
    public RemittanceLocationMethod2Code Method { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_IpKM3aJxEeK9W_i6uXeloA")]
    [DisplayName("Electronic Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncAdr")]
    #endif
    [IsoXmlTag("ElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? ElectronicAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ElectronicAddress { get; init; } 
    #else
    public System.String? ElectronicAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_IpKM4aJxEeK9W_i6uXeloA")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress10? PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress10? PostalAddress { get; init; } 
    #else
    public NameAndAddress10? PostalAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
