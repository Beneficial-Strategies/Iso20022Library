// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradingSystemReport1Choice
{
    /// <summary>Cancellation of a previously sent report, probably because of erroneous data.</summary>
    [IsoId("_HQZLkGFdEfC-1NkZ9TkdKA")]
    [DisplayName("Cancellation")]
    public record Cancellation : TradingSystemReport1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cxl")]
        public required CancelReport1 Value { get; init; }
    }
}
