// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitJournalReportOrError8Choice
{
    /// <summary>
    /// Limit Journal.
    /// </summary>
    [DisplayName("Limit Journal")]
    public record LimitJournal : LimitJournalReportOrError8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("LmtJrnl")]
        public required LimitJournal3 Value { get; init; }
    }
}
