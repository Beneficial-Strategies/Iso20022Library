// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeType3Choice
{
    /// <summary>
    /// Trade type information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AXK_VdokEeC60axPepSq7g_1214802521")]
    [DisplayName("Code")]
    public record Code : TradeType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of executed order.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradeType3Code Value { get; init; }
    }
}
