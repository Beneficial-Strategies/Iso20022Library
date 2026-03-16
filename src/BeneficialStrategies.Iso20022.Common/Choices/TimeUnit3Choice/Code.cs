// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeUnit3Choice
{
    /// <summary>
    /// Time unit expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_oTL_UeLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : TimeUnit3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Unit of time associated with the contract.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TimeUnit1Code Value { get; init; }
    }
}
