// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the amendment message.</summary>
    [IsoId("_kNBjlW7-EfC68Y4jZPNEug")]
    [DisplayName("Amendment")]
    public record Amendment : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Amdmnt")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
