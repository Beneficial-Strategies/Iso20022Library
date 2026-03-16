// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeFrame8Choice
{
    /// <summary>
    /// Number of days after the renunciation of title documents are received used to define the standard settlement timeframe.
    /// </summary>
    [IsoId("_cB3nRTgFEei6RvewLQWEqw")]
    [DisplayName("Renunciation Plus")]
    public record RenunciationPlus : TimeFrame8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("RPlus")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
