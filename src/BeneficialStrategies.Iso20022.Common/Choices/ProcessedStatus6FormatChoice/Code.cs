// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus6FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing status of a deactivation instruction.
    /// </summary>
    [IsoId("_RnmN9tp-Ed-ak6NoX_4Aeg_-1064962646")]
    [DisplayName("Code")]
    public partial record Code : ProcessedStatus6FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of a deactivation instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessedStatus6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
