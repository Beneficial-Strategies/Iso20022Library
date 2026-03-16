// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ElectionTypeFormat3Choice
{
    /// <summary>
    /// Standard code to specify the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_TzuzcUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : ElectionTypeFormat3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the effect on the holdings of electing a Corporate Action option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ElectionMovementType2Code Value { get; init; }
    }
}
