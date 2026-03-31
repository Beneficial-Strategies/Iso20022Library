// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionAndRepairReason24Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_WVswUzq4EeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : RejectionAndRepairReason24Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Unrecognised or invalid depository.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason32Code Value { get; init; }
    }
}
