// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status32Choice
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_BH0PiQpIEeup4r-PFG2T5Q")]
    [DisplayName("Matching Status")]
    public partial record MatchingStatus : Status32Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MtchgSts")]
        public required MatchingStatus24Choice_ Value { get; init; }
    }
}
