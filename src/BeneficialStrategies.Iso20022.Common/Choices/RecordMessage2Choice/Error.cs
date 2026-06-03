// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the error message.</summary>
    [IsoId("_kNBjo27-EfC68Y4jZPNEug")]
    [DisplayName("Error")]
    public record Error : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Err")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
