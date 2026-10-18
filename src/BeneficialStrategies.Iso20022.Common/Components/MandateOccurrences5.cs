// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateOccurrences5"/>
[IsoId("_VlU0kWZVEeuQ__SOdbf47A")]
[DisplayName("Mandate Occurrences")]
public partial record MandateOccurrences5
{
    /// <inheritdoc cref="IMandateOccurrences5.SequenceType"/>
    [IsoId("_V7Cl42ZVEeuQ__SOdbf47A")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public required SequenceType2Code SequenceType { get; init; }

    /// <inheritdoc cref="IMandateOccurrences5.Frequency"/>
    [IsoId("_V7Cl5WZVEeuQ__SOdbf47A")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateOccurrences5.Duration"/>
    [IsoId("_V7Cl52ZVEeuQ__SOdbf47A")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DatePeriod3? Duration { get; init; }

    /// <inheritdoc cref="IMandateOccurrences5.FirstCollectionDate"/>
    [IsoId("_V7Cl6WZVEeuQ__SOdbf47A")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateOccurrences5.FinalCollectionDate"/>
    [IsoId("_V7Cl62ZVEeuQ__SOdbf47A")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }
}
