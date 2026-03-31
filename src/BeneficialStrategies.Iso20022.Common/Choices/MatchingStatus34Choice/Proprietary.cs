// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus34Choice
{
    /// <summary>
    /// Proprietary status.
    /// </summary>
    [IsoId("_yaCR8BUHEeuZw7VHHgrHLg")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : MatchingStatus34Choice_
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
