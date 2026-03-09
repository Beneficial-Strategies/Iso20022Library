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
[IsoId("_BMczYS_6EeO4w-IWHJMI9g")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment20( PointOfInteraction3 reqPOI,PaymentCard7 reqCard )
    {
        POI = reqPOI;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_BbLy8S_6EeO4w-IWHJMI9g")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer2? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer2? Acquirer { get; init; } 
    #else
    public Acquirer2? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_BbLy8y_6EeO4w-IWHJMI9g")]
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
    [IsoId("_BbLy9S_6EeO4w-IWHJMI9g")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteraction3 POI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteraction3 POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction3 POI { get; init; } 
    #else
    public PointOfInteraction3 POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_BbLy9y_6EeO4w-IWHJMI9g")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard7 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCard7 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard7 Card { get; init; } 
    #else
    public PaymentCard7 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_BbLy-S_6EeO4w-IWHJMI9g")]
    [DisplayName("Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdhldr")]
    #endif
    [IsoXmlTag("Crdhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder5? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder5? Cardholder { get; init; } 
    #else
    public Cardholder5? Cardholder { get; set; } 
    #endif
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_jmvdUC_6EeO4w-IWHJMI9g")]
    [DisplayName("Protected Cardholder Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdCrdhldrData")]
    #endif
    [IsoXmlTag("PrtctdCrdhldrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType7? ProtectedCardholderData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType7? ProtectedCardholderData { get; init; } 
    #else
    public ContentInformationType7? ProtectedCardholderData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
