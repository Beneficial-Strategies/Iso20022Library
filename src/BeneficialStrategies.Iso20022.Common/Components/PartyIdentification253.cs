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
[IsoId("_KAcGwYHNEeuwq_rv81SdXw")]
[DisplayName("Party Identification")]
public record PartyIdentification253
{
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_KGj84YHNEeuwq_rv81SdXw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    [IsoId("_KGj844HNEeuwq_rv81SdXw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country code of the acceptor.
    /// ISO 8583:87/93 bit 43 &amp; 8583:2003 bit 43-71 (when used for Acceptor Country Code)
    /// </summary>
    [IsoId("_KGj85YHNEeuwq_rv81SdXw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the acceptor.
    /// </summary>
    [IsoId("_KGj854HNEeuwq_rv81SdXw")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    [IsoId("_IFC4cCB7Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Additional identification assigned by an agent to an acceptor.
    /// </summary>
    [IsoId("_KGj86YHNEeuwq_rv81SdXw")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name and location of acceptor.  May only contain name when the location is specified elsewhere.
    /// </summary>
    [IsoId("_KGj864HNEeuwq_rv81SdXw")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? NameAndLocation { get; init; }

    /// <summary>
    /// Address of the entity.
    /// ISO 8583:93 bit 43 &amp; 8583:2003 bit 43-71 (when used for acceptor address)
    /// </summary>
    [IsoId("_KGkj8YHNEeuwq_rv81SdXw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_pws21MWOEeuhguwJmlgagQ")]
    [DisplayName("Additional Address Information")]
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalAddressInformation { get; init; }

    /// <summary>
    /// Location of the acceptor in latitude/longitude decimal degrees.
    /// </summary>
    [IsoId("_rlvF0cWOEeuhguwJmlgagQ")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Electronic mail address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor email address)
    /// </summary>
    [IsoId("_KGkj84HNEeuwq_rv81SdXw")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor URL)
    /// </summary>
    [IsoId("_KGkj9YHNEeuwq_rv81SdXw")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies  a phone number as defined by telecom services.
    /// </summary>
    [IsoId("_KGkj94HNEeuwq_rv81SdXw")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PhoneNumber { get; init; }

    /// <summary>
    /// Phone number of the customer service.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor customer service phone number)
    /// </summary>
    [IsoId("_KGkj-YHNEeuwq_rv81SdXw")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// </summary>
    [IsoId("_KGkj-4HNEeuwq_rv81SdXw")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; }

    /// <summary>
    /// Identification of a party by its tax registration number.
    /// </summary>
    [IsoId("_KGkj_YHNEeuwq_rv81SdXw")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_KGkj_4HNEeuwq_rv81SdXw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_D9f24cW7EeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData4? LocalData { get; init; }

    /// <summary>
    /// Sponsored merchant is a merchant that uses the payment services of another entity that acts as the card acceptor.
    /// </summary>
    [IsoId("_KGkkAYHNEeuwq_rv81SdXw")]
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public ValueList<SponsoredMerchant2> SponsoredMerchant { get; init; } = [];
}
