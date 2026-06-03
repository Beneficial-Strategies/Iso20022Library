// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus34Choice
{
    /// <summary>Indicates that there is no reason available or to report.</summary>
    [IsoId("_XJtf5Y5bEfC_4ZEXsY0Xyg")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : AcknowledgedAcceptedStatus34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
