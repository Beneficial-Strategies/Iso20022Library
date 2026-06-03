// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the intra balance movement identification.</summary>
    [IsoId("53570b77-2ac7-4941-8bd6-de65b1dfd3bd")]
    [DisplayName("Intra Balance Movement Identification")]
    public record IntraBalanceMovementIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IntraBalMvmntId")]
        public required IsoMax35Text Value { get; init; }
    }
}
