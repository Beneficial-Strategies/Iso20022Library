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
[IsoId("_VlU0kWZVEeuQ__SOdbf47A")]
[DisplayName("Mandate Occurrences")]
public record MandateOccurrences5
{
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    [IsoId("_V7Cl42ZVEeuQ__SOdbf47A")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public required SequenceType2Code SequenceType { get; init; }

    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    [IsoId("_V7Cl5WZVEeuQ__SOdbf47A")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    [IsoId("_V7Cl52ZVEeuQ__SOdbf47A")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DatePeriod3? Duration { get; init; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_V7Cl6WZVEeuQ__SOdbf47A")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_V7Cl62ZVEeuQ__SOdbf47A")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }
}
