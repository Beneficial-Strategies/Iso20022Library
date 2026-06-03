// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord12Choice
{
    /// <summary>Indicates if the debit authorisation is granted or not.</summary>
    [IsoId("60e760ac-2333-4a1d-8ff2-a9c214d310e0")]
    [DisplayName("Debit Authorisation")]
    public record DebitAuthorisation : InvestigationDataRecord12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DbtAuthstn")]
        public required DebitAuthorisationConfirmation3 Value { get; init; }
    }
}
