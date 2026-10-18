// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_9HwpkzqpEeWyoP0PbocV1Q")]
    [DisplayName("Affirmation Status")]
    public partial record AffirmationStatus : Status19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AffirmSts")]
        public required AffirmationStatus8Choice_ Value { get; init; }
    }
}
