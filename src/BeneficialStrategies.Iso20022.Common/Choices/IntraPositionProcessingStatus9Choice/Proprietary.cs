// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus9Choice
{
    /// <summary>
    /// Specifies a choice of status for the processing of an intra-position movement.
    /// </summary>
    [IsoId("_ZkDCMStUEeyhipY4f42fZQ")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : IntraPositionProcessingStatus9Choice_
    {
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
    }
}
