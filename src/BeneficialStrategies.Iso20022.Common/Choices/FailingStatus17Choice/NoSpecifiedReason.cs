// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FailingStatus17Choice
{
    /// <summary>Indicates that there is no reason available or to report.</summary>
    [IsoId("_0o3p4eSkEe-qVZLXW4RRBw")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : FailingStatus17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
