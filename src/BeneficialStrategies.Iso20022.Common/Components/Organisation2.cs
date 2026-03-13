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
[IsoId("_QNckJtp-Ed-ak6NoX_4Aeg_-1898805277")]
[DisplayName("Organisation")]
public partial record Organisation2
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QNckJ9p-Ed-ak6NoX_4Aeg_-1898805258")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_QNckKNp-Ed-ak6NoX_4Aeg_-1897885228")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification4Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Purpose of the organisation, eg, charity.
    /// </summary>
    [IsoId("_QNmVINp-Ed-ak6NoX_4Aeg_-1897884143")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Purpose { get; init; } 
    
    /// <summary>
    /// Country of taxation of an organisation.
    /// </summary>
    [IsoId("_QNmVIdp-Ed-ak6NoX_4Aeg_-1897884083")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; } 
    
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_QNmVItp-Ed-ak6NoX_4Aeg_-1897884048")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; } 
    
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_QNmVI9p-Ed-ak6NoX_4Aeg_-1897883728")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; } 
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QNmVJNp-Ed-ak6NoX_4Aeg_1142497781")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_QNmVJdp-Ed-ak6NoX_4Aeg_1142498288")]
    [DisplayName("National Registration Number")]
    [IsoXmlTag("NtlRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NationalRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QNmVJtp-Ed-ak6NoX_4Aeg_-1678746591")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<PostalAddress3> PostalAddress { get; init; } = [];
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QNmVJ9p-Ed-ak6NoX_4Aeg_1887830143")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QNmVKNp-Ed-ak6NoX_4Aeg_1480636548")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    
    #nullable disable
    
}
