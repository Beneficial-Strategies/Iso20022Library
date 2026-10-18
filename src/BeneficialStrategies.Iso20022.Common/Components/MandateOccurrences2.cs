// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateOccurrences2"/>
[IsoId("_tyV98FkyEeGeoaLUQk__nA_-12295162")]
[DisplayName("Mandate Occurrences")]
public partial record MandateOccurrences2
{
    /// <inheritdoc cref="IMandateOccurrences2.SequenceType"/>
    [IsoId("_tyV98VkyEeGeoaLUQk__nA_138735592")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public required SequenceType2Code SequenceType { get; init; }

    /// <inheritdoc cref="IMandateOccurrences2.Frequency"/>
    [IsoId("_tyV98lkyEeGeoaLUQk__nA_1496546548")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency6Code? Frequency { get; init; }

    /// <inheritdoc cref="IMandateOccurrences2.Duration"/>
    [IsoId("_tyfH4FkyEeGeoaLUQk__nA_-654000325")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DatePeriodDetails1? Duration { get; init; }

    /// <inheritdoc cref="IMandateOccurrences2.FirstCollectionDate"/>
    [IsoId("_tyfH4VkyEeGeoaLUQk__nA_852809835")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateOccurrences2.FinalCollectionDate"/>
    [IsoId("_tyfH4lkyEeGeoaLUQk__nA_-1903192030")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }
}
