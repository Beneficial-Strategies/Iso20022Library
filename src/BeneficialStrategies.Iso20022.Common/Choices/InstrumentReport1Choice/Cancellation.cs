// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentReport1Choice
{
    /// <summary>Cancellation of a previously sent report, probably because of erroneous data.</summary>
    [IsoId("_fc83MGFSEfC91ZUW7iS7ww")]
    [DisplayName("Cancellation")]
    public record Cancellation : InstrumentReport1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cxl")]
        public required CancelReport1 Value { get; init; }
    }
}
