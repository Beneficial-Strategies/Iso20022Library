// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus12Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_Ehhd7_7ZEeCtrO5qCU90cA")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : MatchingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Umtchd")]
        public required UnmatchedStatus6Choice_ Value { get; init; }
    }
}
