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
[IsoId("_8dQzMWYdEeeEbu2gL5hFew")]
[DisplayName("Party Identification")]
public record PartyIdentification203
{
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_8pU5QWYdEeeEbu2gL5hFew")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    [IsoId("_8pU5Q2YdEeeEbu2gL5hFew")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country code of the acceptor.
    /// ISO 8583:87/93 bit 43 &amp; 8583:2003 bit 43-71 (when used for Acceptor Country Code)
    /// </summary>
    [IsoId("_8pU5RWYdEeeEbu2gL5hFew")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the acceptor.
    /// </summary>
    [IsoId("_8pU5R2YdEeeEbu2gL5hFew")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional identification assigned by an agent to an acceptor.
    /// </summary>
    [IsoId("_8pU5SWYdEeeEbu2gL5hFew")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name and location of acceptor.
    /// ISO 8583:87/93 bit 43 &amp; 8583:2003 bit 43-71 (when used for Acceptor name and location)
    /// </summary>
    [IsoId("_8pU5S2YdEeeEbu2gL5hFew")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public required IsoMax99Text NameAndLocation { get; init; }

    /// <summary>
    /// Address of the entity.
    /// ISO 8583:93 bit 43 &amp; 8583:2003 bit 43-71 (when used for acceptor address)
    /// </summary>
    [IsoId("_8pU5UWYdEeeEbu2gL5hFew")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Electronic mail address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor email address)
    /// </summary>
    [IsoId("_8pU5U2YdEeeEbu2gL5hFew")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor URL)
    /// </summary>
    [IsoId("_8pU5VWYdEeeEbu2gL5hFew")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies  a phone number as defined by telecom services.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor phone number)
    /// </summary>
    [IsoId("_8pU5V2YdEeeEbu2gL5hFew")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PhoneNumber { get; init; }

    /// <summary>
    /// Phone number of the customer service.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor customer service phone number)
    /// </summary>
    [IsoId("_8pU5WWYdEeeEbu2gL5hFew")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor additional contact information)
    /// </summary>
    [IsoId("_8pU5W2YdEeeEbu2gL5hFew")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; }

    /// <summary>
    /// Identification of a party by its tax registration number.
    /// </summary>
    [IsoId("_HKMP8WYeEeeEbu2gL5hFew")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_P5LGUOkGEemeDPHh-U9b6w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }

    /// <summary>
    /// Sponsored merchant is a merchant that uses the payment services of another entity that acts as the card acceptor.
    /// </summary>
    [IsoId("_bzZ6sf8JEeic54G0fOJNMg")]
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public SponsoredMerchant1? SponsoredMerchant { get; init; }
}
