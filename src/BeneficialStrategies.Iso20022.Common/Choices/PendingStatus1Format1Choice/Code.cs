// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus1Format1Choice
{
    /// <summary>Standard code to specify to express the processing status of the notification advice.</summary>
    [IsoId("_pRDGYaUdEfCnE_wCEfCqTA")]
    [DisplayName("Code")]
    public record Code : PendingStatus1Format1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionPendingStatus1Code Value { get; init; }
    }
}
