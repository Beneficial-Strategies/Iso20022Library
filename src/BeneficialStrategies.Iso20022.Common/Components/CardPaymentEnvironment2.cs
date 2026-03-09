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
[IsoId("_TEqIqgEcEeCQm6a_G2yO_w_1274559508")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment2( PointOfInteraction1 reqPOI,PaymentCard3 reqCard )
    {
        POI = reqPOI;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_TEqIqwEcEeCQm6a_G2yO_w_2038625206")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer1? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer1? Acquirer { get; init; } 
    #else
    public Acquirer1? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_TEqIrAEcEeCQm6a_G2yO_w_83386860")]
    [DisplayName("Merchant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrchnt")]
    #endif
    [IsoXmlTag("Mrchnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation5? Merchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation5? Merchant { get; init; } 
    #else
    public Organisation5? Merchant { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_TEqIrQEcEeCQm6a_G2yO_w_1518975286")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteraction1 POI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteraction1 POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction1 POI { get; init; } 
    #else
    public PointOfInteraction1 POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_TEqIrgEcEeCQm6a_G2yO_w_183210541")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard3 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCard3 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard3 Card { get; init; } 
    #else
    public PaymentCard3 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_TEqIrwEcEeCQm6a_G2yO_w_-1992737319")]
    [DisplayName("Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdhldr")]
    #endif
    [IsoXmlTag("Crdhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder2? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder2? Cardholder { get; init; } 
    #else
    public Cardholder2? Cardholder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
