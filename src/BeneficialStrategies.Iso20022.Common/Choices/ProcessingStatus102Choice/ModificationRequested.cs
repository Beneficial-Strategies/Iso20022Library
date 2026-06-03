// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the modification requested status.</summary>
    [IsoId("4b664b0e-85ca-4039-8231-4c03c817a6fb")]
    [DisplayName("Modification Requested")]
    public record ModificationRequested : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ModReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
