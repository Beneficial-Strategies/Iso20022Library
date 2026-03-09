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
/// Provides additional details on the remittance advice.
/// </summary>
[IsoId("_-LRmB24-EeiU9cctagi5ow")]
[DisplayName("Remittance Location Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceLocationData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RemittanceLocationData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RemittanceLocationData1( RemittanceLocationMethod2Code reqMethod )
    {
        Method = reqMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_-VaZcW4-EeiU9cctagi5ow")]
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
    [IsoId("_-VaZc24-EeiU9cctagi5ow")]
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
    [IsoId("_-VaZdW4-EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress16? PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress16? PostalAddress { get; init; } 
    #else
    public NameAndAddress16? PostalAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
