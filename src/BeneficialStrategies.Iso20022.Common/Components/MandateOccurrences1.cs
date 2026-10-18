// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateOccurrences1"/>
[IsoId("_T28aYtp-Ed-ak6NoX_4Aeg_-1799899683")]
[DisplayName("Mandate Occurrences")]
public partial record MandateOccurrences1
{
    /// <inheritdoc cref="IMandateOccurrences1.SequenceType"/>
    [IsoId("_T28aY9p-Ed-ak6NoX_4Aeg_1230892211")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public required SequenceType2Code SequenceType { get; init; }

    /// <inheritdoc cref="IMandateOccurrences1.Frequency"/>
    [IsoId("_T28aZNp-Ed-ak6NoX_4Aeg_-1799899530")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency1Code? Frequency { get; init; }

    /// <inheritdoc cref="IMandateOccurrences1.Duration"/>
    [IsoId("_T28aZdp-Ed-ak6NoX_4Aeg_-1799899282")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DatePeriodDetails1? Duration { get; init; }

    /// <inheritdoc cref="IMandateOccurrences1.FirstCollectionDate"/>
    [IsoId("_T28aZtp-Ed-ak6NoX_4Aeg_-1799899591")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateOccurrences1.FinalCollectionDate"/>
    [IsoId("_T28aZ9p-Ed-ak6NoX_4Aeg_-1799899560")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }
}
