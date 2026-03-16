// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PutType3Choice
{
    /// <summary>
    /// Put type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_buZ-MeLcEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : PutType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Defines the type of execution of the put feature.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PutType1Code Value { get; init; }
    }
}
