// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EUDividendStatusType3Choice
{
    /// <summary>EU dividend status expressed as an ISO 20022 code.</summary>
    [IsoId("6eb9b796-22a9-4ebc-ba56-e0b7c0fa948c")]
    [DisplayName("Code")]
    public record Code : EUDividendStatusType3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required EUDividendStatus1Code Value { get; init; }
    }
}
