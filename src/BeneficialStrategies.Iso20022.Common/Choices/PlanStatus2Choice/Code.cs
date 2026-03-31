// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlanStatus2Choice
{
    /// <summary>
    /// Status of the plan expressed as a code.
    /// </summary>
    [IsoId("_ZRAiMSFOEeWgV9SQSyaAog")]
    [DisplayName("Code")]
    public record Code : PlanStatus2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a plan.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PlanStatus1Code Value { get; init; }
    }
}
