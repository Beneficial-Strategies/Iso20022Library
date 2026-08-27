// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CashDeliveryMethod1Choice
{
    /// <summary>Cash delivery method as published in an external delivery method code set.</summary>
    [IsoId("_7w1L8OOwEe-NFYIkYc90gw")]
    [DisplayName("Code")]
    public record Code : CashDeliveryMethod1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ExternalDeliveryMethod1Code Value { get; init; }
    }
}
