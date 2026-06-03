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
[IsoId("_yLNgcbXxEfCUZfsQO4rYeA")]
[DisplayName("Organisation45")]
public record Organisation45
{
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_yMAxtbXxEfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public GenericIdentification192? Identification { get; init; }

    /// <summary>
    /// Name of the merchant as appearing on the receipt.
    /// </summary>
    [IsoId("_yMAxu7XxEfCUZfsQO4rYeA")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    public IsoMax70Text? CommonName { get; init; }

    /// <summary>
    /// Location category of the place where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_yMAxwbXxEfCUZfsQO4rYeA")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public LocationCategory4Code? LocationCategory { get; init; }

    /// <summary>
    /// Location and contact information of the merchant performing the transaction.
    /// </summary>
    [IsoId("_yMAxx7XxEfCUZfsQO4rYeA")]
    [DisplayName("Location And Contact")]
    [IsoXmlTag("LctnAndCtct")]
    public CommunicationAddress9? LocationAndContact { get; init; }

    /// <summary>
    /// Additional merchant data required by a card scheme.
    /// </summary>
    [IsoId("_yMAxzbXxEfCUZfsQO4rYeA")]
    [DisplayName("Scheme Data")]
    [IsoXmlTag("SchmeData")]
    public IsoMax140Text? SchemeData { get; init; }
}
