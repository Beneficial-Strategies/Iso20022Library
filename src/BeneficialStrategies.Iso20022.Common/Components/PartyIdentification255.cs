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
[IsoId("_h0OF0YZ_EeuSbct6WWD-Ng")]
[DisplayName("Party Identification")]
public record PartyIdentification255
{
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_h5m8IYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    [IsoId("_h5m8I4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country code of the acceptor.
    /// ISO 8583:87/93 bit 43 &amp; 8583:2003 bit 43-71 (when used for Acceptor Country Code)
    /// </summary>
    [IsoId("_h5m8JYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the acceptor.
    /// </summary>
    [IsoId("_h5m8J4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    [IsoId("_QBN6QCB6Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Additional identification assigned by an agent to an acceptor.
    /// </summary>
    [IsoId("_h5m8KYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public AdditionalData1? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name and location of acceptor.  May only contain name when the location is specified elsewhere.
    /// </summary>
    [IsoId("_h5m8K4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public required IsoMax99Text NameAndLocation { get; init; }

    /// <summary>
    /// Address of the entity.
    /// ISO 8583:93 bit 43 &amp; 8583:2003 bit 43-71 (when used for acceptor address)
    /// </summary>
    [IsoId("_h5m8LYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_rQShoMWLEeuhguwJmlgagQ")]
    [DisplayName("Additional Address Information")]
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalAddressInformation { get; init; }

    /// <summary>
    /// Location of the acceptor in latitude/longitude decimal degrees.
    /// </summary>
    [IsoId("_OnhDAMWOEeuhguwJmlgagQ")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Electronic mail address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor email address)
    /// </summary>
    [IsoId("_h5m8L4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor URL)
    /// </summary>
    [IsoId("_h5m8MYZ_EeuSbct6WWD-Ng")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies  a phone number as defined by telecom services.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor phone number)
    /// </summary>
    [IsoId("_h5m8M4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PhoneNumber { get; init; }

    /// <summary>
    /// Phone number of the customer service.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor customer service phone number)
    /// </summary>
    [IsoId("_h5m8NYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor additional contact information)
    /// </summary>
    [IsoId("_h5m8N4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; }

    /// <summary>
    /// Identification of a party by its tax registration number.
    /// </summary>
    [IsoId("_h5m8OYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_h5m8O4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_V-qukcXBEeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData4? LocalData { get; init; }

    /// <summary>
    /// Sponsored merchant is a merchant that uses the payment services of another entity that acts as the card acceptor.
    /// </summary>
    [IsoId("_h5m8PYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public ValueList<SponsoredMerchant2> SponsoredMerchant { get; init; } = [];
}
