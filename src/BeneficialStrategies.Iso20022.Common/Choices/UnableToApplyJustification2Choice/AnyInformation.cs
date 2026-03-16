// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification2Choice
{
    /// <summary>
    /// Indicates whether or not all available information on the underlying payment instruction is requested.
    /// </summary>
    [IsoId("_T-i3NNp-Ed-ak6NoX_4Aeg_-1089125430")]
    [DisplayName("Any Information")]
    public record AnyInformation : UnableToApplyJustification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("AnyInf")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
