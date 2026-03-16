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
[IsoId("_1QJJIabjEeKvUvwX_r3tzA")]
[DisplayName("Document Line Identification")]
public record DocumentLineIdentification1
{
    /// <summary>
    /// Specifies the type of referred document line identification.
    /// </summary>
    [IsoId("_1Z0plabjEeKvUvwX_r3tzA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DocumentLineType1? Type { get; init; }

    /// <summary>
    /// Identification of the type specified for the referred document line.
    /// </summary>
    [IsoId("_1Z0pmabjEeKvUvwX_r3tzA")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Date associated with the referred document line.
    /// </summary>
    [IsoId("_1Z0pnabjEeKvUvwX_r3tzA")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }
}
