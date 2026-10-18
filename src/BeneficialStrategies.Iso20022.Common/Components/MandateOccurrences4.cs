// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateOccurrences4"/>
[IsoId("_sKVqgWk2Eeanu6HLe77Rkg")]
[DisplayName("Mandate Occurrences")]
public partial record MandateOccurrences4
{
    /// <inheritdoc cref="IMandateOccurrences4.SequenceType"/>
    [IsoId("_sVM2s2k2Eeanu6HLe77Rkg")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public required SequenceType2Code SequenceType { get; init; }

    /// <inheritdoc cref="IMandateOccurrences4.Frequency"/>
    [IsoId("_sVM2tWk2Eeanu6HLe77Rkg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateOccurrences4.Duration"/>
    [IsoId("_sVM2t2k2Eeanu6HLe77Rkg")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DatePeriodDetails1? Duration { get; init; }

    /// <inheritdoc cref="IMandateOccurrences4.FirstCollectionDate"/>
    [IsoId("_sVM2uWk2Eeanu6HLe77Rkg")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateOccurrences4.FinalCollectionDate"/>
    [IsoId("_sVM2u2k2Eeanu6HLe77Rkg")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }
}
