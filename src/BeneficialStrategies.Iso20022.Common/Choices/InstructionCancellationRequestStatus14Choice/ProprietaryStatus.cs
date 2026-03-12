// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus14Choice
{
    /// <summary>
    /// Proprietary status related to an instruction cancellation request.
    /// </summary>
    [IsoId("_peWYtzi7Eeydid5dcNPKvg")]
    [DisplayName("Proprietary Status")]
    public partial record ProprietaryStatus : InstructionCancellationRequestStatus14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        [IsoXmlTag("PrtrySts")]
        public required GenericIdentification47 Value { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_cemex5KQEeWHWpTQn1FFVg")]
        [DisplayName("Proprietary Reason")]
        [IsoXmlTag("PrtryRsn")]
        public ProprietaryReason5? ProprietaryReason { get; init; } 
        
        
        #nullable disable
        
    }
}
