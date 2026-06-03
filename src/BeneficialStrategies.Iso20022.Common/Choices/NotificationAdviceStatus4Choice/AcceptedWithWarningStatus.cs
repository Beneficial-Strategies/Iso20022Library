// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus4Choice
{
    /// <summary>Provides information about the accepted with warning status.</summary>
    [IsoId("_MVTd4KUfEfCnE_wCEfCqTA")]
    [DisplayName("Accepted With Warning Status")]
    public record AcceptedWithWarningStatus : NotificationAdviceStatus4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AccptdWthWrngSts")]
        public required NotificationAcceptedWithWarningStatus1 Value { get; init; }
    }
}
