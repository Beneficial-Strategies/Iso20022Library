// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus4Choice
{
    /// <summary>Provides information about the processing status of advice.</summary>
    [IsoId("_4z1pYaUeEfCnE_wCEfCqTA")]
    [DisplayName("Processed Status")]
    public record ProcessedStatus : NotificationAdviceStatus4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrcdSts")]
        public required NotificationProcessingStatus2 Value { get; init; }
    }
}
