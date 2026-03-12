// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CalendarReportOrError1Choice
{
    /// <summary>
    /// Provides the calendar information related to the system.
    /// </summary>
    [IsoId("_dVcQ44m7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Report")]
    public partial record CalendarReport : CalendarReportOrError1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the service or system for which the calendar information is provided.
        /// </summary>
        [IsoId("_G00uIYm8Eeipw6hHPgB4Sw")]
        [DisplayName("Service")]
        [IsoXmlTag("Svc")]
        public SystemAndCurrency1? Service { get; init; } 
        
        /// <summary>
        /// Requested information on the calendar or business error report when information has not been found.
        /// </summary>
        [IsoId("_dVcQ34m7Eeipw6hHPgB4Sw")]
        [DisplayName("Calendar Or Error")]
        [IsoXmlTag("CalOrErr")]
        public required CalendarOrBusinessError1Choice_ CalendarOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
