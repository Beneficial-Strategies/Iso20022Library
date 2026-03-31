// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Journal3.
/// </summary>
[IsoId("_tqQ9pZEhEe-Goq1fIU72qA")]
[DisplayName("Limit Journal3")]
public record LimitJournal3
{
    /// <summary>
    /// Journal Activity Date.
    /// </summary>
    [DisplayName("Journal Activity Date")]
    [IsoXmlTag("JrnlActvtyDt")]
    public required IsoISODate JournalActivityDate { get; init; }

    /// <summary>
    /// Journal Entry.
    /// </summary>
    [DisplayName("Journal Entry")]
    [IsoXmlTag("JrnlNtry")]
    public ValueList<LimitJournalEntry3> JournalEntry { get; init; } = [];

    /// <summary>
    /// Limit.
    /// </summary>
    [DisplayName("Limit")]
    [IsoXmlTag("Lmt")]
    public required LimitAmount1 Limit { get; init; }
}
