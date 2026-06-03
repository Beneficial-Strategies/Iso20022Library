// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the addendum initiation message.</summary>
    [IsoId("_kNBjkW7-EfC68Y4jZPNEug")]
    [DisplayName("Addendum Initiation")]
    public record AddendumInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AdddmInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
