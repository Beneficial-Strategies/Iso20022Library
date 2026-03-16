// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason12Choice
{
    /// <summary>
    /// No reason available or to report for the cancelled status.
    /// </summary>
    [IsoId("_7TP5EUHTEeasdbKMiqizqA")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : CancelledReason12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
