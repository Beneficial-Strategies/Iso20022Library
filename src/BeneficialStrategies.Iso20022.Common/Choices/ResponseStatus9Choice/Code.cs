// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus9Choice
{
    /// <summary>
    /// Specifies the status of the response expressed as a code.
    /// </summary>
    [IsoId("_OIky8LzdEeivTd4NUfCi2g")]
    [DisplayName("Code")]
    public record Code : ResponseStatus9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ResponseStatus2Code Value { get; init; }
    }
}
