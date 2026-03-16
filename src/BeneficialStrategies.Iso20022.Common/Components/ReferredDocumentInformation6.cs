// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_XN5h7x77EeSxevWRRWxNAg")]
[DisplayName("Referred Document Information")]
public record ReferredDocumentInformation6
{
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    [IsoId("_Xf7GAx77EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType4? Type { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    [IsoId("_Xf7GBR77EeSxevWRRWxNAg")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    [IsoId("_Xf7GBx77EeSxevWRRWxNAg")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }
}
