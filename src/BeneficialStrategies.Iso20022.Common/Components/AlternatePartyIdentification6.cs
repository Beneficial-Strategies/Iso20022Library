// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification for a party using an id type, a country code and an text field.
/// </summary>
[IsoId("_PHNIUNooEeCWg-hsBVGrDA_-33380345")]
[DisplayName("Alternate Party Identification")]
public partial record AlternatePartyIdentification6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
    /// </summary>
    [IsoId("_PHNIUdooEeCWg-hsBVGrDA_-147219411")]
    [DisplayName("Type Of Identification")]
    [IsoXmlTag("TpOfId")]
    public required IdentificationType41Choice_ TypeOfIdentification { get; init; } 
    
    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_PHNIUtooEeCWg-hsBVGrDA_-1030452698")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PHNIU9ooEeCWg-hsBVGrDA_-1144291764")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AlternateIdentification { get; init; } 
    
    
    #nullable disable
    
}
