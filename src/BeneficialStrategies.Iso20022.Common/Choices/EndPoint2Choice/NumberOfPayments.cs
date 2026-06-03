// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EndPoint2Choice
{
    /// <summary>Number of the payments that will be made in completing this frequency sequence.</summary>
    [IsoId("_a2rekbvGEfCYYbmqNrQFSg")]
    [DisplayName("Number Of Payments")]
    public record NumberOfPayments : EndPoint2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NbOfPmts")]
        public required IsoMax35Text Value { get; init; }
    }
}
