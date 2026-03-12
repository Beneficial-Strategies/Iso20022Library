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
[IsoId("_v1YTYYdDEeulCpwZAxK3Uw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification256
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_v600EYdDEeulCpwZAxK3Uw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    [IsoId("_v600E4dDEeulCpwZAxK3Uw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; } 
    
    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_v600FYdDEeulCpwZAxK3Uw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 
    
    /// <summary>
    /// Short name of the party.
    /// </summary>
    [IsoId("_v600F4dDEeulCpwZAxK3Uw")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Legal Corporate Name of the party
    /// </summary>
    [IsoId("_d0KQQCB7Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public IsoMax99Text? LegalCorporateName { get; init; } 
    
    /// <summary>
    /// Additional identification assigned to the party.
    /// </summary>
    [IsoId("_v600GYdDEeulCpwZAxK3Uw")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public AdditionalData1? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Name and location of the card acceptor. May contain only the name when the location is specified elsewhere.
    /// </summary>
    [IsoId("_v600G4dDEeulCpwZAxK3Uw")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public required IsoMax99Text NameAndLocation { get; init; } 
    
    
    #nullable disable
    
}
