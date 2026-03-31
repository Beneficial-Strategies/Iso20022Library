// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutomaticBorrowing8Choice
{
    /// <summary>
    /// Condition for automatic borrowing expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5m6oV5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : AutomaticBorrowing8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the condition under which automatic borrowing is allowed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AutoBorrowing1Code Value { get; init; }
    }
}
