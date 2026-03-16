// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CalendarOrBusinessError1Choice
{
    /// <summary>
    /// Requested information on the system calendar.
    /// </summary>
    [IsoId("_dVcQ2Ym7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Data")]
    public record CalendarData : CalendarOrBusinessError1Choice_
    {
        /// <summary>
        /// Date for which the calendar information is provided.
        /// </summary>
        [IsoId("_-zQEYom7Eeipw6hHPgB4Sw")]
        [DisplayName("System Date")]
        [IsoXmlTag("SysDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate SystemDate { get; init; }

        /// <summary>
        /// Status of the system.
        /// </summary>
        [IsoId("_-zQEY4m7Eeipw6hHPgB4Sw")]
        [DisplayName("System Status")]
        [IsoXmlTag("SysSts")]
        public required SystemStatus3Choice_ SystemStatus { get; init; }
    }
}
