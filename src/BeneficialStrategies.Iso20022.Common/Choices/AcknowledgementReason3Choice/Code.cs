// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason3Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_UXb4Udp-Ed-ak6NoX_4Aeg_-1471943913")]
    [DisplayName("Code")]
    public record Code : AcknowledgementReason3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about the repurchase agreement call processed instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepoCallAcknowledgementReason2Code Value { get; init; }
    }
}
