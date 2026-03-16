// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AllegementStatus4Choice
{
    /// <summary>
    /// Status of the allegement reported.
    /// </summary>
    [IsoId("_6MjsL5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : AllegementStatus4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an allegement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AllegementStatus1Code Value { get; init; }
    }
}
