// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason13Choice
{
    /// <summary>Proprietary identification of the reason why a cancellation request sent for the related instruction is pending.</summary>
    [IsoId("_J1blua8xEfCx2aBifPEdRg")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingCancellationReason13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
