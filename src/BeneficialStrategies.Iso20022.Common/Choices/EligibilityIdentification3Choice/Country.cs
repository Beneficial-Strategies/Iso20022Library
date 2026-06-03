// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification3Choice
{
    /// <summary>Country code used to identify the issuance country to be defined as eligible.</summary>
    [IsoId("_xHPWsWc-EemvNLufWGIVOQ")]
    [DisplayName("Country")]
    public record Country : EligibilityIdentification3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Ctry")]
        public required CountryCode Value { get; init; }
    }
}
