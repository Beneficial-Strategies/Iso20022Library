// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocumentLineIdentification1"/>
[IsoId("_1QJJIabjEeKvUvwX_r3tzA")]
[DisplayName("Document Line Identification")]
public partial record DocumentLineIdentification1
{
    /// <inheritdoc cref="IDocumentLineIdentification1.Type"/>
    [IsoId("_1Z0plabjEeKvUvwX_r3tzA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DocumentLineType1? Type { get; init; }

    /// <inheritdoc cref="IDocumentLineIdentification1.Number"/>
    [IsoId("_1Z0pmabjEeKvUvwX_r3tzA")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <inheritdoc cref="IDocumentLineIdentification1.RelatedDate"/>
    [IsoId("_1Z0pnabjEeKvUvwX_r3tzA")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }
}
