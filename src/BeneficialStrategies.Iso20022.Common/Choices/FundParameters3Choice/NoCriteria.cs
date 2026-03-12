// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundParameters3Choice
{
    /// <summary>
    /// Specifies that there is no criteria for the report. The request is a request for all reports, rather than reports attributed to a specific fund manager, date or financial instrument.
    /// </summary>
    [IsoId("_Q6l-Adp-Ed-ak6NoX_4Aeg_-960504070")]
    [DisplayName("No Criteria")]
    public partial record NoCriteria : FundParameters3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no criteria.
        /// </summary>
        [IsoXmlTag("NoCrit")]
        public required NoCriteria1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
