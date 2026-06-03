// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the charge back response message.</summary>
    [IsoId("_kNBjoW7-EfC68Y4jZPNEug")]
    [DisplayName("Charge Back Response")]
    public record ChargeBackResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ChrgBckRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
