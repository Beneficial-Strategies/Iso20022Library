// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the card management initiation message.</summary>
    [IsoId("_kNBjm27-EfC68Y4jZPNEug")]
    [DisplayName("Card Management Initiation")]
    public record CardManagementInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CardMgmtInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
