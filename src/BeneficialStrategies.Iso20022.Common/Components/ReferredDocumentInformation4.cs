// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the documents referred to in the remittance information.
/// </summary>
[IsoId("_W7TRoabjEeKvUvwX_r3tzA")]
[DisplayName("Referred Document Information")]
public record ReferredDocumentInformation4
{
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    [IsoId("_XGU15abjEeKvUvwX_r3tzA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType2? Type { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    [IsoId("_XGU16abjEeKvUvwX_r3tzA")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    [IsoId("_XGU17abjEeKvUvwX_r3tzA")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }

    /// <summary>
    /// Set of elements used to provide the content of the referred document line.
    /// </summary>
    [IsoId("_bNVHgKbjEeKvUvwX_r3tzA")]
    [DisplayName("Line Details")]
    [IsoXmlTag("LineDtls")]
    public DocumentLineInformation1? LineDetails { get; init; }
}
