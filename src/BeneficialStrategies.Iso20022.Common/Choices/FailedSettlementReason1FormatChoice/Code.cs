// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FailedSettlementReason1FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a settlement failure.
    /// </summary>
    [IsoId("_RmjsI9p-Ed-ak6NoX_4Aeg_-183406333")]
    [DisplayName("Code")]
    public record Code : FailedSettlementReason1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a settlement failure.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FailedSettlementReason1Code Value { get; init; }
    }
}
