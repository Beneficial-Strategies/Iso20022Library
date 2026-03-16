// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status15Choice
{
    /// <summary>
    /// Proprietary status.
    /// </summary>
    [IsoId("_EU__1SRhEeO8sskhVI3IDA")]
    [DisplayName("Proprietary")]
    public record Proprietary : Status15Choice_
    {
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        [IsoId("_UatOwtp-Ed-ak6NoX_4Aeg_-1158092658")]
        [DisplayName("Proprietary Status")]
        [IsoXmlTag("PrtrySts")]
        public required GenericIdentification20 ProprietaryStatus { get; init; }

        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_UatOw9p-Ed-ak6NoX_4Aeg_-1512024757")]
        [DisplayName("Proprietary Reason")]
        [IsoXmlTag("PrtryRsn")]
        public ProprietaryReason1? ProprietaryReason { get; init; }
    }
}
