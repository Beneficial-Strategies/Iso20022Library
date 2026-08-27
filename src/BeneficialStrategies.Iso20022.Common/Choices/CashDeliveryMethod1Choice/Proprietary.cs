// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CashDeliveryMethod1Choice
{
    /// <summary>Cash delivery method, in a proprietary form.</summary>
    [IsoId("_ETdUUOOxEe-NFYIkYc90gw")]
    [DisplayName("Proprietary")]
    public record Proprietary : CashDeliveryMethod1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
