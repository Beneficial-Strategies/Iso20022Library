// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the charge back initiation message.</summary>
    [IsoId("_kNBjn27-EfC68Y4jZPNEug")]
    [DisplayName("Charge Back Initiation")]
    public record ChargeBackInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ChrgBckInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
