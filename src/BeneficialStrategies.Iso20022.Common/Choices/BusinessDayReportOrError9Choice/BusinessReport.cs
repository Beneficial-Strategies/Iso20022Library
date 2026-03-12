// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError9Choice
{
    /// <summary>
    /// Reports either business day information or a business error.
    /// </summary>
    [IsoId("_ODn9IXXyEei3jO6riKEVXg")]
    [DisplayName("Business Report")]
    public partial record BusinessReport : BusinessDayReportOrError9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of a particular market infrastructure.
        /// </summary>
        [IsoId("_ONBJs3XyEei3jO6riKEVXg")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public ValueList<SystemIdentification2Choice_> SystemIdentification { get; init; } = new ValueList<SystemIdentification2Choice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _ONBJs3XyEei3jO6riKEVXg
        
        /// <summary>
        /// Requested information on the system availability for a specific business day or business error when information has not been found.
        /// </summary>
        [IsoId("_ONBJtXXyEei3jO6riKEVXg")]
        [DisplayName("Business Day Or Error")]
        [IsoXmlTag("BizDayOrErr")]
        public required BusinessDayReportOrError10Choice_ BusinessDayOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
