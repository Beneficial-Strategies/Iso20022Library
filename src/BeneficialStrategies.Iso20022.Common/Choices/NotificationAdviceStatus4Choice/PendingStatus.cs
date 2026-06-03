// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus4Choice
{
    /// <summary>Provides information about the pending status of advice.</summary>
    [IsoId("_DYZ0UKUfEfCnE_wCEfCqTA")]
    [DisplayName("Pending Status")]
    public record PendingStatus : NotificationAdviceStatus4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgSts")]
        public required NotificationPendingStatus1 Value { get; init; }
    }
}
