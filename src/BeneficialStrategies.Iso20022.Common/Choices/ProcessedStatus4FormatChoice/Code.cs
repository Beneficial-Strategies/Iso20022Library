// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus4FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing status of the standing instruction cancellation request.
    /// </summary>
    [IsoId("_RnmN8Np-Ed-ak6NoX_4Aeg_-863903245")]
    [DisplayName("Code")]
    public partial record Code : ProcessedStatus4FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of the standing instruction cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessedStatus4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
