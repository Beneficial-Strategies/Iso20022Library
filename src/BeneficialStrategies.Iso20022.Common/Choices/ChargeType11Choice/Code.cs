// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType11Choice
{
    /// <summary>Charge type expressed as an ISO 20022 code.</summary>
    [IsoId("5a3cebb8-65c3-40ef-bfa3-3432dc08561b")]
    [DisplayName("Code")]
    public record Code : ChargeType11Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ChargeType9Code Value { get; init; }
    }
}
