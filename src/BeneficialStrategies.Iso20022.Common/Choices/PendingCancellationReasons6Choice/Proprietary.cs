// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReasons6Choice
{
    /// <summary>Specifies the reason why the cancellation request is pending.</summary>
    [IsoId("_2avCDaoWEfCG2_q2WT-90w")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingCancellationReasons6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
