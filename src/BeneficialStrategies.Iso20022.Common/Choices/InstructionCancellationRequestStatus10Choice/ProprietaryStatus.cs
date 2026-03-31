// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus10Choice
{
    /// <summary>
    /// Proprietary status related to an instruction cancellation request.
    /// </summary>
    [IsoId("_ce-5zZKQEeWHWpTQn1FFVg")]
    [DisplayName("Proprietary Status")]
    [IsoXmlTag("PrtrySts")]
    public record ProprietaryStatus : InstructionCancellationRequestStatus10Choice_
    {
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
    }
}
