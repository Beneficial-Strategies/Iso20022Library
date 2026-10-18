// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredDocumentInformation8"/>
[IsoId("_OzVnATE0Ee62xuUQ2zyZww")]
[DisplayName("Referred Document Information8")]
public partial record ReferredDocumentInformation8
{
    /// <inheritdoc cref="IReferredDocumentInformation8.LineDetails"/>
    [DisplayName("Line Details")]
    [IsoXmlTag("LineDtls")]
    public ValueList<DocumentLineInformation2> LineDetails { get; init; } = [];

    /// <inheritdoc cref="IReferredDocumentInformation8.Number"/>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax35Text? Number { get; init; }

    /// <inheritdoc cref="IReferredDocumentInformation8.RelatedDate"/>
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    public DateAndType1? RelatedDate { get; init; }

    /// <inheritdoc cref="IReferredDocumentInformation8.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DocumentType1? Type { get; init; }
}
