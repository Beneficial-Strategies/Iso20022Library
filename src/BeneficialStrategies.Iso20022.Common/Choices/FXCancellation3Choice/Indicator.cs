// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FXCancellation3Choice
{
    /// <summary>
    /// Specifies whether the underlying forex transaction should also be cancelled. Yes means forex is to be cancelled. No means forex is to be retained.
    /// </summary>
    [IsoId("_Io5B4T0EEeWjqIDN7tjEjQ")]
    [DisplayName("Indicator")]
    public record Indicator : FXCancellation3Choice_
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
