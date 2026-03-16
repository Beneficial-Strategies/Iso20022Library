// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus8Choice
{
    /// <summary>
    /// Proprietary status.
    /// </summary>
    [IsoId("_6QCdU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Proprietary")]
    public record Proprietary : ModificationProcessingStatus8Choice_
    {
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        [IsoId("_cemexZKQEeWHWpTQn1FFVg")]
        [DisplayName("Proprietary Status")]
        [IsoXmlTag("PrtrySts")]
        public required GenericIdentification47 ProprietaryStatus { get; init; }

        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_cemex5KQEeWHWpTQn1FFVg")]
        [DisplayName("Proprietary Reason")]
        [IsoXmlTag("PrtryRsn")]
        public ProprietaryReason5? ProprietaryReason { get; init; }
    }
}
