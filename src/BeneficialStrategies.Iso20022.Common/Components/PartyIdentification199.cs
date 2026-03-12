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
[IsoId("_fLSzbuwMEeiMkKo2clXHdQ")]
[DisplayName("Party Identification")]
public partial record PartyIdentification199
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_fLSzcewMEeiMkKo2clXHdQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    [IsoId("_fLSzduwMEeiMkKo2clXHdQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; } 
    
    /// <summary>
    /// Country code of the acceptor.
    /// ISO 8583 bit 19
    /// </summary>
    [IsoId("_fLSzdOwMEeiMkKo2clXHdQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 
    
    /// <summary>
    /// Short name of the acceptor.
    /// </summary>
    [IsoId("_fLSzb-wMEeiMkKo2clXHdQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Additional identification assigned by an agent to an acceptor.
    /// </summary>
    [IsoId("_fLSzeewMEeiMkKo2clXHdQ")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Name and location of acceptor.
    /// ISO 8583:87/93 bit 43 &amp; 8583:2003 bit 43-71 (when used for Acceptor name and location)
    /// </summary>
    [IsoId("_fLSze-wMEeiMkKo2clXHdQ")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public IsoMax99Text? NameAndLocation { get; init; } 
    
    /// <summary>
    /// Address of the entity.
    /// </summary>
    [IsoId("_fLSzd-wMEeiMkKo2clXHdQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; } 
    
    /// <summary>
    /// Electronic mail address.
    /// </summary>
    [IsoId("_fLSzcuwMEeiMkKo2clXHdQ")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; } 
    
    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_fLSzcOwMEeiMkKo2clXHdQ")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies  a phone number as defined by telecom services.
    /// </summary>
    [IsoId("_fLSzc-wMEeiMkKo2clXHdQ")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PhoneNumber { get; init; } 
    
    /// <summary>
    /// Phone number of the customer service.
    /// </summary>
    [IsoId("_fLSzeuwMEeiMkKo2clXHdQ")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CustomerService { get; init; } 
    
    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// </summary>
    [IsoId("_fLSzeOwMEeiMkKo2clXHdQ")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; } 
    
    /// <summary>
    /// Identification of a party by its tax registration number.
    /// </summary>
    [IsoId("_fLSzdewMEeiMkKo2clXHdQ")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxRegistrationIdentification { get; init; } 
    
    
    #nullable disable
    
}
