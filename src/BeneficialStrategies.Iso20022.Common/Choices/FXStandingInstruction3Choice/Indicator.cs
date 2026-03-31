// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FXStandingInstruction3Choice
{
    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    [IsoId("_Aamt1dokEeC60axPepSq7g_1488577319")]
    [DisplayName("Indicator")]
    public record Indicator : FXStandingInstruction3Choice_
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
