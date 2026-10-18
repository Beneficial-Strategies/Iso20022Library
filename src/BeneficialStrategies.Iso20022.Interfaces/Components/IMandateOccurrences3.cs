// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to the duration of the mandate and the occurrence of the underlying transactions.
/// </summary>
[IsoId("_vVpaUSLzEeSizvrwx7oJNQ")]
public interface IMandateOccurrences3 : IIsoComponent
{
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    [IsoId("_vla7syLzEeSizvrwx7oJNQ")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    SequenceType2Code SequenceType { get; }

    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    [IsoId("_vla7tSLzEeSizvrwx7oJNQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    IFrequency21Choice? Frequency { get; }

    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    [IsoId("_vla7tyLzEeSizvrwx7oJNQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    IDatePeriodDetails1? Duration { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_vla7uSLzEeSizvrwx7oJNQ")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    IsoISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_vla7uyLzEeSizvrwx7oJNQ")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    IsoISODate? FinalCollectionDate { get; }
}
