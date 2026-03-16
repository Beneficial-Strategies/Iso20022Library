// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus3Choice
{
    /// <summary>
    /// Proprietary status related to the event processing.
    /// </summary>
    [IsoId("_tDTUuUGSEeWqy4niLuXETA")]
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : EventProcessingStatus3Choice_
    {
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        [IsoXmlTag("PrtrySts")]
        public required GenericIdentification30 Value { get; init; }

        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_y0OagTp4EeWVrPy0StzzSg")]
        [DisplayName("Proprietary Reason")]
        [IsoXmlTag("PrtryRsn")]
        public ProprietaryReason4? ProprietaryReason { get; init; }
    }
}
