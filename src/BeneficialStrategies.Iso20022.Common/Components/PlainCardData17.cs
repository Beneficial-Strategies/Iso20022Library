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
/// Sensitive data associated with a payment card.
/// </summary>
[IsoId("_GIIq4ZbhEeW6aPG6p-lhQQ")]
[DisplayName("Plain Card Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PlainCardData17
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
    [IsoId("_GUNYAZbhEeW6aPG6p-lhQQ")]
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
    /// ISO track 1 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_GUNYC5bhEeW6aPG6p-lhQQ")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck1")]
    #endif
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max76Text)]
    [StringLength(maximumLength: 76 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax76Text? Track1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track1 { get; init; } 
    #else
    public System.String? Track1 { get; set; } 
    #endif
    
    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_GUNYDZbhEeW6aPG6p-lhQQ")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck2")]
    #endif
    [IsoXmlTag("Trck2")]
    [IsoSimpleType(IsoSimpleType.Max37Text)]
    [StringLength(maximumLength: 37 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax37Text? Track2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track2 { get; init; } 
    #else
    public System.String? Track2 { get; set; } 
    #endif
    
    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_GUNYD5bhEeW6aPG6p-lhQQ")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck3")]
    #endif
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max104Text)]
    [StringLength(maximumLength: 104 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax104Text? Track3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track3 { get; init; } 
    #else
    public System.String? Track3 { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_TnrZMJbhEeW6aPG6p-lhQQ")]
    [DisplayName("Additional Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCardData")]
    #endif
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalCardData { get; init; } 
    #else
    public System.String? AdditionalCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Entry mode of the card.
    /// </summary>
    [IsoId("_Rs9WUJdMEeWhUvuI1bSHSA")]
    [DisplayName("Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryMd")]
    #endif
    [IsoXmlTag("NtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading5Code? EntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading5Code? EntryMode { get; init; } 
    #else
    public CardDataReading5Code? EntryMode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
