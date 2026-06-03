// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the fee collection initiation message.</summary>
    [IsoId("_kNBjpW7-EfC68Y4jZPNEug")]
    [DisplayName("Fee Collection Initiation")]
    public record FeeCollectionInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FeeColltnInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
