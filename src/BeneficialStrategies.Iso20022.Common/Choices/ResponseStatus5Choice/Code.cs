// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus5Choice
{
    /// <summary>
    /// Provides the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
    /// </summary>
    [IsoId("_klDTUTqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : ResponseStatus5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ResponseStatus1Code Value { get; init; }
    }
}
