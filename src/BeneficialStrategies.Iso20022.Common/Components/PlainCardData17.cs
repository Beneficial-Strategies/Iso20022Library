// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensitive data associated with a payment card.
/// </summary>
[IsoId("_GIIq4ZbhEeW6aPG6p-lhQQ")]
[DisplayName("Plain Card Data")]
public partial record PlainCardData17
{
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card.
    /// </summary>
    [IsoId("_GUNYAZbhEeW6aPG6p-lhQQ")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public IsoMin8Max28NumericText? PAN { get; init; } 
    
    /// <summary>
    /// ISO track 1 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_GUNYC5bhEeW6aPG6p-lhQQ")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max76Text)]
    [StringLength(maximumLength: 76 ,MinimumLength = 1)]
    public IsoMax76Text? Track1 { get; init; } 
    
    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_GUNYDZbhEeW6aPG6p-lhQQ")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck2")]
    [IsoSimpleType(IsoSimpleType.Max37Text)]
    [StringLength(maximumLength: 37 ,MinimumLength = 1)]
    public IsoMax37Text? Track2 { get; init; } 
    
    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_GUNYD5bhEeW6aPG6p-lhQQ")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max104Text)]
    [StringLength(maximumLength: 104 ,MinimumLength = 1)]
    public IsoMax104Text? Track3 { get; init; } 
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_TnrZMJbhEeW6aPG6p-lhQQ")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalCardData { get; init; } 
    
    /// <summary>
    /// Entry mode of the card.
    /// </summary>
    [IsoId("_Rs9WUJdMEeWhUvuI1bSHSA")]
    [DisplayName("Entry Mode")]
    [IsoXmlTag("NtryMd")]
    public CardDataReading5Code? EntryMode { get; init; } 
    
    
    #nullable disable
    
}
