// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus4Choice
{
    /// <summary>Provides information about the rejection status.</summary>
    [IsoId("_4z1pY6UeEfCnE_wCEfCqTA")]
    [DisplayName("Rejected Status")]
    public record RejectedStatus : NotificationAdviceStatus4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RjctdSts")]
        public required NotificationRejectionReason3 Value { get; init; }
    }
}
