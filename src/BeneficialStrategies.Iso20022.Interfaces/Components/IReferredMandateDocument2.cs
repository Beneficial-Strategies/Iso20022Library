// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Referred Mandate Document2.
/// </summary>
[IsoId("_O661sTE0Ee62xuUQ2zyZww")]
public interface IReferredMandateDocument2 : IIsoComponent
{
    /// <summary>
    /// Creditor Reference.
    /// </summary>
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    IsoMax35Text? CreditorReference { get; }

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    IsoMax35Text? Number { get; }

    /// <summary>
    /// Related Date.
    /// </summary>
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    IDateAndType1? RelatedDate { get; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDocumentType1? Type { get; }
}
