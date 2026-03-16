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
[IsoId("_oze7gY0QEeWRYffwL7E13A")]
[DisplayName("Organisation")]
public record Organisation25
{
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_o-XV0Y0QEeWRYffwL7E13A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public GenericIdentification32? Identification { get; init; }

    /// <summary>
    /// Name of the merchant as appearing on the receipt.
    /// </summary>
    [IsoId("_o-XV040QEeWRYffwL7E13A")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CommonName { get; init; }

    /// <summary>
    /// Location category of the place where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_o-XV1Y0QEeWRYffwL7E13A")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public LocationCategory1Code? LocationCategory { get; init; }

    /// <summary>
    /// Location and contact information of the merchant performing the transaction.
    /// </summary>
    [IsoId("_3q9GEI0QEeWRYffwL7E13A")]
    [DisplayName("Location And Contact")]
    [IsoXmlTag("LctnAndCtct")]
    public CommunicationAddress5? LocationAndContact { get; init; }

    /// <summary>
    /// Additional merchant data required by a card scheme.
    /// </summary>
    [IsoId("_o-XV240QEeWRYffwL7E13A")]
    [DisplayName("Scheme Data")]
    [IsoXmlTag("SchmeData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SchemeData { get; init; }
}
