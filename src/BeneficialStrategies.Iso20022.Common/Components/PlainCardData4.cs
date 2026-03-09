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
/// Sensible data associated with the payment card performing the transaction.
/// </summary>
[IsoId("_2Gul8S9mEeOlZIh7PImd0A")]
[DisplayName("Plain Card Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PlainCardData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PlainCardData4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PlainCardData4( System.String reqPAN,System.String reqExpiryDate )
    {
        PAN = reqPAN;
        ExpiryDate = reqExpiryDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card, or card number.
    /// </summary>
    [IsoId("_2XsaIS9mEeOlZIh7PImd0A")]
    [DisplayName("PAN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PAN")]
    #endif
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin8Max28NumericText PAN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PAN { get; init; } 
    #else
    public System.String PAN { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a card inside a set of cards with the same card number (PAN).
    /// </summary>
    [IsoId("_2XsaIy9mEeOlZIh7PImd0A")]
    [DisplayName("Card Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSeqNb")]
    #endif
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardSequenceNumber { get; init; } 
    #else
    public System.String? CardSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date from which the card can be used, expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_2XsaJS9mEeOlZIh7PImd0A")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EffectiveDate { get; init; } 
    #else
    public System.String? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Expiry date of the card expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_2XsaJy9mEeOlZIh7PImd0A")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10Text ExpiryDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExpiryDate { get; init; } 
    #else
    public System.String ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [IsoId("_2XsaKS9mEeOlZIh7PImd0A")]
    [DisplayName("Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCd")]
    #endif
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? ServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceCode { get; init; } 
    #else
    public System.String? ServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Magnetic track or equivalent payment card data.
    /// </summary>
    [IsoId("_2XsaKy9mEeOlZIh7PImd0A")]
    [DisplayName("Track Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckData")]
    #endif
    [IsoXmlTag("TrckData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackData1? TrackData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackData1? TrackData { get; init; } 
    #else
    public TrackData1? TrackData { get; set; } 
    #endif
    
    /// <summary>
    /// Card security code (CSC) associated with the card performing the transaction.
    /// </summary>
    [IsoId("_2XsaLS9mEeOlZIh7PImd0A")]
    [DisplayName("Card Security Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSctyCd")]
    #endif
    [IsoXmlTag("CardSctyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardSecurityInformation1? CardSecurityCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardSecurityInformation1? CardSecurityCode { get; init; } 
    #else
    public CardSecurityInformation1? CardSecurityCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
