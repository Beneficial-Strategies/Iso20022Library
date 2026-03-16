// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
[IsoId("_cqCrUcXKEeumGdYElfgmbw")]
[DisplayName("Local Data")]
public record LocalData6
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_cuxaUcXKEeumGdYElfgmbw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of where the card was mailed to.
    /// </summary>
    [IsoId("_xj0VwcrcEeuQjLd-KKZrCg")]
    [DisplayName("Mailing Address")]
    [IsoXmlTag("MlngAdr")]
    public Address3? MailingAddress { get; init; }

    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the Unstructured mailing address where the card was mailed to.
    /// </summary>
    [IsoId("_zLT4AcrcEeuQjLd-KKZrCg")]
    [DisplayName("Mailing Address Unstructured")]
    [IsoXmlTag("MlngAdrUstrd")]
    [IsoSimpleType(IsoSimpleType.Max512Text)]
    [StringLength(maximumLength: 512, MinimumLength = 1)]
    public IsoMax512Text? MailingAddressUnstructured { get; init; }

    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the postal code where the card was mailed from.
    /// </summary>
    [IsoId("_1D_Q4crcEeuQjLd-KKZrCg")]
    [DisplayName("Mailed From Postal Code")]
    [IsoXmlTag("MldFrPstlCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MailedFromPostalCode { get; init; }

    /// <summary>
    /// Local language equivalent of the Cardholder name.
    /// </summary>
    [IsoId("_cuxaU8XKEeumGdYElfgmbw")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public CardholderName2? CardholderName { get; init; }

    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_6Mr10cooEeuuJ571wNLKkA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation22? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_ojr9YMXLEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
