// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedWithWarningStatus1Format1Choice
{
    /// <summary>Standard code to specify to express the processing status of the notification advice.</summary>
    [IsoId("__1hY4aUdEfCnE_wCEfCqTA")]
    [DisplayName("Code")]
    public record Code : AcceptedWithWarningStatus1Format1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionAcceptedWithWarningStatus1Code Value { get; init; }
    }
}
