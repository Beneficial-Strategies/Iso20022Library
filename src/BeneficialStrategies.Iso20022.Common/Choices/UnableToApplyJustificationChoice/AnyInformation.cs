// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustificationChoice
{
    /// <summary>
    /// When set to yes, indicates that all available information about the underlying payment instruction shall be sent.
    /// </summary>
    [IsoId("_VFn0D9p-Ed-ak6NoX_4Aeg_10521356")]
    [DisplayName("Any Information")]
    public record AnyInformation : UnableToApplyJustificationChoice_
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
