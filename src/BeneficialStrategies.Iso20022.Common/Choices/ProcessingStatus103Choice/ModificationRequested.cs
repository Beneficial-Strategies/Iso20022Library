// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus103Choice
{
    /// <summary>Specifies the modification requested status.</summary>
    [IsoId("7bed2fc0-4e01-4073-899b-e3ed59544d8b")]
    [DisplayName("Modification Requested")]
    public record ModificationRequested : ProcessingStatus103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ModReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
