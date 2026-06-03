// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the file action initiation message.</summary>
    [IsoId("_kNBjqW7-EfC68Y4jZPNEug")]
    [DisplayName("File Action Initiation")]
    public record FileActionInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FileActnInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
