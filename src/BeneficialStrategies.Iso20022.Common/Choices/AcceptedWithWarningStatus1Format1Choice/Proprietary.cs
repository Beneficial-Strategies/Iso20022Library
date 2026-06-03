// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedWithWarningStatus1Format1Choice
{
    /// <summary>Proprietary code to express the processing status of the notification advice.</summary>
    [IsoId("__1hY46UdEfCnE_wCEfCqTA")]
    [DisplayName("Proprietary")]
    public record Proprietary : AcceptedWithWarningStatus1Format1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
