// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason4Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [IsoId("_QxqEd9p-Ed-ak6NoX_4Aeg_-168728675")]
    [DisplayName("Code")]
    public record Code : PendingReason4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Standard code to specify the reason why the instruction/event has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason4Code Value { get; init; }
    }
}
