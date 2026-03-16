// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_djqi4YHaEeu02oZZRFgg6A")]
[DisplayName("Party Identification")]
public record PartyIdentification254
{
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_dozhkYHaEeu02oZZRFgg6A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    [IsoId("_dozhk4HaEeu02oZZRFgg6A")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country code of the acceptor.
    /// ISO 8583 bit 19
    /// </summary>
    [IsoId("_dozhlYHaEeu02oZZRFgg6A")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the acceptor.
    /// </summary>
    [IsoId("_dozhl4HaEeu02oZZRFgg6A")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party
    /// </summary>
    [IsoId("_RyTn8CB7Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Additional identification assigned by an agent to an acceptor.
    /// </summary>
    [IsoId("_dozhmYHaEeu02oZZRFgg6A")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name and location of acceptor.  May only contain name and not location if the location is specified elsewhere.
    /// </summary>
    [IsoId("_dozhm4HaEeu02oZZRFgg6A")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? NameAndLocation { get; init; }

    /// <summary>
    /// Address of the entity.
    /// </summary>
    [IsoId("_dozhnYHaEeu02oZZRFgg6A")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_jyHtpMWQEeuhguwJmlgagQ")]
    [DisplayName("Additional Address Information")]
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalAddressInformation { get; init; }

    /// <summary>
    /// Location of the acceptor in latitude/longitude decimal degrees.
    /// </summary>
    [IsoId("_lbUgEcWQEeuhguwJmlgagQ")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Electronic mail address.
    /// </summary>
    [IsoId("_dozhn4HaEeu02oZZRFgg6A")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_dozhoYHaEeu02oZZRFgg6A")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies  a phone number as defined by telecom services.
    /// </summary>
    [IsoId("_dozho4HaEeu02oZZRFgg6A")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PhoneNumber { get; init; }

    /// <summary>
    /// Phone number of the customer service.
    /// </summary>
    [IsoId("_dozhpYHaEeu02oZZRFgg6A")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// </summary>
    [IsoId("_dozhp4HaEeu02oZZRFgg6A")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; }

    /// <summary>
    /// Identification of a party by its tax registration number.
    /// </summary>
    [IsoId("_dozhqYHaEeu02oZZRFgg6A")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_ovZmEIHbEeu02oZZRFgg6A")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_hIH1ocXJEeumGdYElfgmbw")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData4? LocalData { get; init; }

    /// <summary>
    /// Sponsored merchant is a merchant that uses the payment services of another entity that acts as the card acceptor.
    /// </summary>
    [IsoId("_sc9c8YHbEeu02oZZRFgg6A")]
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public SponsoredMerchant2? SponsoredMerchant { get; init; }
}
