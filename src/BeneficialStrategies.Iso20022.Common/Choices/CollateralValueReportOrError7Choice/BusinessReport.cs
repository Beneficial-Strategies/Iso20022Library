// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralValueReportOrError7Choice
{
    /// <summary>
    /// Business Report.
    /// </summary>
    [DisplayName("Business Report")]
    public partial record BusinessReport : CollateralValueReportOrError7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BizRpt")]
        public required CollateralValueReport4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
