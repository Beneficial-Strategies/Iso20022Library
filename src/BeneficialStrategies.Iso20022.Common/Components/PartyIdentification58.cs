// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of an organisation.
/// </summary>
[IsoId("_6TOaIpqlEeGSON8vddiWzQ_1457984694")]
[DisplayName("Party Identification")]
public partial record PartyIdentification58
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_6TOaI5qlEeGSON8vddiWzQ_544533769")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_6TOaJJqlEeGSON8vddiWzQ_-631834127")]
    [DisplayName("Legal Name")]
    [IsoXmlTag("LglNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? LegalName { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_6TOaJZqlEeGSON8vddiWzQ_-435367956")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress11? PostalAddress { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous way to identify the party.
    /// </summary>
    [IsoId("_6TOaJpqlEeGSON8vddiWzQ_-43357969")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required Party13Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_6TOaJ5qlEeGSON8vddiWzQ_-1253465410")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; } 
    
    /// <summary>
    /// Indicate how to contact the party.
    /// </summary>
    [IsoId("_6TOaKJqlEeGSON8vddiWzQ_-9493520")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactDetails3? ContactDetails { get; init; } 
    
    
    #nullable disable
    
}
