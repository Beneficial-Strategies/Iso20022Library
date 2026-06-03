// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the file action response message.</summary>
    [IsoId("_kNBjq27-EfC68Y4jZPNEug")]
    [DisplayName("File Action Response")]
    public record FileActionResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FileActnRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
