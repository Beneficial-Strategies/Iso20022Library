// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportingRequirement3Choice
{
    /// <summary>
    /// No Reporting Requirement.
    /// </summary>
    [DisplayName("No Reporting Requirement")]
    public partial record NoReportingRequirement : ReportingRequirement3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NoRptgRqrmnt")]
        public required ReconciliationCategory4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
