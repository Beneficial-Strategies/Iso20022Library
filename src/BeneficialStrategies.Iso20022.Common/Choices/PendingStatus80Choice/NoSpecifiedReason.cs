// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus80Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("_Cbb1waKuEfCHi7w3_0pcpw")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingStatus80Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
