// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredMandateDocument2"/>
[IsoId("_O661sTE0Ee62xuUQ2zyZww")]
[DisplayName("Referred Mandate Document2")]
public partial record ReferredMandateDocument2
{
    /// <inheritdoc cref="IReferredMandateDocument2.CreditorReference"/>
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    public IsoMax35Text? CreditorReference { get; init; }

    /// <inheritdoc cref="IReferredMandateDocument2.Number"/>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax35Text? Number { get; init; }

    /// <inheritdoc cref="IReferredMandateDocument2.RelatedDate"/>
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    public DateAndType1? RelatedDate { get; init; }

    /// <inheritdoc cref="IReferredMandateDocument2.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DocumentType1? Type { get; init; }
}
