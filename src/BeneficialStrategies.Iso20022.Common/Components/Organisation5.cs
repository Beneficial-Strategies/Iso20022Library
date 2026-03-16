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
[IsoId("_Sk6RkgEcEeCQm6a_G2yO_w_1310692189")]
[DisplayName("Organisation")]
public record Organisation5
{
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_Sk6RkwEcEeCQm6a_G2yO_w_301252064")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public GenericIdentification32? Identification { get; init; }

    /// <summary>
    /// Name of the merchant as appearing on the receipt.
    /// </summary>
    [IsoId("_Sk6RlAEcEeCQm6a_G2yO_w_-377644787")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonName { get; init; }

    /// <summary>
    /// Location category of the place where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_Sk6RlQEcEeCQm6a_G2yO_w_-775550551")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public LocationCategory1Code? LocationCategory { get; init; }

    /// <summary>
    /// Location of the merchant where the transaction took place, as appearing on the receipt.
    /// </summary>
    [IsoId("_Sk6RlgEcEeCQm6a_G2yO_w_-1873374533")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Address { get; init; }

    /// <summary>
    /// Country of the merchant where the transaction took place.
    /// </summary>
    [IsoId("_Sk6RlwEcEeCQm6a_G2yO_w_-1237284944")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public ISO3ACountryCode? CountryCode { get; init; }

    /// <summary>
    /// Additional merchant data required by a card scheme.
    /// </summary>
    [IsoId("_Sk6RmAEcEeCQm6a_G2yO_w_-1283975854")]
    [DisplayName("Scheme Data")]
    [IsoXmlTag("SchmeData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SchemeData { get; init; }
}
