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
/// Acceptor parameters dedicated to the merchant.
/// </summary>
[IsoId("_m-dkUGptEeSMqvBfBY1c9A")]
[DisplayName("Merchant Configuration Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MerchantConfigurationParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MerchantConfigurationParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MerchantConfigurationParameters1( System.String reqVersion,System.Byte[] reqParameters )
    {
        Version = reqVersion;
        Parameters = reqParameters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the merchant for the MTM, if the POI manages several merchants.
    /// </summary>
    [IsoId("_1I9UIGptEeSMqvBfBY1c9A")]
    [DisplayName("Merchant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntId")]
    #endif
    [IsoXmlTag("MrchntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MerchantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantIdentification { get; init; } 
    #else
    public System.String? MerchantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the merchant parameters.
    /// </summary>
    [IsoId("_9oWiUGptEeSMqvBfBY1c9A")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Version { get; init; } 
    #else
    public System.String Version { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant parameters.
    /// </summary>
    [IsoId("_CqXqsGpuEeSMqvBfBY1c9A")]
    [DisplayName("Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Params")]
    #endif
    [IsoXmlTag("Params")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10000Binary Parameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Parameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Parameters { get; init; } 
    #else
    public System.Byte[] Parameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
