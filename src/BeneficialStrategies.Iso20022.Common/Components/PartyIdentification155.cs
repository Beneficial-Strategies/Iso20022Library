// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification of the party.
/// </summary>
[IsoId("_8GkE5_fREeiNZp_PtLohLw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification155
{
    #nullable enable
    
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_8GkE7ffREeiNZp_PtLohLw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification145Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_8GkE9ffREeiNZp_PtLohLw")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
    
    /// <summary>
    /// Provides alternate identification for a party using an id type, a country code and a text field.
    /// </summary>
    [IsoId("_8GkE_ffREeiNZp_PtLohLw")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
    
    
    #nullable disable
    
}
