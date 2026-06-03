// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the card management response message.</summary>
    [IsoId("_kNBjnW7-EfC68Y4jZPNEug")]
    [DisplayName("Card Management Response")]
    public record CardManagementResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CardMgmtRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
