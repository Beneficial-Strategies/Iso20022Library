// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus59Choice
{
    /// <summary>Provides status information related to a buyer instruction request that is accepted and confirmed (matched by the counterparty).</summary>
    [IsoId("_j-yrmd75Ee-NrtAAlrBEgQ")]
    [DisplayName("Accepted And Confirmed")]
    public record AcceptedAndConfirmed : InstructionProcessingStatus59Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AccptdAndConfd")]
        public required NoReasonCode Value { get; init; }
    }
}
