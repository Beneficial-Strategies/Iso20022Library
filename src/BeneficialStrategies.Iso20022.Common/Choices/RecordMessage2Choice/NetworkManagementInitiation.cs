// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the network management initiation message.</summary>
    [IsoId("_kNBjwW7-EfC68Y4jZPNEug")]
    [DisplayName("Network Management Initiation")]
    public record NetworkManagementInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NtwkMgmtInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
