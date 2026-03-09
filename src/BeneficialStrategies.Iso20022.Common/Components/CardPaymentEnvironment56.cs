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
/// Environment of the transaction.
/// </summary>
[IsoId("_JA5r4Y3aEeW56qaqQ8B0kQ")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment56
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment56 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment56( PointOfInteraction5 reqPOI,PaymentCard21 reqCard )
    {
        POI = reqPOI;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_JMOyIY3aEeW56qaqQ8B0kQ")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification53? AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification53? AcquirerIdentification { get; init; } 
    #else
    public GenericIdentification53? AcquirerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant involved in the card payment transaction.
    /// </summary>
    [IsoId("_JMOyI43aEeW56qaqQ8B0kQ")]
    [DisplayName("Merchant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntId")]
    #endif
    [IsoXmlTag("MrchntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification53? MerchantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification53? MerchantIdentification { get; init; } 
    #else
    public GenericIdentification53? MerchantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_JMOyJY3aEeW56qaqQ8B0kQ")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteraction5 POI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteraction5 POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction5 POI { get; init; } 
    #else
    public PointOfInteraction5 POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_JMOyJ43aEeW56qaqQ8B0kQ")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard21 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCard21 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard21 Card { get; init; } 
    #else
    public PaymentCard21 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference: ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_JMOyKY3aEeW56qaqQ8B0kQ")]
    [DisplayName("Cardholder Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrLang")]
    #endif
    [IsoXmlTag("CrdhldrLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? CardholderLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CardholderLanguage { get; init; } 
    #else
    public string? CardholderLanguage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
