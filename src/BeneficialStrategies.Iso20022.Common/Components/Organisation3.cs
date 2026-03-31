// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_QNmVKdp-Ed-ak6NoX_4Aeg_-1024878477")]
[DisplayName("Organisation")]
public record Organisation3
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QNvfENp-Ed-ak6NoX_4Aeg_-1024878451")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_QNvfEdp-Ed-ak6NoX_4Aeg_-1024878400")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification4Choice_? Identification { get; init; }

    /// <summary>
    /// Purpose of the organisation, eg, charity.
    /// </summary>
    [IsoId("_QNvfEtp-Ed-ak6NoX_4Aeg_-1024878123")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Purpose { get; init; }

    /// <summary>
    /// Country of taxation of an individual person or an organisation.
    /// </summary>
    [IsoId("_QNvfE9p-Ed-ak6NoX_4Aeg_-1024878070")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_QNvfFNp-Ed-ak6NoX_4Aeg_-1024878010")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; }

    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_QNvfFdp-Ed-ak6NoX_4Aeg_-1024877702")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QNvfFtp-Ed-ak6NoX_4Aeg_-1805973863")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; }

    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_QNvfF9p-Ed-ak6NoX_4Aeg_-1805973435")]
    [DisplayName("National Registration Number")]
    [IsoXmlTag("NtlRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NationalRegistrationNumber { get; init; }

    /// <summary>
    /// Address information to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_QNvfGNp-Ed-ak6NoX_4Aeg_-1024877512")]
    [DisplayName("Modified Postal Address")]
    [IsoXmlTag("ModfdPstlAdr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ModificationScope1> ModifiedPostalAddress { get; init; } = [];

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QN5QENp-Ed-ak6NoX_4Aeg_-1024877605")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QN5QEdp-Ed-ak6NoX_4Aeg_1651485498")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; }
}
