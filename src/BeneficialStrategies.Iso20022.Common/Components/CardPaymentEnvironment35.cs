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
/// Environment of the cancellation.
/// </summary>
[IsoId("__O7xYWl3EeSQMKir9owD5A")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment35
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment35 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment35( PointOfInteraction4 reqPOI,PaymentCard11 reqCard )
    {
        POI = reqPOI;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("__c578Wl3EeSQMKir9owD5A")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer4? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer4? Acquirer { get; init; } 
    #else
    public Acquirer4? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment cancellation.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("__c6jAWl3EeSQMKir9owD5A")]
    [DisplayName("Merchant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrchnt")]
    #endif
    [IsoXmlTag("Mrchnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation8? Merchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation8? Merchant { get; init; } 
    #else
    public Organisation8? Merchant { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("__c6jA2l3EeSQMKir9owD5A")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteraction4 POI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteraction4 POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction4 POI { get; init; } 
    #else
    public PointOfInteraction4 POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("__c6jBWl3EeSQMKir9owD5A")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard11 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCard11 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard11 Card { get; init; } 
    #else
    public PaymentCard11 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    [IsoId("_CN3LMGl5EeSQMKir9owD5A")]
    [DisplayName("Customer Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDvc")]
    #endif
    [IsoXmlTag("CstmrDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? CustomerDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? CustomerDevice { get; init; } 
    #else
    public CustomerDevice1? CustomerDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_FWNcMGl5EeSQMKir9owD5A")]
    [DisplayName("Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wllt")]
    #endif
    [IsoXmlTag("Wllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? Wallet { get; init; } 
    #else
    public CustomerDevice1? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_NPqEsGl5EeSQMKir9owD5A")]
    [DisplayName("Payment Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTkn")]
    #endif
    [IsoXmlTag("PmtTkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentToken3? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentToken3? PaymentToken { get; init; } 
    #else
    public CardPaymentToken3? PaymentToken { get; set; } 
    #endif
    
    
    #nullable disable
    
}
