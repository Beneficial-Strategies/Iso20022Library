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
/// Environment of the diagnostic exchange.
/// </summary>
[IsoId("_TDwwxwEcEeCQm6a_G2yO_w_-51855289")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment8( System.DateTime reqAcquirerParametersVersion,GenericIdentification32 reqPOIIdentification )
    {
        AcquirerParametersVersion = reqAcquirerParametersVersion;
        POIIdentification = reqPOIIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the payment application configuration parameters of the POI.
    /// </summary>
    [IsoId("_TDwwyAEcEeCQm6a_G2yO_w_-1444736902")]
    [DisplayName("Acquirer Parameters Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrParamsVrsn")]
    #endif
    [IsoXmlTag("AcqrrParamsVrsn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime AcquirerParametersVersion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime AcquirerParametersVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime AcquirerParametersVersion { get; init; } 
    #else
    public System.DateTime AcquirerParametersVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_TDwwyQEcEeCQm6a_G2yO_w_-1440704983")]
    [DisplayName("Merchant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntId")]
    #endif
    [IsoXmlTag("MrchntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? MerchantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? MerchantIdentification { get; init; } 
    #else
    public GenericIdentification32? MerchantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI requesting the diagnostic.
    /// </summary>
    [IsoId("_TDwwygEcEeCQm6a_G2yO_w_-1830436847")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 POIIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification32 POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 POIIdentification { get; init; } 
    #else
    public GenericIdentification32 POIIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
