// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant performing the transaction.
/// </summary>
[IsoId("_XUa6IS5vEeKIarvwWcPThw")]
[DisplayName("Organisation")]
public record Organisation9
{
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_Xe-kVS5vEeKIarvwWcPThw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; }

    /// <summary>
    /// Name of the merchant as appearing on the receipt.
    /// </summary>
    [IsoId("_Xe-kXC5vEeKIarvwWcPThw")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CommonName { get; init; }

    /// <summary>
    /// Location category of the place where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_Xe-kYy5vEeKIarvwWcPThw")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public LocationCategory1Code? LocationCategory { get; init; }

    /// <summary>
    /// Location of the merchant where the transaction took place, as appearing on the receipt.
    /// </summary>
    [IsoId("_Xe-kai5vEeKIarvwWcPThw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Address { get; init; }

    /// <summary>
    /// Country of the merchant where the transaction took place.
    /// </summary>
    [IsoId("_Xe-kcS5vEeKIarvwWcPThw")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public ISO3NumericCountryCode? CountryCode { get; init; }

    /// <summary>
    /// Additional merchant data required by a card scheme.
    /// </summary>
    [IsoId("_Xe-keC5vEeKIarvwWcPThw")]
    [DisplayName("Scheme Data")]
    [IsoXmlTag("SchmeData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SchemeData { get; init; }
}
