// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RevaluationIndicator1Choice
{
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_Quh38tp-Ed-ak6NoX_4Aeg_1883545020")]
    [DisplayName("Indicator")]
    public record Indicator : RevaluationIndicator1Choice_
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
