// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant using the payment services of the card acceptor. The sponsored merchant is not acting as the card acceptor; the latter remaining the only party liable for the transaction vis-à-vis the acquirer.
/// </summary>
[IsoId("_6l8gMMWPEeuhguwJmlgagQ")]
[DisplayName("Sponsored Merchant")]
public record SponsoredMerchant2
{
    /// <summary>
    /// Identification of the sponsored merchant.
    /// </summary>
    [IsoId("_6qvgocWPEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification262 Identification { get; init; }

    /// <summary>
    /// Contains the full name of the sponsored merchant.
    /// </summary>
    [IsoId("_6qvgpcWPEeuhguwJmlgagQ")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? CommonName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the sponsored merchant.
    /// </summary>
    [IsoId("_p1voQCB6Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Address of the sponsored merchant.
    /// </summary>
    [IsoId("_6qvgp8WPEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_CvEjdMWQEeuhguwJmlgagQ")]
    [DisplayName("Additional Address Information")]
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalAddressInformation { get; init; }

    /// <summary>
    /// Location of the acceptor in latitude/longitude decimal degrees.
    /// </summary>
    [IsoId("_LhmJAcWQEeuhguwJmlgagQ")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Additional sponsored merchant data.
    /// </summary>
    [IsoId("_1yfEgMXMEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_55IZgcW7EeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData5? LocalData { get; init; }
}
