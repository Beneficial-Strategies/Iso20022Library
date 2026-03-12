// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification for a party using an identification type, a country code and a text field.
/// </summary>
[IsoId("_APIdodokEeC60axPepSq7g_112265007")]
[DisplayName("Alternate Party Identification")]
public partial record AlternatePartyIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of alternate identification of the party identified.
    /// </summary>
    [IsoId("_APIdotokEeC60axPepSq7g_-1574059")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required IdentificationType40Choice_ IdentificationType { get; init; } 
    
    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_APIdo9okEeC60axPepSq7g_-884807346")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_APIdpNokEeC60axPepSq7g_-1176765084")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AlternateIdentification { get; init; } 
    
    
    #nullable disable
    
}
