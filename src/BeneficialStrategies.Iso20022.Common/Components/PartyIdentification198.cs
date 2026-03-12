// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_LaBAcUrBEeenp6hmNprBHg")]
[DisplayName("Party Identification")]
public partial record PartyIdentification198
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_LkAC4UrBEeenp6hmNprBHg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    [IsoId("_LkAC40rBEeenp6hmNprBHg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public PartyType18Code? Assigner { get; init; } 
    
    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_LkAC5UrBEeenp6hmNprBHg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 
    
    /// <summary>
    /// Short name of the party.
    /// </summary>
    [IsoId("_LkAC50rBEeenp6hmNprBHg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
