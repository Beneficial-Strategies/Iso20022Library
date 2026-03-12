// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice
{
    /// <summary>
    /// Reporting source, as published in an external reporting source code list.
    /// </summary>
    [IsoId("_RqIkktp-Ed-ak6NoX_4Aeg_-1706426890")]
    [DisplayName("Code")]
    public partial record Code : ReportingSource1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reporting source, as published in an external reporting source code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalReportingSource1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
