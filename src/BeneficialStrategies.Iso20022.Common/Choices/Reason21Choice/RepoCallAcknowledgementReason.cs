// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the repo call acknowledgement reason.</summary>
    [IsoId("66364222-936c-4e3d-b695-eb46411c8adc")]
    [DisplayName("Repo Call Acknowledgement Reason")]
    public record RepoCallAcknowledgementReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RepoCallAckRsn")]
        public required AcknowledgementReason13Choice_ Value { get; init; }
    }
}
