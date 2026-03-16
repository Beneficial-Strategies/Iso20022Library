// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a date of issue.
/// </summary>
[IsoId("_SuJtJQEcEeCQm6a_G2yO_w_418164459")]
[DisplayName("Document Identification")]
public record DocumentIdentification23
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_SuJtJgEcEeCQm6a_G2yO_w_304325393")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date of issuance of the document.
    /// </summary>
    [IsoId("_SuJtJwEcEeCQm6a_G2yO_w_-578907894")]
    [DisplayName("Date Of Issue")]
    [IsoXmlTag("DtOfIsse")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfIssue { get; init; }

    /// <summary>
    /// Identification of buyer order line item.
    /// </summary>
    [IsoId("_SuJtKAEcEeCQm6a_G2yO_w_-510379827")]
    [DisplayName("Order Line Identification")]
    [IsoXmlTag("OrdrLineId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OrderLineIdentification { get; init; }
}
