// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status25Choice
{
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_E09yoUQTEealVdmlTDXWkw")]
    [DisplayName("Status")]
    public record Status : Status25Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an account management instruction.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required AccountManagementStatus1Code Value { get; init; }
    }
}
