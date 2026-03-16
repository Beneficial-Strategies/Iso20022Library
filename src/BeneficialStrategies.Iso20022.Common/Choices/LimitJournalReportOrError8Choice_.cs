// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit Journal Report Or Error8Choice.
    /// </summary>
    [KnownType(typeof(LimitJournalReportOrError8Choice.BusinessError))]
    [KnownType(typeof(LimitJournalReportOrError8Choice.LimitJournal))]
    [JsonDerivedType(typeof(LimitJournalReportOrError8Choice.BusinessError),nameof(LimitJournalReportOrError8Choice.BusinessError))]
    [JsonDerivedType(typeof(LimitJournalReportOrError8Choice.LimitJournal),nameof(LimitJournalReportOrError8Choice.LimitJournal))]
    [IsoId("_toRZlZEhEe-Goq1fIU72qA")]
    [DisplayName("Limit Journal Report Or Error8Choice")]
    public abstract partial record LimitJournalReportOrError8Choice_
    {
    }
}
