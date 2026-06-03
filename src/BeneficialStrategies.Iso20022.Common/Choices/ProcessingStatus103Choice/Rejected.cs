// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus103Choice
{
    /// <summary>Specifies the rejected status.</summary>
    [IsoId("06f204aa-dfaa-4630-9e42-9db0adb24c09")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionStatus38Choice_ Value { get; init; }
    }
}
