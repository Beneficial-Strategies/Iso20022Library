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
/// Environment of the reconciliation exchange.
/// </summary>
[IsoId("_TDwwwwEcEeCQm6a_G2yO_w_-1497481893")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment7( Acquirer1 reqAcquirer )
    {
        Acquirer = reqAcquirer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment reconciliation.
    /// </summary>
    [IsoId("_TDwwxAEcEeCQm6a_G2yO_w_915910768")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Acquirer1 Acquirer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Acquirer1 Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer1 Acquirer { get; init; } 
    #else
    public Acquirer1 Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the merchant requesting the reconciliation.
    /// </summary>
    [IsoId("_TDwwxQEcEeCQm6a_G2yO_w_-210812803")]
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
    /// Identification of the POI requesting the reconciliation.
    /// </summary>
    [IsoId("_TDwwxgEcEeCQm6a_G2yO_w_-221911580")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? POIIdentification { get; init; } 
    #else
    public GenericIdentification32? POIIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
