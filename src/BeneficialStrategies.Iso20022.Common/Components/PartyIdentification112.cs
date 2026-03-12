// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
[IsoId("_1EXqocNQEeWGDrnsYu2p6g")]
[DisplayName("Party Identification")]
public partial record PartyIdentification112
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_1QuEkcNQEeWGDrnsYu2p6g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party10Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_1QuEk8NQEeWGDrnsYu2p6g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_1QuElcNQEeWGDrnsYu2p6g")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; } 
    
    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_1QuEl8NQEeWGDrnsYu2p6g")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; } 
    
    /// <summary>
    /// Contact defined for this party.
    /// </summary>
    [IsoId("_1QuEmcNQEeWGDrnsYu2p6g")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contacts3? ContactDetails { get; init; } 
    
    
    #nullable disable
    
}
