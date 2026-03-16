// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssignmentMethod2Choice
{
    /// <summary>
    /// Assignment method expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_hT0ZceLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : AssignmentMethod2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Method under which assignment was conducted.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AssignmentMethod1Code Value { get; init; }
    }
}
