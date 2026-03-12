// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus6Choice
{
    /// <summary>
    /// Provides a proprietary status and a proprietary reason of the processing status of the trade.
    /// </summary>
    [IsoId("_A4HJNtokEeC60axPepSq7g_-2026040667")]
    [DisplayName("Proprietary Status")]
    public partial record ProprietaryStatus : CancellationProcessingStatus6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        [IsoXmlTag("PrtrySts")]
        public required GenericIdentification20 Value { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_UatOw9p-Ed-ak6NoX_4Aeg_-1512024757")]
        [DisplayName("Proprietary Reason")]
        [IsoXmlTag("PrtryRsn")]
        public ProprietaryReason1? ProprietaryReason { get; init; } 
        
        
        #nullable disable
        
    }
}
