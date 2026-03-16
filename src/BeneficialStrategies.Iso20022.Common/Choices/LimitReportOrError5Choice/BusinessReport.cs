// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LimitReportOrError5Choice
{
    /// <summary>
    /// Business Report.
    /// </summary>
    [DisplayName("Business Report")]
    public partial record BusinessReport : LimitReportOrError5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BizRpt")]
        public required Limits8 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
