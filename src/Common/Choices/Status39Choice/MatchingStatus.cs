// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status39Choice
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_gEIFdDi8Eeydid5dcNPKvg")]
    [DisplayName("Matching Status")]
    public partial record MatchingStatus : Status39Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MtchgSts")]
        public required MatchingStatus32Choice_ Value { get; init; }
    }
}
