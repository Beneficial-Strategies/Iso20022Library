// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the network management response message.</summary>
    [IsoId("_kNBjw27-EfC68Y4jZPNEug")]
    [DisplayName("Network Management Response")]
    public record NetworkManagementResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NtwkMgmtRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
