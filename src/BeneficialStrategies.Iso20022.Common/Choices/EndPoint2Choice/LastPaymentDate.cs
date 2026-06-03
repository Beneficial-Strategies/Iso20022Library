// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EndPoint2Choice
{
    /// <summary>Final payment of the standing order due.</summary>
    [IsoId("_a2rek7vGEfCYYbmqNrQFSg")]
    [DisplayName("Last Payment Date")]
    public record LastPaymentDate : EndPoint2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("LastPmtDt")]
        public required IsoISODate Value { get; init; }
    }
}
