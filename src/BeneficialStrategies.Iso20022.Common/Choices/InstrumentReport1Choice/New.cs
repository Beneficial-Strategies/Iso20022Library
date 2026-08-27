// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentReport1Choice
{
    /// <summary>Instrument related data report.</summary>
    [IsoId("_ZFrzIGFSEfC91ZUW7iS7ww")]
    [DisplayName("New")]
    public record New : InstrumentReport1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("New")]
        public required InstrumentReport1 Value { get; init; }
    }
}
