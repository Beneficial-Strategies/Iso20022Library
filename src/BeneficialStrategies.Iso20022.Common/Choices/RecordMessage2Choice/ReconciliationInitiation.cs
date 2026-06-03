// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the reconciliation initiation message.</summary>
    [IsoId("_kNBjxW7-EfC68Y4jZPNEug")]
    [DisplayName("Reconciliation Initiation")]
    public record ReconciliationInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RcncltnInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
