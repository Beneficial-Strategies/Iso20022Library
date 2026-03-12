// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus51Choice
{
    /// <summary>
    /// Status that cannot be reported using one of the available standard status.
    /// </summary>
    [IsoId("_jWWVmTnvEeWfSKvvZlhRKg")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : ProcessingStatus51Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        [IsoId("_y0NzcTp4EeWVrPy0StzzSg")]
        [DisplayName("Proprietary Status")]
        [IsoXmlTag("PrtrySts")]
        public required GenericIdentification30 ProprietaryStatus { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_y0OagTp4EeWVrPy0StzzSg")]
        [DisplayName("Proprietary Reason")]
        [IsoXmlTag("PrtryRsn")]
        public ProprietaryReason4? ProprietaryReason { get; init; } 
        
        
        #nullable disable
        
    }
}
