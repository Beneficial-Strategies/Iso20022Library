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
[IsoId("_gAZqAYMEEeWhGPRU7TIQwQ")]
[DisplayName("Alternate Party Identification")]
public partial record AlternatePartyIdentification8
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of alternate identification of the party identified.
    /// </summary>
    [IsoId("_gWRMU4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required IdentificationType43Choice_ IdentificationType { get; init; } 
    
    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_gWRMW4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_gWRMY4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AlternateIdentification { get; init; } 
    
    
    #nullable disable
    
}
