// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_rDJjsWf2Eembv_9KtOEw8g")]
[DisplayName("Organisation")]
public partial record Organisation38
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_rQA7AWf2Eembv_9KtOEw8g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_rQA7A2f2Eembv_9KtOEw8g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification177Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Purpose of the organisation, eg, charity.
    /// </summary>
    [IsoId("_rQA7BWf2Eembv_9KtOEw8g")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Purpose { get; init; } 
    
    /// <summary>
    /// Country of taxation of an organisation.
    /// </summary>
    [IsoId("_rQA7B2f2Eembv_9KtOEw8g")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; } 
    
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_rQA7CWf2Eembv_9KtOEw8g")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; } 
    
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_rQA7C2f2Eembv_9KtOEw8g")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; } 
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_rQA7DWf2Eembv_9KtOEw8g")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_rQA7D2f2Eembv_9KtOEw8g")]
    [DisplayName("National Registration Number")]
    [IsoXmlTag("NtlRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NationalRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_rQA7EWf2Eembv_9KtOEw8g")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<PostalAddress3> PostalAddress { get; init; } = [];
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_rQA7E2f2Eembv_9KtOEw8g")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_rQA7FWf2Eembv_9KtOEw8g")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    
    #nullable disable
    
}
