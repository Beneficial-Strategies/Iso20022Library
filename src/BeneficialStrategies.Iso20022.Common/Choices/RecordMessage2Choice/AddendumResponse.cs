// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the addendum response message.</summary>
    [IsoId("_kNBjk27-EfC68Y4jZPNEug")]
    [DisplayName("Addendum Response")]
    public record AddendumResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AdddmRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
