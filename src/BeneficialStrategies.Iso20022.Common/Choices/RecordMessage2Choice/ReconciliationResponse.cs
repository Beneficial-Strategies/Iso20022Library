// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the reconciliation response message.</summary>
    [IsoId("_kNBjx27-EfC68Y4jZPNEug")]
    [DisplayName("Reconciliation Response")]
    public record ReconciliationResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RcncltnRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
