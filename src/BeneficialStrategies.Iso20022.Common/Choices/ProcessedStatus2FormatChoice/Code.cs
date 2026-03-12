// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus2FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing status of a cancellation request.
    /// </summary>
    [IsoId("_RnJiB9p-Ed-ak6NoX_4Aeg_-2111312844")]
    [DisplayName("Code")]
    public partial record Code : ProcessedStatus2FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of a cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessedStatus2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
