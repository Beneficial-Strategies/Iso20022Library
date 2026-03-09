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
[IsoId("_E51JoWiyEeS87LmvcA55sg")]
[DisplayName("Plain Card Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PlainCardData7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PlainCardData7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PlainCardData7( System.String reqPAN,System.String reqExpiryDate )
    {
        PAN = reqPAN;
        ExpiryDate = reqExpiryDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card, or surrogate of the PAN by a payment token.
    /// </summary>
    [IsoId("_FG3gEWiyEeS87LmvcA55sg")]
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
    /// Identify a card or a payment token inside a set of cards with the same PAN or token.
    /// </summary>
    [IsoId("_FG3gE2iyEeS87LmvcA55sg")]
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
    [IsoId("_FG3gFWiyEeS87LmvcA55sg")]
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
    /// Expiry date of the card or the payment token expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_FG3gF2iyEeS87LmvcA55sg")]
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
    [IsoId("_FG3gGWiyEeS87LmvcA55sg")]
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
    /// Track issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The track value might be provided by a payment token.
    /// </summary>
    [IsoId("_FG3gG2iyEeS87LmvcA55sg")]
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
    /// Name of the cardholder stored on the card.
    /// </summary>
    [IsoId("_l0PVMGiyEeS87LmvcA55sg")]
    [DisplayName("Cardholder Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrNm")]
    #endif
    [IsoXmlTag("CrdhldrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax45Text? CardholderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardholderName { get; init; } 
    #else
    public System.String? CardholderName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
