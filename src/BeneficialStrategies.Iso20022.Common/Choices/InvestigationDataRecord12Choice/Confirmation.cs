// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord12Choice
{
    /// <summary>Provides confirmation that a payment has debited or credited an account.</summary>
    [IsoId("a00d9c62-0a06-4672-a62d-0e0dc4251d11")]
    [DisplayName("Confirmation")]
    public record Confirmation : InvestigationDataRecord12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Conf")]
        public required BookingConfirmation8 Value { get; init; }
    }
}
