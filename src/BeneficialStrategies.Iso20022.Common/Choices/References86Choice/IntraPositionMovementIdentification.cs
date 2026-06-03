// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the intra position movement identification.</summary>
    [IsoId("0577edb6-a64d-496d-b1fe-82f9a12a9d98")]
    [DisplayName("Intra Position Movement Identification")]
    public record IntraPositionMovementIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IntraPosMvmntId")]
        public required IsoMax35Text Value { get; init; }
    }
}
