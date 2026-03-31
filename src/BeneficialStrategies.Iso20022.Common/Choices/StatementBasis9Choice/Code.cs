// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasis9Choice
{
    /// <summary>
    /// Statement basis expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5Wx6MJNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : StatementBasis9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of balances on which the statement is prepared.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementBasis1Code Value { get; init; }
    }
}
