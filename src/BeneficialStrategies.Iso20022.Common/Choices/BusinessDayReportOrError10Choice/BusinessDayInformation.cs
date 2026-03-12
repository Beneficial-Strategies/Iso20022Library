// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError10Choice
{
    /// <summary>
    /// Requested system details for a specific business day.
    /// </summary>
    [IsoId("_OYVo4XXyEei3jO6riKEVXg")]
    [DisplayName("Business Day Information")]
    public partial record BusinessDayInformation : BusinessDayReportOrError10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date for which the availability information is provided.
        /// </summary>
        [IsoId("_OinmQXXyEei3jO6riKEVXg")]
        [DisplayName("System Date")]
        [IsoXmlTag("SysDt")]
        public DateAndDateTime2Choice_? SystemDate { get; init; } 
        
        /// <summary>
        /// Status of a system and the period of time during which the status is valid.
        /// </summary>
        [IsoId("_OinmQ3XyEei3jO6riKEVXg")]
        [DisplayName("System Status")]
        [IsoXmlTag("SysSts")]
        public SystemStatus3? SystemStatus { get; init; } 
        
        /// <summary>
        /// Information relating to system operations and foreseen events relating to the operation of the system.
        /// </summary>
        [IsoId("_OinmRXXyEei3jO6riKEVXg")]
        [DisplayName("System Information Per Currency")]
        [IsoXmlTag("SysInfPerCcy")]
        public SystemAvailabilityAndEvents3? SystemInformationPerCurrency { get; init; } 
        
        
        #nullable disable
        
    }
}
