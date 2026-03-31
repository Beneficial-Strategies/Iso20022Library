// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExecutingParty2Choice
{
    /// <summary>
    /// Algorithm.
    /// </summary>
    [DisplayName("Algorithm")]
    public record Algorithm : ExecutingParty2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Algo")]
        public required IsoMax50Text Value { get; init; }
    }
}
