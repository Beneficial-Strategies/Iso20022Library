// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.WarrantStyle3Choice
{
    /// <summary>
    /// Warrant style expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_q6-rgeLbEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : WarrantStyle3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Defines how an option can be exercised.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required WarrantStyle1Code Value { get; init; }
    }
}
