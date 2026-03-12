// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity that has delivered or declined the card payment authorisation (the party may be unidentified).
/// </summary>
[IsoId("_tgIE0R1EEey8XKHwKquEQw")]
[DisplayName("Approval Entity")]
public partial record ApprovalEntity2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// ISO 8583:93/2003 bit 58
    /// </summary>
    [IsoId("_tmM3oR1EEey8XKHwKquEQw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Type of entity having declined or delivered the card payment authorisation.
    /// </summary>
    [IsoId("_tmNesR1EEey8XKHwKquEQw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PartyType26Code Type { get; init; } 
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_tmNesx1EEey8XKHwKquEQw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Entity in charge of assigning the identification.
    /// </summary>
    [IsoId("_tmNetR1EEey8XKHwKquEQw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public PartyType9Code? Assigner { get; init; } 
    
    /// <summary>
    /// Country of the entity declining or delivering the authorisation.
    /// ISO 3166-1 alpha-2 or alpha-3.
    /// ISO 8583:93 bit 70
    /// </summary>
    [IsoId("_tmNetx1EEey8XKHwKquEQw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; } 
    
    /// <summary>
    /// Short name of the entity delivering or declining the authorisation.
    /// </summary>
    [IsoId("_tmNeuR1EEey8XKHwKquEQw")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
