// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LetterOfGuarantee3Choice
{
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_AY9vEtokEeC60axPepSq7g_-1780486835")]
    [DisplayName("Indicator")]
    public record Indicator : LetterOfGuarantee3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("Ind")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
