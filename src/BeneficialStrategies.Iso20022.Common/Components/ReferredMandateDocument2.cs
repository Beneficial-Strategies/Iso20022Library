// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Referred Mandate Document2.
/// </summary>
[IsoId("_O661sTE0Ee62xuUQ2zyZww")]
[DisplayName("Referred Mandate Document2")]
public record ReferredMandateDocument2
{
    /// <summary>
    /// Creditor Reference.
    /// </summary>
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    public IsoMax35Text? CreditorReference { get; init; }

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Related Date.
    /// </summary>
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    public DateAndType1? RelatedDate { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DocumentType1? Type { get; init; }
}
