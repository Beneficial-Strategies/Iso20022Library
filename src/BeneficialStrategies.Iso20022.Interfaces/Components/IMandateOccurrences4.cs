// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to the duration of the mandate and the occurrence of the underlying transactions.
/// </summary>
[IsoId("_sKVqgWk2Eeanu6HLe77Rkg")]
public interface IMandateOccurrences4 : IIsoComponent
{
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    [IsoId("_sVM2s2k2Eeanu6HLe77Rkg")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    SequenceType2Code SequenceType { get; }

    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    [IsoId("_sVM2tWk2Eeanu6HLe77Rkg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    IFrequency36Choice? Frequency { get; }

    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    [IsoId("_sVM2t2k2Eeanu6HLe77Rkg")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    IDatePeriodDetails1? Duration { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_sVM2uWk2Eeanu6HLe77Rkg")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    IsoISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_sVM2u2k2Eeanu6HLe77Rkg")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    IsoISODate? FinalCollectionDate { get; }
}
