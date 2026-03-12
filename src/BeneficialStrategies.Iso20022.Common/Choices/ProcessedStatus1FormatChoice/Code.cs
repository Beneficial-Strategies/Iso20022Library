// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus1FormatChoice
{
    /// <summary>
    /// Standard code to specify to express the processing status of the notification advice.
    /// </summary>
    [IsoId("_RnJiBNp-Ed-ak6NoX_4Aeg_-138673377")]
    [DisplayName("Code")]
    public partial record Code : ProcessedStatus1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of the notification advice.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessedStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
