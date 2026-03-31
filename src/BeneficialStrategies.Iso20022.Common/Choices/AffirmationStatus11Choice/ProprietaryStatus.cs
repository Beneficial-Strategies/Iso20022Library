// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus11Choice
{
    /// <summary>
    /// Provides a proprietary status and a proprietary reason of the affirmation of the trade.
    /// </summary>
    [IsoId("_XzM-1Qd3Ee2fOITqoTnSLQ")]
    [DisplayName("Proprietary Status")]
    [IsoXmlTag("PrtrySts")]
    public record ProprietaryStatus : AffirmationStatus11Choice_
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
