// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateOccurrences3"/>
[IsoId("_vVpaUSLzEeSizvrwx7oJNQ")]
[DisplayName("Mandate Occurrences")]
public partial record MandateOccurrences3
{
    /// <inheritdoc cref="IMandateOccurrences3.SequenceType"/>
    [IsoId("_vla7syLzEeSizvrwx7oJNQ")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public required SequenceType2Code SequenceType { get; init; }

    /// <inheritdoc cref="IMandateOccurrences3.Frequency"/>
    [IsoId("_vla7tSLzEeSizvrwx7oJNQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency21Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateOccurrences3.Duration"/>
    [IsoId("_vla7tyLzEeSizvrwx7oJNQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DatePeriodDetails1? Duration { get; init; }

    /// <inheritdoc cref="IMandateOccurrences3.FirstCollectionDate"/>
    [IsoId("_vla7uSLzEeSizvrwx7oJNQ")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateOccurrences3.FinalCollectionDate"/>
    [IsoId("_vla7uyLzEeSizvrwx7oJNQ")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }
}
