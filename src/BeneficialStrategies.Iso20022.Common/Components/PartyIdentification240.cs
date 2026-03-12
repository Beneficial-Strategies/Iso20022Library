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
[IsoId("_7KtWtfQ0EeqAradXpAelDQ")]
[DisplayName("Party Identification")]
public partial record PartyIdentification240
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_7dmdgfQ0EeqAradXpAelDQ")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName3 NameAndAddress { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_7dmdg_Q0EeqAradXpAelDQ")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; } 
    
    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    [IsoId("_7dmdhfQ0EeqAradXpAelDQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public NaturalPersonIdentification1? Identification { get; init; } 
    
    /// <summary>
    /// Nationality of the person.
    /// </summary>
    [IsoId("__9pr0vQ1EeqAradXpAelDQ")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; } 
    
    /// <summary>
    /// Date on which and place at which a born person is born.
    /// </summary>
    [IsoId("__9pr0_Q1EeqAradXpAelDQ")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
    
    
    #nullable disable
    
}
