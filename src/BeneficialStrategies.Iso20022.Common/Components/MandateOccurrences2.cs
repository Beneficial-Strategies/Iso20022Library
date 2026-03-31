// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to the duration of the mandate and the occurrence of the underlying transactions.
/// </summary>
[IsoId("_tyV98FkyEeGeoaLUQk__nA_-12295162")]
[DisplayName("Mandate Occurrences")]
public record MandateOccurrences2
{
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    [IsoId("_tyV98VkyEeGeoaLUQk__nA_138735592")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public required SequenceType2Code SequenceType { get; init; }

    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    [IsoId("_tyV98lkyEeGeoaLUQk__nA_1496546548")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency6Code? Frequency { get; init; }

    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    [IsoId("_tyfH4FkyEeGeoaLUQk__nA_-654000325")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DatePeriodDetails1? Duration { get; init; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_tyfH4VkyEeGeoaLUQk__nA_852809835")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_tyfH4lkyEeGeoaLUQk__nA_-1903192030")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }
}
