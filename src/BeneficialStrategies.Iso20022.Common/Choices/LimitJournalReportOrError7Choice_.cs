// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit Journal Report Or Error7Choice.
    /// </summary>
    [KnownType(typeof(LimitJournalReportOrError7Choice.BusinessReport))]
    [KnownType(typeof(LimitJournalReportOrError7Choice.OperationalError))]
    [JsonDerivedType(
        typeof(LimitJournalReportOrError7Choice.BusinessReport),
        nameof(LimitJournalReportOrError7Choice.BusinessReport)
    )]
    [JsonDerivedType(
        typeof(LimitJournalReportOrError7Choice.OperationalError),
        nameof(LimitJournalReportOrError7Choice.OperationalError)
    )]
    [IsoId("_r1B6UZEhEe-Goq1fIU72qA")]
    [DisplayName("Limit Journal Report Or Error7Choice")]
    public abstract record LimitJournalReportOrError7Choice_ { }
}
