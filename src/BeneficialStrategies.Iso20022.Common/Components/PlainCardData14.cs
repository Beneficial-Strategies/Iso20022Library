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
[IsoId("_qvjwYYp3EeS3NqNpgnMh2w")]
[DisplayName("Plain Card Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PlainCardData14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card.
    /// </summary>
    [IsoId("_q77YcYp3EeS3NqNpgnMh2w")]
    [DisplayName("PAN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PAN")]
    #endif
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin8Max28NumericText? PAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PAN { get; init; } 
    #else
    public System.String? PAN { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a card or a payment token inside a set of cards with the same PAN.
    /// </summary>
    [IsoId("_q77Yc4p3EeS3NqNpgnMh2w")]
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
    [IsoId("_q77YdYp3EeS3NqNpgnMh2w")]
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
    [IsoId("_q77Yd4p3EeS3NqNpgnMh2w")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExpiryDate { get; init; } 
    #else
    public System.String? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Track number 1 from magnetic stripe card.
    /// </summary>
    [IsoId("_q77Ye4p3EeS3NqNpgnMh2w")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck1")]
    #endif
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Track1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track1 { get; init; } 
    #else
    public System.String? Track1 { get; set; } 
    #endif
    
    /// <summary>
    /// Track number 2 without control characters (start /end and LRC).
    /// </summary>
    [IsoId("_VPch4OmCEeSYo5PXsuJwzw")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck2")]
    #endif
    [IsoXmlTag("Trck2")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Track2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track2 { get; init; } 
    #else
    public System.String? Track2 { get; set; } 
    #endif
    
    /// <summary>
    /// Track number 3 from magnetic stripe card.
    /// </summary>
    [IsoId("_q77Yf4p3EeS3NqNpgnMh2w")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck3")]
    #endif
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Track3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track3 { get; init; } 
    #else
    public System.String? Track3 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
