// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeFrame4Choice
{
    /// <summary>
    /// An agreed number of days after the renunciation of title documents are received used to define standard timeframes in Redemption e.g R+3 Redemption settlement cycle.
    /// </summary>
    [IsoId("_UAew69p-Ed-ak6NoX_4Aeg_500203194")]
    [DisplayName("Renunciation Plus")]
    public record RenunciationPlus : TimeFrame4Choice_
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
