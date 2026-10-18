// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus30Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_6QABoZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : MatchingStatus30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Umtchd")]
        public required UnmatchedStatus20Choice_ Value { get; init; }
    }
}
