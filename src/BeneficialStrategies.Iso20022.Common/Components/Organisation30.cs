// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_wTngdUNMEeamLdeYEZm56w")]
[DisplayName("Organisation")]
public partial record Organisation30
{
    #nullable enable
    
    /// <summary>
    /// Name by which the organisation is known and which is usually used to identify that organisation.
    /// </summary>
    [IsoId("_wsxAQUNMEeamLdeYEZm56w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Name of the organisation in short form.
    /// </summary>
    [IsoId("_wsxAQ0NMEeamLdeYEZm56w")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the organisation.
    /// </summary>
    [IsoId("_wsxARUNMEeamLdeYEZm56w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification72Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_wsxAR0NMEeamLdeYEZm56w")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    /// <summary>
    /// Purpose of the organisation, for example, charity.
    /// </summary>
    [IsoId("_wsxASUNMEeamLdeYEZm56w")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Purpose { get; init; } 
    
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_wsxAS0NMEeamLdeYEZm56w")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; } 
    
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_wsxATUNMEeamLdeYEZm56w")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_wsxAT0NMEeamLdeYEZm56w")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PostalAddress21> PostalAddress { get; init; } = new ValueList<PostalAddress21>(){};
    
    /// <summary>
    /// Type of organisation.
    /// </summary>
    [IsoId("_wsxAUUNMEeamLdeYEZm56w")]
    [DisplayName("Type Of Organisation")]
    [IsoXmlTag("TpOfOrg")]
    public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
    
    /// <summary>
    /// Place of listing for shares in the organisation.
    /// </summary>
    [IsoId("_JPkAcUzsEea8fovz_9xSTQ")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PlaceOfListing { get; init; } 
    
    
    #nullable disable
    
}
