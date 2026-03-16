// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ElectionMovementType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the effect on the holdings of electing a Corporate Action option.
    /// </summary>
    [IsoId("_RmjsINp-Ed-ak6NoX_4Aeg_2024835239")]
    [DisplayName("Code")]
    public record Code : ElectionMovementType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the effect on the holdings of electing a Corporate Action option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ElectionMovementType1Code Value { get; init; }
    }
}
