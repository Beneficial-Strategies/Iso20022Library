// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutomaticBorrowing7Choice
{
    /// <summary>
    /// Condition for automatic borrowing expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_GoKdMTt4EeW638lNyHKv7A")]
    [DisplayName("Code")]
    public record Code : AutomaticBorrowing7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the condition under which automatic borrowing is allowed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AutoBorrowing2Code Value { get; init; }
    }
}
